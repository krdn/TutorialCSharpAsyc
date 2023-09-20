namespace AsyncAwait;

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
        btnWalking = new Button();
        btnTalking = new Button();
        btnPhone = new Button();
        lblWalking = new Label();
        lblPhone = new Label();
        lblTalking = new Label();
        chkAsync = new CheckBox();
        btnAll = new Button();
        lbAll = new ListBox();
        chkAwait = new CheckBox();
        SuspendLayout();
        // 
        // btnWalking
        // 
        btnWalking.Location = new Point(12, 37);
        btnWalking.Name = "btnWalking";
        btnWalking.Size = new Size(75, 41);
        btnWalking.TabIndex = 0;
        btnWalking.Text = "걷기";
        btnWalking.UseVisualStyleBackColor = true;
        btnWalking.Click += btnWalking_Click;
        // 
        // btnTalking
        // 
        btnTalking.Location = new Point(12, 131);
        btnTalking.Name = "btnTalking";
        btnTalking.Size = new Size(75, 41);
        btnTalking.TabIndex = 2;
        btnTalking.Text = "말하기";
        btnTalking.UseVisualStyleBackColor = true;
        btnTalking.Click += btnTalking_Click;
        // 
        // btnPhone
        // 
        btnPhone.Location = new Point(12, 84);
        btnPhone.Name = "btnPhone";
        btnPhone.Size = new Size(75, 41);
        btnPhone.TabIndex = 3;
        btnPhone.Text = "핸드폰";
        btnPhone.UseVisualStyleBackColor = true;
        btnPhone.Click += btnPhone_Click;
        // 
        // lblWalking
        // 
        lblWalking.AutoSize = true;
        lblWalking.Location = new Point(101, 47);
        lblWalking.Name = "lblWalking";
        lblWalking.Size = new Size(39, 15);
        lblWalking.TabIndex = 4;
        lblWalking.Text = "label1";
        // 
        // lblPhone
        // 
        lblPhone.AutoSize = true;
        lblPhone.Location = new Point(101, 97);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new Size(39, 15);
        lblPhone.TabIndex = 5;
        lblPhone.Text = "label2";
        // 
        // lblTalking
        // 
        lblTalking.AutoSize = true;
        lblTalking.Location = new Point(101, 144);
        lblTalking.Name = "lblTalking";
        lblTalking.Size = new Size(39, 15);
        lblTalking.TabIndex = 6;
        lblTalking.Text = "label3";
        // 
        // chkAsync
        // 
        chkAsync.AutoSize = true;
        chkAsync.Location = new Point(12, 12);
        chkAsync.Name = "chkAsync";
        chkAsync.Size = new Size(62, 19);
        chkAsync.TabIndex = 7;
        chkAsync.Text = "비동기";
        chkAsync.UseVisualStyleBackColor = true;
        chkAsync.CheckedChanged += chkAsync_CheckedChanged;
        // 
        // btnAll
        // 
        btnAll.Location = new Point(197, 82);
        btnAll.Name = "btnAll";
        btnAll.Size = new Size(75, 45);
        btnAll.TabIndex = 8;
        btnAll.Text = "전체실행";
        btnAll.UseVisualStyleBackColor = true;
        btnAll.Click += btnAll_ClickAsync;
        // 
        // lbAll
        // 
        lbAll.FormattingEnabled = true;
        lbAll.ItemHeight = 15;
        lbAll.Location = new Point(303, 28);
        lbAll.Name = "lbAll";
        lbAll.Size = new Size(233, 304);
        lbAll.TabIndex = 9;
        // 
        // chkAwait
        // 
        chkAwait.AutoSize = true;
        chkAwait.Location = new Point(197, 57);
        chkAwait.Name = "chkAwait";
        chkAwait.Size = new Size(84, 19);
        chkAwait.TabIndex = 10;
        chkAwait.Text = "Await 사용";
        chkAwait.UseVisualStyleBackColor = true;
        chkAwait.CheckedChanged += chkAwait_CheckedChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(chkAwait);
        Controls.Add(lbAll);
        Controls.Add(btnAll);
        Controls.Add(chkAsync);
        Controls.Add(lblTalking);
        Controls.Add(lblPhone);
        Controls.Add(lblWalking);
        Controls.Add(btnPhone);
        Controls.Add(btnTalking);
        Controls.Add(btnWalking);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnWalking;
    private Button btnTalking;
    private Button btnPhone;
    private Label lblWalking;
    private Label lblPhone;
    private Label lblTalking;
    private CheckBox chkAsync;
    private Button btnAll;
    private ListBox lbAll;
    private CheckBox chkAwait;
}
