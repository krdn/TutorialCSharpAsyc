namespace AsyncAwait;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void RunAnything(Label lbl)
    {
        for (int i = 0; i < 30; i++)
        {
            Thread.Sleep(100);
            lbl.Text = i.ToString();
            lbl.Refresh();
        }
    }

    private async void RunAnythingAsync(Label lbl)
    {
        for (int i = 0; i < 30; i++)
        {
            await Task.Delay(100);
            lbl.Text = i.ToString();
            lbl.Refresh();
        }
    }

    private void btnWalking_Click(object? sender, EventArgs e)
    {
        RunAnything(lblWalking);

    }
    private void btnPhone_Click(object? sender, EventArgs e)
    {

        RunAnything(lblPhone);
    }

    private void btnTalking_Click(object? sender, EventArgs e)
    {
        RunAnything(lblTalking);

    }

    #region 비동기 버전

    private void btnWalking_ClickAsync(object? sender, EventArgs e)
    {
        RunAnythingAsync(lblWalking);
    }

    private void btnPhone_ClickAsync(object? sender, EventArgs e)
    {
        RunAnythingAsync(lblPhone);
    }

    private void btnTalking_ClickAsync(object? sender, EventArgs e)
    {
        RunAnythingAsync(lblTalking);
    }

    #endregion


    private void chkAsync_CheckedChanged(object sender, EventArgs e)
    {
        if (chkAsync.Checked)
        {
            btnWalking.Click -= btnWalking_Click;
            btnWalking.Click += btnWalking_ClickAsync;

            btnPhone.Click -= btnPhone_Click;
            btnPhone.Click += btnPhone_ClickAsync;

            btnTalking.Click -= btnTalking_Click;
            btnTalking.Click += btnTalking_ClickAsync;
        }
        else
        {
            btnWalking.Click -= btnWalking_ClickAsync;
            btnWalking.Click += btnWalking_Click;

            btnPhone.Click -= btnPhone_ClickAsync;
            btnPhone.Click += btnPhone_Click;

            btnTalking.Click -= btnTalking_ClickAsync;
            btnTalking.Click += btnTalking_Click;
        }

    }


    // Task를 반환해야 비동기로 동작(await사용가능)한다.
    private async Task RunAllAsync(Label lbl)
    {
        for (int i = 0; i < 30; i++)
        {
            await Task.Delay(100);
            this.lbAll.Items.Add($"{lbl.Name} - {i}");
        }
    }

    private async void btnAll_ClickAsync(object? sender, EventArgs e)
    {
        lbAll.Items.Clear();
        await RunAllAsync(lblWalking);
        await RunAllAsync(lblPhone);
        await RunAllAsync(lblTalking);
    }

    private void btnAll_ClickAsyncAwait(object? sender, EventArgs e)
    {
        lbAll.Items.Clear();
        _ = RunAllAsync(lblWalking);
        _ = RunAllAsync(lblPhone);
        _ = RunAllAsync(lblTalking);
    }

    private void chkAwait_CheckedChanged(object sender, EventArgs e)
    {
        if (chkAwait.Checked)
        {
            btnAll.Click -= btnAll_ClickAsync;
            btnAll.Click += btnAll_ClickAsyncAwait;
        }
        else
        {
            btnAll.Click -= btnAll_ClickAsyncAwait;
            btnAll.Click += btnAll_ClickAsync;
        }
    }

 
}
