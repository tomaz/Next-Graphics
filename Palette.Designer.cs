﻿namespace NextGraphics
{
	partial class Palette
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
            this.label1 = new System.Windows.Forms.Label();
            this.outCancel = new System.Windows.Forms.Button();
            this.outOk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numColours = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tColourIndex1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.hexColour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.copyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMixerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowUp = new System.Windows.Forms.Button();
            this.rowDown = new System.Windows.Forms.Button();
            this.startIndex = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.copyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transparent Colour";
            // 
            // outCancel
            // 
            this.outCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.outCancel.Location = new System.Drawing.Point(325, 357);
            this.outCancel.Name = "outCancel";
            this.outCancel.Size = new System.Drawing.Size(75, 23);
            this.outCancel.TabIndex = 6;
            this.outCancel.Text = "Cancel";
            this.outCancel.UseVisualStyleBackColor = true;
            // 
            // outOk
            // 
            this.outOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.outOk.Location = new System.Drawing.Point(415, 357);
            this.outOk.Name = "outOk";
            this.outOk.Size = new System.Drawing.Size(75, 23);
            this.outOk.TabIndex = 5;
            this.outOk.Text = "OK";
            this.outOk.UseVisualStyleBackColor = true;
            this.outOk.Click += new System.EventHandler(this.outOk_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(12, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.loadPalette);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 105);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colour Mapping";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Location = new System.Drawing.Point(29, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Custom Palette";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 84);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.mappedFromImageCheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(30, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "512 Next Palette";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radioButton2.Location = new System.Drawing.Point(10, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.mappedTo512PaletteCheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(29, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "256 Next Palette";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton1.Location = new System.Drawing.Point(10, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.mappedTo256PaletteCheckedChanged);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Location = new System.Drawing.Point(45, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.paletteFromFileButtonClick);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Location = new System.Drawing.Point(77, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Pick";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.TransPickClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label7.Location = new System.Drawing.Point(167, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Please note: Only every other colour is shown for the 512 Palette";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Location = new System.Drawing.Point(77, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.savePaletteClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Palette Shift";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Colours to use";
            // 
            // numColours
            // 
            this.numColours.Location = new System.Drawing.Point(93, 354);
            this.numColours.Name = "numColours";
            this.numColours.Size = new System.Drawing.Size(41, 20);
            this.numColours.TabIndex = 13;
            this.numColours.Text = "255";
            this.numColours.TextChanged += new System.EventHandler(this.setButtonColours);
            this.numColours.KeyUp += new System.Windows.Forms.KeyEventHandler(this.setButtonColours);
            // 
            // tColourIndex1
            // 
            this.tColourIndex1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tColourIndex1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tColourIndex1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.tColourIndex1.Location = new System.Drawing.Point(20, 304);
            this.tColourIndex1.Name = "tColourIndex1";
            this.tColourIndex1.Size = new System.Drawing.Size(41, 20);
            this.tColourIndex1.TabIndex = 15;
            this.tColourIndex1.Text = "0";
            this.tColourIndex1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hex Colour";
            // 
            // hexColour
            // 
            this.hexColour.Location = new System.Drawing.Point(234, 358);
            this.hexColour.Name = "hexColour";
            this.hexColour.Size = new System.Drawing.Size(62, 20);
            this.hexColour.TabIndex = 17;
            this.hexColour.TextChanged += new System.EventHandler(this.hexColour_TextChanged);
            this.hexColour.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hexColour_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Location = new System.Drawing.Point(10, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Select colours from image";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Location = new System.Drawing.Point(10, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Palette files";
            // 
            // copyMenu
            // 
            this.copyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.openMixerToolStripMenuItem,
            this.hexValueToolStripMenuItem});
            this.copyMenu.Name = "copyMenu";
            this.copyMenu.Size = new System.Drawing.Size(137, 136);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cutToolStripMenuItem.Text = "Clear";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.clearColour);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyColour);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteColour);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // openMixerToolStripMenuItem
            // 
            this.openMixerToolStripMenuItem.Name = "openMixerToolStripMenuItem";
            this.openMixerToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.openMixerToolStripMenuItem.Text = "Open Mixer";
            this.openMixerToolStripMenuItem.Click += new System.EventHandler(this.openMixer);
            // 
            // hexValueToolStripMenuItem
            // 
            this.hexValueToolStripMenuItem.Name = "hexValueToolStripMenuItem";
            this.hexValueToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.hexValueToolStripMenuItem.Text = "Hex Value";
            this.hexValueToolStripMenuItem.Click += new System.EventHandler(this.hexValueToolStripMenuItem_Click);
            // 
            // rowUp
            // 
            this.rowUp.Location = new System.Drawing.Point(14, 251);
            this.rowUp.Name = "rowUp";
            this.rowUp.Size = new System.Drawing.Size(57, 23);
            this.rowUp.TabIndex = 21;
            this.rowUp.Text = "Up";
            this.rowUp.UseVisualStyleBackColor = true;
            this.rowUp.Click += new System.EventHandler(this.moveRowUp);
            // 
            // rowDown
            // 
            this.rowDown.Location = new System.Drawing.Point(77, 251);
            this.rowDown.Name = "rowDown";
            this.rowDown.Size = new System.Drawing.Size(57, 23);
            this.rowDown.TabIndex = 22;
            this.rowDown.Text = "Down";
            this.rowDown.UseVisualStyleBackColor = true;
            this.rowDown.Click += new System.EventHandler(this.moveRowDown);
            // 
            // startIndex
            // 
            this.startIndex.Location = new System.Drawing.Point(20, 354);
            this.startIndex.Name = "startIndex";
            this.startIndex.Size = new System.Drawing.Size(41, 20);
            this.startIndex.TabIndex = 23;
            this.startIndex.Text = "255";
            this.startIndex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.setStart);
            // 
            // Palette
            // 
            this.AcceptButton = this.outOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.outCancel;
            this.ClientSize = new System.Drawing.Size(508, 393);
            this.Controls.Add(this.startIndex);
            this.Controls.Add(this.rowDown);
            this.Controls.Add(this.rowUp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.hexColour);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tColourIndex1);
            this.Controls.Add(this.numColours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.outCancel);
            this.Controls.Add(this.outOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Palette";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Palette";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.checkNumColoursClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.copyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button outCancel;
		private System.Windows.Forms.Button outOk;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox numColours;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Label tColourIndex1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox hexColour;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ContextMenuStrip copyMenu;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openMixerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexValueToolStripMenuItem;
        private System.Windows.Forms.Button rowUp;
        private System.Windows.Forms.Button rowDown;
        private System.Windows.Forms.TextBox startIndex;
    }
}