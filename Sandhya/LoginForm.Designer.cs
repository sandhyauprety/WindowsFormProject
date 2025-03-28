namespace Sandhya;

partial class LoginForm
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        LLogin = new System.Windows.Forms.Label();
        LUsername = new System.Windows.Forms.Label();
        LPassword = new System.Windows.Forms.Label();
        txtusername = new System.Windows.Forms.TextBox();
        txtpassword = new System.Windows.Forms.TextBox();
        btnsubmit = new System.Windows.Forms.Button();
        checkbox1 = new System.Windows.Forms.CheckBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // LLogin
        // 
        LLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        LLogin.Location = new System.Drawing.Point(298, 35);
        LLogin.Name = "LLogin";
        LLogin.Size = new System.Drawing.Size(72, 32);
        LLogin.TabIndex = 0;
        LLogin.Text = "LogIn\r\n\r\n";
        // 
        // LUsername
        // 
        LUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        LUsername.Location = new System.Drawing.Point(156, 125);
        LUsername.Name = "LUsername";
        LUsername.Size = new System.Drawing.Size(100, 23);
        LUsername.TabIndex = 1;
        LUsername.Text = "Username";
        // 
        // LPassword
        // 
        LPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        LPassword.Location = new System.Drawing.Point(156, 163);
        LPassword.Name = "LPassword";
        LPassword.Size = new System.Drawing.Size(100, 23);
        LPassword.TabIndex = 2;
        LPassword.Text = "Password";
        // 
        // txtusername
        // 
        txtusername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        txtusername.Location = new System.Drawing.Point(245, 125);
        txtusername.Name = "txtusername";
        txtusername.Size = new System.Drawing.Size(171, 27);
        txtusername.TabIndex = 3;
        // 
        // txtpassword
        // 
        txtpassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        txtpassword.Location = new System.Drawing.Point(245, 160);
        txtpassword.Name = "txtpassword";
        txtpassword.PasswordChar = '*';
        txtpassword.Size = new System.Drawing.Size(171, 27);
        txtpassword.TabIndex = 4;
        // 
        // btnsubmit
        // 
        btnsubmit.BackColor = System.Drawing.SystemColors.Highlight;
        btnsubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        btnsubmit.Location = new System.Drawing.Point(156, 223);
        btnsubmit.Name = "btnsubmit";
        btnsubmit.Size = new System.Drawing.Size(260, 24);
        btnsubmit.TabIndex = 5;
        btnsubmit.Text = "Submit";
        btnsubmit.UseVisualStyleBackColor = false;
        btnsubmit.Click += btnsubmit_Click;
        // 
        // checkbox1
        // 
        checkbox1.ForeColor = System.Drawing.SystemColors.Highlight;
        checkbox1.Location = new System.Drawing.Point(156, 193);
        checkbox1.Name = "checkbox1";
        checkbox1.Size = new System.Drawing.Size(142, 24);
        checkbox1.TabIndex = 6;
        checkbox1.Text = "Keep me logged-in";
        checkbox1.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.SystemColors.Control;
        label1.ForeColor = System.Drawing.SystemColors.HotTrack;
        label1.Location = new System.Drawing.Point(245, 266);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 7;
        label1.Text = "Create Account";
        // 
        // label2
        // 
        label2.ForeColor = System.Drawing.SystemColors.HotTrack;
        label2.Location = new System.Drawing.Point(316, 194);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 8;
        label2.Text = "Forgot Password?";
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(checkbox1);
        Controls.Add(btnsubmit);
        Controls.Add(txtpassword);
        Controls.Add(txtusername);
        Controls.Add(LPassword);
        Controls.Add(LUsername);
        Controls.Add(LLogin);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.CheckBox checkbox1;

    private System.Windows.Forms.Button btnsubmit;

    private System.Windows.Forms.TextBox txtusername;
    private System.Windows.Forms.TextBox txtpassword;

    private System.Windows.Forms.Label LPassword;

    private System.Windows.Forms.Label LUsername;

    private System.Windows.Forms.Label LLogin;

    #endregion
}