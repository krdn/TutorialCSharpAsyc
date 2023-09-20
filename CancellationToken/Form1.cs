namespace CancellationToken;

public partial class Form1 : Form
{
    // �񵿱� ���: CancellationTokenSource
    // �񵿱� ��� ���� ����: CancellationToken

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
            // ������ ������� �񵿱� �۾��� ��ҽ�Ŵ
            token.ThrowIfCancellationRequested();

            await Task.Delay(100);
            int.TryParse(lblIndex.Text, out int index);
            lblIndex.Text = $"{++index}";
        }
    }

    private async void btnStart_Click(object sender, EventArgs e)
    {
        // �񵿱� ���: CancellationTokenSource
        // �񵿱� ��� ���� ����: CancellationToken
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
