﻿namespace NextGraphics
{
	partial class imageWindow
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.scaleBar = new System.Windows.Forms.HScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.srcPicture = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.srcPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.srcPicture);
			this.panel1.Location = new System.Drawing.Point(6, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1047, 678);
			this.panel1.TabIndex = 1;
			this.panel1.Resize += new System.EventHandler(this.resize);
			// 
			// scaleBar
			// 
			this.scaleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.scaleBar.Location = new System.Drawing.Point(61, 9);
			this.scaleBar.Minimum = 10;
			this.scaleBar.Name = "scaleBar";
			this.scaleBar.Size = new System.Drawing.Size(992, 17);
			this.scaleBar.TabIndex = 2;
			this.scaleBar.Value = 25;
			this.scaleBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Scale";
			// 
			// srcPicture
			// 
			this.srcPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.srcPicture.Location = new System.Drawing.Point(-1, 3);
			this.srcPicture.Name = "srcPicture";
			this.srcPicture.Size = new System.Drawing.Size(1043, 670);
			this.srcPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.srcPicture.TabIndex = 0;
			this.srcPicture.TabStop = false;
			this.srcPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.srcWindowPaint);
			// 
			// imageWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1062, 729);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.scaleBar);
			this.Name = "imageWindow";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "SrcImage";
			this.Resize += new System.EventHandler(this.resize);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.srcPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.HScrollBar scaleBar;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.PictureBox srcPicture;
	}
}