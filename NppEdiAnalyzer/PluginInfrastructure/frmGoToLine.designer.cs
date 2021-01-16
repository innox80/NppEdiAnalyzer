namespace Kbg.Demo.Namespace
{
	partial class frmGoToLine
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
            this.btnFormat = new System.Windows.Forms.Button();
            this.btnUnFormat = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(17, 11);
            this.btnFormat.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(241, 27);
            this.btnFormat.TabIndex = 8;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnUnFormat
            // 
            this.btnUnFormat.Location = new System.Drawing.Point(291, 10);
            this.btnUnFormat.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnUnFormat.Name = "btnUnFormat";
            this.btnUnFormat.Size = new System.Drawing.Size(241, 27);
            this.btnUnFormat.TabIndex = 9;
            this.btnUnFormat.Text = "Un-Format";
            this.btnUnFormat.UseVisualStyleBackColor = true;
            this.btnUnFormat.Click += new System.EventHandler(this.btnUnFormat_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 77);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(513, 514);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(17, 43);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(515, 28);
            this.button6.TabIndex = 15;
            this.button6.Text = "ListView";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmGoToLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 967);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnUnFormat);
            this.Controls.Add(this.btnFormat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGoToLine";
            this.Text = "NppDockableForm";
            this.Load += new System.EventHandler(this.frmGoToLine_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmGoToLineVisibleChanged);
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGoToLine_KeyDown);
            this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnUnFormat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button6;
    }
}