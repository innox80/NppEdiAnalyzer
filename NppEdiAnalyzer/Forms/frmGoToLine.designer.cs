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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblSegmentName = new System.Windows.Forms.Label();
            this.chkShowEmpty = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            // lblSegmentName
            // 
            this.lblSegmentName.AutoSize = true;
            this.lblSegmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegmentName.Location = new System.Drawing.Point(26, 14);
            this.lblSegmentName.Name = "lblSegmentName";
            this.lblSegmentName.Size = new System.Drawing.Size(91, 25);
            this.lblSegmentName.TabIndex = 15;
            this.lblSegmentName.Text = "Segment";
            // 
            // chkShowEmpty
            // 
            this.chkShowEmpty.AutoSize = true;
            this.chkShowEmpty.Checked = true;
            this.chkShowEmpty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowEmpty.Location = new System.Drawing.Point(19, 46);
            this.chkShowEmpty.Name = "chkShowEmpty";
            this.chkShowEmpty.Size = new System.Drawing.Size(353, 29);
            this.chkShowEmpty.TabIndex = 16;
            this.chkShowEmpty.Text = "Show empty elements / components";
            this.chkShowEmpty.UseVisualStyleBackColor = true;
            // 
            // frmGoToLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 967);
            this.Controls.Add(this.chkShowEmpty);
            this.Controls.Add(this.lblSegmentName);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGoToLine";
            this.Text = "NppDockableForm";
            this.Load += new System.EventHandler(this.frmGoToLine_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmGoToLineVisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblSegmentName;
        private System.Windows.Forms.CheckBox chkShowEmpty;
    }
}