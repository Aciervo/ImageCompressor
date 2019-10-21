using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NJpegOptim;
using PNGCompression;

namespace ImageCompressor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            this.Text = "Image Optimizer";

            this.textBox1.Text = "100%";
            this.trackBar1.Value = 100;

            //this.panel1.BackgroundImageLayout = ImageLayout.Zoom;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;

            this.radioButton1.Checked = false;
            this.radioButton2.Checked = true;
            this.radioButton3.Checked = false;
            this.radioButton4.Checked = false;
            this.radioButton5.Checked = true;

            this.comboBox1.Items.Add("JPG");
            this.comboBox1.Items.Add("PNG");
            this.comboBox1.Items.Add("GIF");
            this.comboBox1.SelectedIndex = 0;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();

            // Setup file filters for the dialog...
            //diag.Filter = "BMP Files (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE";
            diag.Filter = "JPEG Files (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF";
            //diag.Filter += "|GIF Files (*.GIF)|*.GIF";
            //diag.Filter += "|TIFF Files (*.TIF;*.TIFF)|*.TIF;*.TIFF";
            diag.Filter += "|PNG Files (*.PNG)|*.PNG";
            diag.Filter += "|All Files (*.*)|*.*";
            
            if (diag.ShowDialog() == DialogResult.OK)
            {
                // Load file here...
                //this.panel1.BackgroundImage = Image.FromFile(diag.FileName);
                this.pictureBox1.Image = Image.FromFile(diag.FileName);
                this.pictureBox1.BringToFront();
                this.label1.Visible = false;
                this.label2.Visible = false;
                this.label3.Visible = false;
                this.button1.Visible = false;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            // Load file here...
            //panel1.BorderStyle = BorderStyle.None;
            pictureBox1.BorderStyle = BorderStyle.None;
            string[] filelist = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            //panel1.BackgroundImage = Image.FromFile(filelist[0]);
            pictureBox1.Image = Image.FromFile(filelist[0]);
            pictureBox1.BringToFront();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value + "%";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog();

            if (diag.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = diag.FileName;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                button2.Enabled = true;
            else
                button2.Enabled = false;
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

            //panel1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel1_DragLeave(object sender, EventArgs e)
        {
            //panel1.BorderStyle = BorderStyle.None;
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advancedToolStripMenuItem.Checked = false;
            easyToolStripMenuItem.Checked = true;
        }

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advancedToolStripMenuItem.Checked = true;
            easyToolStripMenuItem.Checked = false;
        }
    }
}
