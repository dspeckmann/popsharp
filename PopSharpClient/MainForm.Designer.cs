namespace DSpeckmann.PopSharpClient
{
    partial class MainForm
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
            this.renderedEmailView = new System.Windows.Forms.WebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mailboxListBox = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rawEmailView = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.emailListBox = new DSpeckmann.PopSharpClient.EmailListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // renderedEmailView
            // 
            this.renderedEmailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderedEmailView.Location = new System.Drawing.Point(4, 5);
            this.renderedEmailView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.renderedEmailView.MinimumSize = new System.Drawing.Size(30, 31);
            this.renderedEmailView.Name = "renderedEmailView";
            this.renderedEmailView.Size = new System.Drawing.Size(612, 621);
            this.renderedEmailView.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mailboxListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1258, 664);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // mailboxListBox
            // 
            this.mailboxListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailboxListBox.FormattingEnabled = true;
            this.mailboxListBox.ItemHeight = 20;
            this.mailboxListBox.Location = new System.Drawing.Point(0, 0);
            this.mailboxListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mailboxListBox.Name = "mailboxListBox";
            this.mailboxListBox.Size = new System.Drawing.Size(200, 664);
            this.mailboxListBox.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.emailListBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(1052, 664);
            this.splitContainer2.SplitterDistance = 418;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(628, 664);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rawEmailView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(620, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Raw";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rawEmailView
            // 
            this.rawEmailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rawEmailView.Location = new System.Drawing.Point(4, 5);
            this.rawEmailView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rawEmailView.Multiline = true;
            this.rawEmailView.Name = "rawEmailView";
            this.rawEmailView.Size = new System.Drawing.Size(612, 621);
            this.rawEmailView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.renderedEmailView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(620, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rendered";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // emailListBox
            // 
            this.emailListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.emailListBox.FormattingEnabled = true;
            this.emailListBox.ItemHeight = 30;
            this.emailListBox.Location = new System.Drawing.Point(0, 0);
            this.emailListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailListBox.Name = "emailListBox";
            this.emailListBox.Size = new System.Drawing.Size(418, 664);
            this.emailListBox.TabIndex = 0;
            this.emailListBox.SelectedValueChanged += new System.EventHandler(this.emailListBox_SelectedValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "PopSharp Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser renderedEmailView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox rawEmailView;
        private System.Windows.Forms.ListBox mailboxListBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private EmailListBox emailListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

