namespace Check_Management
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnlog = new Glass.GlassButton();
            this.btnsign = new Glass.GlassButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.فارسیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlog
            // 
            this.btnlog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlog.ForeColor = System.Drawing.Color.Bisque;
            this.btnlog.InnerBorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnlog.Location = new System.Drawing.Point(161, 104);
            this.btnlog.Name = "btnlog";
            this.btnlog.OuterBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnlog.ShineColor = System.Drawing.Color.Aquamarine;
            this.btnlog.Size = new System.Drawing.Size(173, 100);
            this.btnlog.TabIndex = 0;
            this.btnlog.Text = "Login";
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // btnsign
            // 
            this.btnsign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsign.ForeColor = System.Drawing.Color.Bisque;
            this.btnsign.InnerBorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnsign.Location = new System.Drawing.Point(161, 240);
            this.btnsign.Name = "btnsign";
            this.btnsign.OuterBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsign.ShineColor = System.Drawing.Color.Aquamarine;
            this.btnsign.Size = new System.Drawing.Size(173, 100);
            this.btnsign.TabIndex = 1;
            this.btnsign.Text = "Sign Up";
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فارسیToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 56);
            // 
            // فارسیToolStripMenuItem
            // 
            this.فارسیToolStripMenuItem.Name = "فارسیToolStripMenuItem";
            this.فارسیToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.فارسیToolStripMenuItem.Text = "فارسی";
            this.فارسیToolStripMenuItem.Click += new System.EventHandler(this.فارسیToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(522, 488);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnsign);
            this.Controls.Add(this.btnlog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Check Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Glass.GlassButton btnlog;
        private Glass.GlassButton btnsign;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem فارسیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    }
}

