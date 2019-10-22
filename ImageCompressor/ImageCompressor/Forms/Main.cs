using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCompressor.Forms
{
    public partial class Main : Form
    {
        private OpenFileDialog openDiag = null;
        private SaveFileDialog saveDiag = null;
        private TextBox logTextBox = null;

        public Main()
        {
            InitializeComponent();

            // Set form styles and update
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            // Set Title text
            this.Text = "Image Optimizer";
            this.Icon = Properties.Resources.icon2;

            // Set default values
            this.textBox1.Text = "100%";
            this.qualityTrackBar.Value = 100;

            // Notes:  https://stackoverflow.com/questions/16004682/c-sharp-drag-and-drop-from-one-picture-box-into-another
            this.pictureBox1.AllowDrop = true;
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

            this.openDiag = new OpenFileDialog();
            this.saveDiag = new SaveFileDialog();

            // Setup file filters for the dialog...
            this.openDiag.Filter = "BMP Files (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE";
            this.openDiag.Filter += "|GIF Files (*.GIF)|*.GIF";
            this.openDiag.Filter += "|JPEG Files (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF";
            this.openDiag.Filter += "|PNG Files (*.PNG)|*.PNG";
            this.openDiag.Filter += "|TIFF Files (*.TIF;*.TIFF)|*.TIF;*.TIFF";
            this.openDiag.Filter += "|All Files (*.*)|*.*";

            this.saveDiag.Filter = "BMP Files (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE";
            this.saveDiag.Filter += "|GIF Files (*.GIF)|*.GIF";
            this.saveDiag.Filter += "|JPEG Files (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF";
            this.saveDiag.Filter += "|PNG Files (*.PNG)|*.PNG";
            this.saveDiag.Filter += "|TIFF Files (*.TIF;*.TIFF)|*.TIF;*.TIFF";
            this.saveDiag.Filter += "|All Files (*.*)|*.*";

            this.logTextBox = new TextBox();
            this.logTextBox.Visible = false;
            this.logTextBox.Multiline = true;
            this.logTextBox.ScrollBars = ScrollBars.Vertical;
            this.logTextBox.Size = new Size(790, 140);
            this.logTextBox.Location = new Point(5, this.panel1.Height + 35);

            // Log application setup...
            this.logTextBox.AppendText("Application setup complete.");
            this.logTextBox.AppendText(Environment.NewLine);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openDiag.ShowDialog() == DialogResult.OK)
            {
                // Load file here...
                try
                {
                    this.pictureBox1.Image = Image.FromFile(this.openDiag.FileName);
                    this.label1.Visible = false;
                    this.label2.Visible = false;
                    this.label3.Visible = false;
                    this.imageBrowseButton.Visible = false;

                    this.logTextBox.AppendText("Loaded: " + this.openDiag.FileName);
                    this.logTextBox.AppendText(Environment.NewLine);
                }
                catch
                {
                    this.logTextBox.AppendText("Failed to load: " + this.openDiag.FileName);
                    this.logTextBox.AppendText(Environment.NewLine);
                }
            }
        }

        private void ImageBrowseButton_Click(object sender, EventArgs e)
        {
            if (this.openDiag.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load file here...
                    this.pictureBox1.Image = Image.FromFile(this.openDiag.FileName);
                    this.label1.Visible = false;
                    this.label2.Visible = false;
                    this.label3.Visible = false;
                    this.imageBrowseButton.Visible = false;

                    this.logTextBox.AppendText("Loaded: " + this.openDiag.FileName);
                    this.logTextBox.AppendText(Environment.NewLine);
                }
                catch
                {
                    this.logTextBox.AppendText("Failed to load: " + this.openDiag.FileName);
                    this.logTextBox.AppendText(Environment.NewLine);
                }
            }
        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

            this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void PictureBox1_DragLeave(object sender, EventArgs e)
        {
            this.pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            // Load file here...
            pictureBox1.BorderStyle = BorderStyle.None;
            string[] filelist = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            
            try
            {
                this.pictureBox1.Image = Image.FromFile(filelist[0]);

                this.label1.Visible = false;
                this.label2.Visible = false;
                this.label3.Visible = false;
                this.imageBrowseButton.Visible = false;

                this.logTextBox.AppendText("Loaded: " + filelist[0]);
                this.logTextBox.AppendText(Environment.NewLine);
            }
            catch
            {
                this.logTextBox.AppendText("Failed to load: " + filelist[0]);
                this.logTextBox.AppendText(Environment.NewLine);
            }
        }

        private void qualityTrackBar_Scroll(object sender, EventArgs e)
        {
            this.textBox1.Text = this.qualityTrackBar.Value + "%";
        }

        private void saveLocationButton_Click(object sender, EventArgs e)
        {
            if (this.saveDiag.ShowDialog() == DialogResult.OK)
            {
                this.textBox2.Text = this.saveDiag.FileName;
            }
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.advancedToolStripMenuItem.Checked = false;
            this.easyToolStripMenuItem.Checked = true;
        }

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.advancedToolStripMenuItem.Checked = true;
            this.easyToolStripMenuItem.Checked = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutBox = new About();
            aboutBox.ShowDialog();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.logToolStripMenuItem.Checked)
            {
                this.Size = new Size(this.Size.Width, this.Size.Height + 150);
                this.logTextBox.Visible = true;
                this.Controls.Add(logTextBox);
            }
            else
            {
                this.Size = new Size(this.Size.Width, this.Size.Height - 150);
                this.logTextBox.Visible = false;
                this.Controls.Remove(logTextBox);
            }
        }
    }
}
