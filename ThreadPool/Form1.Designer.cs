namespace ThreadPool;

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
        btnCopyMain = new Button();
        btnCopyBack = new Button();
        progressMain = new ProgressBar();
        lblMain = new Label();
        SuspendLayout();
        // 
        // btnCopyMain
        // 
        btnCopyMain.Location = new Point(27, 27);
        btnCopyMain.Name = "btnCopyMain";
        btnCopyMain.Size = new Size(138, 67);
        btnCopyMain.TabIndex = 0;
        btnCopyMain.Text = "파일 복사\r\n비동기\r\n(동일 스페드)";
        btnCopyMain.UseVisualStyleBackColor = true;
        btnCopyMain.Click += btnCopyMain_Click;
        // 
        // btnCopyBack
        // 
        btnCopyBack.Location = new Point(171, 27);
        btnCopyBack.Name = "btnCopyBack";
        btnCopyBack.Size = new Size(138, 67);
        btnCopyBack.TabIndex = 1;
        btnCopyBack.Text = "파일 복사\r\n비도익\r\n(백그라운드 스레드)";
        btnCopyBack.UseVisualStyleBackColor = true;
        btnCopyBack.Click += btnCopyBack_Click;
        // 
        // progressMain
        // 
        progressMain.Location = new Point(27, 111);
        progressMain.Name = "progressMain";
        progressMain.Size = new Size(282, 23);
        progressMain.TabIndex = 2;
        // 
        // lblMain
        // 
        lblMain.AutoSize = true;
        lblMain.Location = new Point(32, 147);
        lblMain.Name = "lblMain";
        lblMain.Size = new Size(39, 15);
        lblMain.TabIndex = 4;
        lblMain.Text = "label1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lblMain);
        Controls.Add(progressMain);
        Controls.Add(btnCopyBack);
        Controls.Add(btnCopyMain);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnCopyMain;
    private Button btnCopyBack;
    private ProgressBar progressMain;
    private ProgressBar progressCopyBack;
    private Label lblMain;
    private Label lblCopyBack;
}
