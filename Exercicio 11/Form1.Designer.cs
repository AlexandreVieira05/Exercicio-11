namespace Exercicio_11
{
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
            menuStrip1 = new MenuStrip();
            formatargToolStripMenuItem = new ToolStripMenuItem();
            corETipoDeLetraToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { formatargToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // formatargToolStripMenuItem
            // 
            formatargToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { corETipoDeLetraToolStripMenuItem });
            formatargToolStripMenuItem.Name = "formatargToolStripMenuItem";
            formatargToolStripMenuItem.Size = new Size(83, 24);
            formatargToolStripMenuItem.Text = "Formatar";
            formatargToolStripMenuItem.Click += formatargToolStripMenuItem_Click;
            // 
            // corETipoDeLetraToolStripMenuItem
            // 
            corETipoDeLetraToolStripMenuItem.Name = "corETipoDeLetraToolStripMenuItem";
            corETipoDeLetraToolStripMenuItem.Size = new Size(224, 26);
            corETipoDeLetraToolStripMenuItem.Text = "Cor e tipo de letra";
            corETipoDeLetraToolStripMenuItem.Click += corETipoDeLetraToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(78, 170);
            label1.Name = "label1";
            label1.Size = new Size(168, 37);
            label1.TabIndex = 1;
            label1.Text = "POO em C#";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem formatargToolStripMenuItem;
        private ToolStripMenuItem corETipoDeLetraToolStripMenuItem;
        private Label label1;
    }
}