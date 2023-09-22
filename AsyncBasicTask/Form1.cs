using Microsoft.VisualBasic.Logging;
using System.Diagnostics;

namespace AsyncBasicTask;

public partial class Form1 : Form
{
    Stopwatch _sw = new Stopwatch();

    private double ArriveTime() => Math.Round(_sw.ElapsedMilliseconds / 1000d, 2);


    public Form1()
    {
        InitializeComponent();
    }

    private void Start()
    {
        _sw.Start();
        ClearLogs();
        ResetBugs();
    }



    private void End()
    {
        AddLogs($"총 소요시간 {ArriveTime()} 초");
        _sw.Stop();
        _sw.Reset();
    }

    // 로그 리스트 추가
    private void AddLogs(params string[] texts) => lbLogs.Items.AddRange(texts);

    // 로그 리스트 초기화
    private void ClearLogs() => lbLogs.Items.Clear();

    // 버그 위치 초기화
    private void ResetBugs()
    {
        var bugs = new List<Label> { bugA, bugB, bugC, bugD };
        bugs.ForEach(bug => bug.Location = new Point(125, bug.Location.Y));
    }

    // 버그 이동 (비동기)
    private async Task<string> MoveLabel(Label bug, int speed)
    {
        int endX = finishLine.Location.X - bug.Width;

        while (bug.Location.X < endX)
        {
            bug.Location = new Point(bug.Location.X + speed * 4, bug.Location.Y);
            await Task.Delay(1);
        }
        bug.Location = new Point(endX, bug.Location.Y);

        return $"{bug.Text} 도착시간: {ArriveTime()}초";
    }

    private async void btnStart1_Click(object sender, EventArgs e)
    {
        Start();

        string logA = await MoveLabel(bugA, 1);
        string logB = await MoveLabel(bugB, 2);
        string logC = await MoveLabel(bugC, 3);
        string logD = await MoveLabel(bugD, 4);

        AddLogs(logA, logB, logC, logD);

        End();
    }

    private async void btnStart2_Click(object sender, EventArgs e)
    {
        Start();

        Task<string> aTask = MoveLabel(bugA, 1);
        Task<string> bTask = MoveLabel(bugB, 2);

        //string logA = await aTask;
        //string logB = await bTask;
        //AddLogs(logA, logB);
        string[] logs = await Task.WhenAll(aTask, bTask);
        AddLogs(logs);

        Task<string> cTask = MoveLabel(bugC, 3);
        Task<string> dTask = MoveLabel(bugD, 4);

        //string logC = await cTask;
        //string logD = await dTask;
        //AddLogs(logC, logD);
        logs = await Task.WhenAll(cTask, dTask);
        AddLogs(logs);

        End();
    }

    private async void btnStartAll_Click(object sender, EventArgs e)
    {
        Start();

        Task<string> aTask = MoveLabel(bugA, 1);
        Task<string> bTask = MoveLabel(bugB, 2);
        Task<string> cTask = MoveLabel(bugC, 3);
        Task<string> dTask = MoveLabel(bugD, 4);

        //await aTask;
        //await bTask;
        //await bTask;
        //await dTask;

        var logs = await Task.WhenAll(aTask, bTask, cTask, dTask);
        AddLogs(logs);

        End();
    }

    private async void btnStartAll2_Click(object sender, EventArgs e)
    {
        Start();

        Task<string> aTask = MoveLabel(bugA, 1);
        Task<string> bTask = MoveLabel(bugB, 2);
        Task<string> cTask = MoveLabel(bugC, 3);
        Task<string> dTask = MoveLabel(bugD, 4);

        var tasks = new List<Task<string>> { aTask, bTask, cTask, dTask };

        while (tasks.Count > 0)
        {
            var task = await Task.WhenAny(tasks);
            //if (task == cTask)
            //{
            //    AddLogs(await cTask); 
            //}

            tasks.Remove(task);
        }

        End();
    }
}
