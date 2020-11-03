﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NextGraphics
{
	public partial class ImageSelect : Form
	{
		
		private	bool		littleEndian		=	false;
//		private	int		thisPixel		=	0;
//		private	int		bytesPerPixel		=	3;
		private	int		transIndex		=	0;
		private	Colour		thatColour		=	new Colour();
		private	Colour		thisColour		=	new Colour();
//		private	Color		thisColor		=	new Color();	
		private	Panel[]		colours			=	new	Panel[256];
		public int		loadedColourCount	=	255;
		public	byte[,]		loadedPalette		=	new	byte[256,3];
		public	List<string> 	fullNames		=	new	List<string>();
		public	int		from			=	0;
		public	int		count			=	0;
		public	int		too			=	0;
		public	bool		paletteFiles		=	false;
		public ImageSelect()
		{
			
			littleEndian		=	BitConverter.IsLittleEndian;
			InitializeComponent();
			createPalette();
		}
		private	void	createPalette()
		{
			int	across	=	0;
			int	down	=	0;
			for(int c=0;c<256;c++)
			{
				colours[c]				=	new Panel();
				this.Controls.Add(colours[c]);
				colours[c].Text				=	"";
				colours[c].Location			=	new Point(10+(across*20),15+(down*20));
				colours[c].Size				=	new Size(22, 22);
				colours[c].Name				=	c.ToString();	
				colours[c].BorderStyle			=	BorderStyle.FixedSingle;
				loadedPalette[c,0]			=	SystemColors.Control.R;
				loadedPalette[c,1]			=	SystemColors.Control.G;
				loadedPalette[c,2]			=	SystemColors.Control.B;
				colours[c].BackColor			=	Color.FromArgb(loadedPalette[c,0],loadedPalette[c,1],loadedPalette[c,2]);
				across++;
				if(across>15)
				{
					across	=	0;
					down++;
				}
			}

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
				
			if(listBox1.SelectedIndex>=0)
			{ 
				Application.UseWaitCursor	=	true;
				Cursor.Current			=	Cursors.WaitCursor;
				if(paletteFiles==true)
				{
					
					byte[]	bytesBuffer				=	new	byte[2];
					using (FileStream fsSource = new FileStream(fullNames[listBox1.SelectedIndex], FileMode.Open, FileAccess.Read))
					{
						int numBytesToRead	=	(int)fsSource.Length;
						int numBytesRead	=	0;
						// Read and verify the data.
						if(fsSource.Length<256*3)
						{
							// dodgy file 
							MessageBox.Show("Not enough bytes in the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);	
						}
						else
						{
							for(int i = 0; i < 256; i++)
							{
								loadedPalette[i,0] = (byte) fsSource.ReadByte();
								loadedPalette[i,1] = (byte) fsSource.ReadByte();
								loadedPalette[i,2] = (byte) fsSource.ReadByte();
								numBytesRead+=3;
							}
							if(numBytesToRead>numBytesRead)
							{
								// probably got 2 bytes of num colours and 2 transparent colour
								fsSource.Read(bytesBuffer,0,2);
								numBytesRead+=2;
								//BigEndian	= $1234 = $12 $34
								//LittleEndian	= $1234 = $34 $12
		
								if (littleEndian == true)
								{
									loadedColourCount	=	bytesBuffer[1] << 8 | bytesBuffer[0];
								}
								else
								{
									loadedColourCount	=	bytesBuffer[0] << 8 | bytesBuffer[1];
								}
								if(loadedColourCount>255 || loadedColourCount < 0 )
								{
									loadedColourCount	=	0;
								}
								if(numBytesToRead>numBytesRead)
								{ 
									fsSource.Read(bytesBuffer,0,2);
									if (littleEndian == true)
									{
										transIndex	=	bytesBuffer[1] << 8 | bytesBuffer[0];
									}
									else
									{
										transIndex	=	bytesBuffer[0] << 8 | bytesBuffer[1];
									}
									if(transIndex>255 || transIndex < 0 )
									{
										transIndex	=	0;
									}
								}
							}
							for(int c=0;c<256;c++)
							{
								colours[c].BackColor			=	Color.FromArgb(loadedPalette[c,0],loadedPalette[c,1],loadedPalette[c,2]);
							}
						}
					}					
					loadedColourCount	=	255;
					importCount.Text	=	loadedColourCount.ToString();
					importFrom.Text		=	"0";
					importToo.Text		=	"0";

				}
				else
				{	
					


					Bitmap		srcBitmap	=	new	Bitmap(fullNames[listBox1.SelectedIndex]);				
					int	PaletteIndex		=	0;
					for(int	y=0;y<srcBitmap.Height;y++)
					{		
						for(int	x=0;x<srcBitmap.Width;x++)
						{
							
							Color	pixelColour	=	srcBitmap.GetPixel(x,y);							
							thatColour.R		=	pixelColour.R;
							thatColour.G		=	pixelColour.G;
							thatColour.B		=	pixelColour.B;
				
							bool	same	=	false;
							for(int c=0;c<PaletteIndex;c++)
							{ 
								if(loadedPalette[c,0]==thatColour.R && loadedPalette[c,1]==thatColour.G && loadedPalette[c,2]==thatColour.B)
								{
									same	=	true;
								}
							}
							if(same==false)
							{	
								if(PaletteIndex <256)
								{ 
								
									loadedPalette[PaletteIndex,0]	=	thatColour.R;
									loadedPalette[PaletteIndex,1]	=	thatColour.G;
									loadedPalette[PaletteIndex,2]	=	thatColour.B;	
									colours[PaletteIndex].BackColor	=	Color.FromArgb(thatColour.R,thatColour.G,thatColour.B);
									PaletteIndex++;
								}
								else
								{								
									goto	NotSupported;
								}						
							}
						}
					}
					loadedColourCount	=	PaletteIndex;
					importCount.Text	=	loadedColourCount.ToString();
					importFrom.Text		=	"0";
					importToo.Text		=	"0";
				}	
NotSupported:			
				Cursor.Current			=	Cursors.Default;
				Application.UseWaitCursor	=	false;
			}
		}
		public void fillList()
		{
			this.listBox1.Items.Clear();
			foreach (string name in fullNames)
			{
				this.listBox1.Items.Add("  " + Path.GetFileName(name));			
			}
		}

		private void importToo_TextChanged(object sender, EventArgs e)
		{			
			TextBox	thisText	=	(TextBox)sender;
			too			=	int.Parse(thisText.Text);
		}

		private void importCount_TextChanged(object sender, EventArgs e)
		{
			TextBox	thisText	=	(TextBox)sender;
			count			=	int.Parse(thisText.Text);
		}

		private void importFrom_TextChanged(object sender, EventArgs e)
		{
			TextBox	thisText	=	(TextBox)sender;
			from			=	int.Parse(thisText.Text);
		}
	}
}
