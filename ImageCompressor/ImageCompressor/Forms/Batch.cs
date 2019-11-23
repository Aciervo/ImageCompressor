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
    public partial class Batch : Form
    {
        public Batch()
        {
            InitializeComponent();


            // Setup everything before the user does anything...
            InitializeColumnHeaders();
        }

        private void InitializeColumnHeaders()
        {
            // Filepath
            ColumnHeader ch = new ColumnHeader();
            ch.Text = "File path";
            ch.Width = 100;
            listViewFiles.Columns.Add(ch);

            // File name
            ch = new ColumnHeader();
            ch.Text = "File name";
            ch.Width = 100;
            listViewFiles.Columns.Add(ch);

            // File size
            ch = new ColumnHeader();
            ch.Text = "Size";
            ch.Width = 100;
            listViewFiles.Columns.Add(ch);

            // Status
            ch = new ColumnHeader();
            ch.Text = "Status";
            ch.Width = 100;
            listViewFiles.Columns.Add(ch);

            // Extension
            ch = new ColumnHeader();
            ch.Text = "Type";
            ch.Width = 100;
            listViewFiles.Columns.Add(ch);

            // Refresh column widths
            listViewFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
