namespace CancellationToken;

public partial class Form1 : Form
{
    // 비동기 취소: CancellationTokenSource
    // 비동기 취소 여부 추적: CancellationToken

    CancellationTokenSource cts = new CancellationTokenSource();

    public Form1()
    {
        InitializeComponent();
    }

    private async Task DoWorkAsync(System.Threading.CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            await Task.Delay(100);
            int.TryParse(lblIndex.Text, out int index);
            lblIndex.Text = $"{++index}";
        }
    }

    private async Task DoWorkAsyncThrowError(System.Threading.CancellationToken token)
    {
        while (true)
        {
            // 오류를 방생시켜 비동기 작업을 취소시킴
            token.ThrowIfCancellationRequested();

            await Task.Delay(100);
            int.TryParse(lblIndex.Text, out int index);
            lblIndex.Text = $"{++index}";
        }
    }

    private async void btnStart_Click(object sender, EventArgs e)
    {
        // 비동기 취소: CancellationTokenSource
        // 비동기 취소 여부 추적: CancellationToken
        cts = new CancellationTokenSource();
        var token = cts.Token;

        await DoWorkAsync(token);
    }

    private async void btnStartThrowError_Click(object? sender, EventArgs e)
    {
        cts = new CancellationTokenSource();
        var token = cts.Token;

        try
        {
            await DoWorkAsyncThrowError(token);
        }
        catch (OperationCanceledException exception)
        {
            MessageBox.Show(exception.Message);
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        cts.Cancel();
    }

    private void chkThrowIfCancellationRequested_CheckedChanged(object sender, EventArgs e)
    {

        if (chkThrowIfCancellationRequested.Checked)
        {
            btnStart.Click -= btnStart_Click;
            btnStart.Click += btnStartThrowError_Click;
        }
        else
        {
            btnStart.Click -= btnStartThrowError_Click;
            btnStart.Click += btnStart_Click;
        }

    }


}
