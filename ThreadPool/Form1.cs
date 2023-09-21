using System.Diagnostics;
using ThreadPool.Utils;

namespace ThreadPool;

public partial class Form1 : Form
{
    private readonly string _source = @"D:\Temp\SourceDir\E10.2023.0815.1080P.H264.zip";
    private readonly string _destination = @"D:\Temp\DestDir\E10.2023.0815.1080P.H264.zip";

    private int CurrentThreadId => Thread.CurrentThread.ManagedThreadId;

    public Form1()
    {
        InitializeComponent();

        // 테스트 전송된 파일 삭제
        if (File.Exists(_destination))
        {
            try
            {
                File.Delete(_destination);
            }
            catch (Exception e)
            {
                Debug.WriteLine("The deletion failed: {0}", e.Message);
            }
        }
        else
        {
            Debug.WriteLine("File does not exist");
        }
    }

    private async Task CopyFileAsync()
    {
        Debug.WriteLine($"CopyFile Async Main Thread ID: {CurrentThreadId}");
        FileUtils.Copy(_source, _destination, fileProgress: FileProgress);
    }

    private async void btnCopyMain_Click(object sender, EventArgs e)
    {
        Debug.WriteLine($"시작 Main Thread ID: {CurrentThreadId}");
        await CopyFileAsync();
    }

    private void FileProgress(string currentUnits, string totalUnits, int progress)
    {
        if (this.InvokeRequired)
        {
            this.Invoke(new Action<string, string, int>(FileProgress), currentUnits, totalUnits, progress);
            return;
        }
        else
        {
            lblMain.Text = $@"Copied {currentUnits} of {totalUnits} ({progress}%)";
            progressMain.Value = progress;
        }
    }

    #region Background Thread

    private async Task CopyFileBackAsync()
    {
        await Task.Run(() =>
        {
            Debug.Print($"CopyFileBackAsync Main Thread ID: {CurrentThreadId}");
            FileUtils.Copy(_source, _destination, fileProgress: FileProgress);
        });
    }

    private async void btnCopyBack_Click(object sender, EventArgs e)
    {
        Debug.Print($"시작 Thread ID: {CurrentThreadId}");
        await CopyFileBackAsync();
    }

    #endregion
}
