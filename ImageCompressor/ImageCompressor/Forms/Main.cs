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
        private readonly OpenFileDialog openDiag = null;
        private readonly SaveFileDialog saveDiag = null;
        private readonly TextBox logTextBox = null;

        public Main()
        {
            InitializeComponent();

            // Set form styles and update
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            // Set Title text
            Text = "Image Optimizer";
            Icon = Properties.Resources.icon2;

            // Set default values
            textBox1.Text = "100%";
            qualityTrackBar.Value = 100;

            // Notes:  https://stackoverflow.com/questions/16004682/c-sharp-drag-and-drop-from-one-picture-box-into-another
            pictureBox1.AllowDrop = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;

            radioButton1.Checked = false;
            radioButton2.Checked = true;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = true;

            comboBox1.Items.Add("JPG");
            comboBox1.Items.Add("PNG");
            comboBox1.Items.Add("GIF");
            comboBox1.SelectedIndex = 0;

            openDiag = new OpenFileDialog();
            saveDiag = new SaveFileDialog();

            // Setup file filters for the dialog...
            openDiag.Filter = "BMP Files (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE";
            openDiag.Filter += "|GIF Files (*.GIF)|*.GIF";
            openDiag.Filter += "|JPEG Files (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF";
            openDiag.Filter += "|PNG Files (*.PNG)|*.PNG";
            openDiag.Filter += "|TIFF Files (*.TIF;*.TIFF)|*.TIF;*.TIFF";
            openDiag.Filter += "|All Files (*.*)|*.*";

            saveDiag.Filter = "BMP Files (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE";
            saveDiag.Filter += "|GIF Files (*.GIF)|*.GIF";
            saveDiag.Filter += "|JPEG Files (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF";
            saveDiag.Filter += "|PNG Files (*.PNG)|*.PNG";
            saveDiag.Filter += "|TIFF Files (*.TIF;*.TIFF)|*.TIF;*.TIFF";
            saveDiag.Filter += "|All Files (*.*)|*.*";

            logTextBox = new TextBox();
            logTextBox.Visible = false;
            logTextBox.Multiline = true;
            logTextBox.ScrollBars = ScrollBars.Vertical;
            logTextBox.Size = new Size(790, 140);
            logTextBox.Location = new Point(5, panel1.Height + 35);

            // Log application setup...
            logTextBox.AppendText("Application setup complete.");
            logTextBox.AppendText(Environment.NewLine);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openDiag.ShowDialog() == DialogResult.OK)
            {
                // Load file here...
                try
                {
                    pictureBox1.Image = Image.FromFile(openDiag.FileName);
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    imageBrowseButton.Visible = false;

                    logTextBox.AppendText("Loaded: " + openDiag.FileName);
                    logTextBox.AppendText(Environment.NewLine);
                }
                catch
                {
                    logTextBox.AppendText("Failed to load: " + openDiag.FileName);
                    logTextBox.AppendText(Environment.NewLine);
                }
            }
        }

        private void ImageBrowseButton_Click(object sender, EventArgs e)
        {
            if (openDiag.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load file here...
                    pictureBox1.Image = Image.FromFile(openDiag.FileName);
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    imageBrowseButton.Visible = false;

                    logTextBox.AppendText("Loaded: " + openDiag.FileName);
                    logTextBox.AppendText(Environment.NewLine);
                }
                catch
                {
                    logTextBox.AppendText("Failed to load: " + openDiag.FileName);
                    logTextBox.AppendText(Environment.NewLine);
                }
            }
        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void PictureBox1_DragLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            // Load file here...
            pictureBox1.BorderStyle = BorderStyle.None;
            string[] filelist = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            
            try
            {
                pictureBox1.Image = Image.FromFile(filelist[0]);

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                imageBrowseButton.Visible = false;

                logTextBox.AppendText("Loaded: " + filelist[0]);
                logTextBox.AppendText(Environment.NewLine);
            }
            catch
            {
                logTextBox.AppendText("Failed to load: " + filelist[0]);
                logTextBox.AppendText(Environment.NewLine);
            }
        }

        private void QualityTrackBar_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = qualityTrackBar.Value + "%";
        }

        private void SaveLocationButton_Click(object sender, EventArgs e)
        {
            if (saveDiag.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = saveDiag.FileName;
            }
        }

        private void EasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advancedToolStripMenuItem.Checked = false;
            easyToolStripMenuItem.Checked = true;
        }

        private void AdvancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advancedToolStripMenuItem.Checked = true;
            easyToolStripMenuItem.Checked = false;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutBox = new About();
            aboutBox.ShowDialog();

            aboutBox.Dispose();
        }

        private void LogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logToolStripMenuItem.Checked)
            {
                Size = new Size(Size.Width, Size.Height + 150);
                logTextBox.Visible = true;
                Controls.Add(logTextBox);
            }
            else
            {
                Size = new Size(Size.Width, Size.Height - 150);
                logTextBox.Visible = false;
                Controls.Remove(logTextBox);
            }
        }

        private void PreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Batch batch = new Batch();

            batch.ShowDialog();
        }
    }
}
