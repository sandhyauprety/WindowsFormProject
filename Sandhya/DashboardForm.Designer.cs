using System.ComponentModel;

namespace Sandhya;

partial class DashboardForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        Lwelcome = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // Lwelcome
        // 
        Lwelcome.Location = new System.Drawing.Point(160, 107);
        Lwelcome.Name = "Lwelcome";
        Lwelcome.Size = new System.Drawing.Size(127, 27);
        Lwelcome.TabIndex = 0;
        Lwelcome.Text = "label1";
        // 
        // DashboardForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(Lwelcome);
        Text = "DashboardForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label Lwelcome;

    #endregion
}