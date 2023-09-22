namespace AsyncBasicTask;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnStart1 = new Button();
        btnStart2 = new Button();
        btnStartAll = new Button();
        btnStartAll2 = new Button();
        bugA = new Label();
        bugB = new Label();
        bugC = new Label();
        bugD = new Label();
        lbLogs = new ListBox();
        finishLine = new Label();
        SuspendLayout();
        // 
        // btnStart1
        // 
        btnStart1.Location = new Point(12, 12);
        btnStart1.Name = "btnStart1";
        btnStart1.Size = new Size(107, 74);
        btnStart1.TabIndex = 0;
        btnStart1.Text = "1. 하나씩\r\n출발";
        btnStart1.UseVisualStyleBackColor = true;
        btnStart1.Click += btnStart1_Click;
        // 
        // btnStart2
        // 
        btnStart2.Location = new Point(12, 86);
        btnStart2.Name = "btnStart2";
        btnStart2.Size = new Size(107, 74);
        btnStart2.TabIndex = 1;
        btnStart2.Text = "2. A와 B\r\n먼저 출발";
        btnStart2.UseVisualStyleBackColor = true;
        btnStart2.Click += btnStart2_Click;
        // 
        // btnStartAll
        // 
        btnStartAll.Location = new Point(12, 160);
        btnStartAll.Name = "btnStartAll";
        btnStartAll.Size = new Size(107, 74);
        btnStartAll.TabIndex = 2;
        btnStartAll.Text = "3. 같이\r\n출발";
        btnStartAll.UseVisualStyleBackColor = true;
        btnStartAll.Click += btnStartAll_Click;
        // 
        // btnStartAll2
        // 
        btnStartAll2.Location = new Point(12, 234);
        btnStartAll2.Name = "btnStartAll2";
        btnStartAll2.Size = new Size(107, 74);
        btnStartAll2.TabIndex = 3;
        btnStartAll2.Text = "4.같이\r\n출발\r\n(WhenAny)";
        btnStartAll2.UseVisualStyleBackColor = true;
        btnStartAll2.Click += btnStartAll2_Click;
        // 
        // bugA
        // 
        bugA.AutoSize = true;
        bugA.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
        bugA.Location = new Point(125, 42);
        bugA.Name = "bugA";
        bugA.Size = new Size(29, 25);
        bugA.TabIndex = 4;
        bugA.Text = "A.";
        // 
        // bugB
        // 
        bugB.AutoSize = true;
        bugB.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
        bugB.Location = new Point(125, 109);
        bugB.Name = "bugB";
        bugB.Size = new Size(27, 25);
        bugB.TabIndex = 5;
        bugB.Text = "B.";
        // 
        // bugC
        // 
        bugC.AutoSize = true;
        bugC.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
        bugC.Location = new Point(125, 176);
        bugC.Name = "bugC";
        bugC.Size = new Size(28, 25);
        bugC.TabIndex = 6;
        bugC.Text = "C.";
        // 
        // bugD
        // 
        bugD.AutoSize = true;
        bugD.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
        bugD.Location = new Point(125, 243);
        bugD.Name = "bugD";
        bugD.Size = new Size(30, 25);
        bugD.TabIndex = 7;
        bugD.Text = "D.";
        // 
        // lbLogs
        // 
        lbLogs.FormattingEnabled = true;
        lbLogs.ItemHeight = 15;
        lbLogs.Location = new Point(18, 311);
        lbLogs.Name = "lbLogs";
        lbLogs.Size = new Size(770, 124);
        lbLogs.TabIndex = 8;
        // 
        // finishLine
        // 
        finishLine.AutoSize = true;
        finishLine.BackColor = SystemColors.MenuHighlight;
        finishLine.Location = new Point(737, 12);
        finishLine.Name = "finishLine";
        finishLine.Padding = new Padding(0, 130, 0, 130);
        finishLine.Size = new Size(43, 275);
        finishLine.TabIndex = 9;
        finishLine.Text = "도착지";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(finishLine);
        Controls.Add(lbLogs);
        Controls.Add(bugD);
        Controls.Add(bugC);
        Controls.Add(bugB);
        Controls.Add(bugA);
        Controls.Add(btnStartAll2);
        Controls.Add(btnStartAll);
        Controls.Add(btnStart2);
        Controls.Add(btnStart1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnStart1;
    private Button btnStart2;
    private Button btnStartAll;
    private Button btnStartAll2;
    private Label bugA;
    private Label bugB;
    private Label bugC;
    private Label bugD;
    private ListBox lbLogs;
    private Label finishLine;
}
