namespace CancellationToken;

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
        btnStart = new Button();
        btnCacel = new Button();
        lblIndex = new Label();
        chkThrowIfCancellationRequested = new CheckBox();
        SuspendLayout();
        // 
        // btnStart
        // 
        btnStart.Location = new Point(65, 62);
        btnStart.Name = "btnStart";
        btnStart.Size = new Size(96, 23);
        btnStart.TabIndex = 0;
        btnStart.Text = "비동기 시작";
        btnStart.UseVisualStyleBackColor = true;
        btnStart.Click += btnStart_Click;
        // 
        // btnCacel
        // 
        btnCacel.Location = new Point(167, 62);
        btnCacel.Name = "btnCacel";
        btnCacel.Size = new Size(96, 23);
        btnCacel.TabIndex = 1;
        btnCacel.Text = "비동기 취소";
        btnCacel.UseVisualStyleBackColor = true;
        btnCacel.Click += btnCancel_Click;
        // 
        // lblIndex
        // 
        lblIndex.AutoSize = true;
        lblIndex.Location = new Point(284, 66);
        lblIndex.Name = "lblIndex";
        lblIndex.Size = new Size(39, 15);
        lblIndex.TabIndex = 2;
        lblIndex.Text = "label1";
        // 
        // chkThrowIfCancellationRequested
        // 
        chkThrowIfCancellationRequested.AutoSize = true;
        chkThrowIfCancellationRequested.Location = new Point(64, 34);
        chkThrowIfCancellationRequested.Name = "chkThrowIfCancellationRequested";
        chkThrowIfCancellationRequested.Size = new Size(187, 19);
        chkThrowIfCancellationRequested.TabIndex = 3;
        chkThrowIfCancellationRequested.Text = "ThrowIfCancellationRequested";
        chkThrowIfCancellationRequested.UseVisualStyleBackColor = true;
        chkThrowIfCancellationRequested.CheckedChanged += chkThrowIfCancellationRequested_CheckedChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(702, 367);
        Controls.Add(chkThrowIfCancellationRequested);
        Controls.Add(lblIndex);
        Controls.Add(btnCacel);
        Controls.Add(btnStart);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnStart;
    private Button btnCacel;
    private Label lblIndex;
    private CheckBox chkThrowIfCancellationRequested;
}
