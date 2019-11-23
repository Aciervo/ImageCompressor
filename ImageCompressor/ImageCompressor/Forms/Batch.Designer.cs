namespace ImageCompressor.Forms
{
    partial class Batch
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
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBoxUnaltered = new System.Windows.Forms.PictureBox();
            this.pictureBoxCompressed = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnaltered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompressed)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewFiles
            // 
            this.listViewFiles.CheckBoxes = true;
            this.listViewFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.GridLines = true;
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(12, 12);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(478, 394);
            this.listViewFiles.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBoxUnaltered
            // 
            this.pictureBoxUnaltered.Location = new System.Drawing.Point(496, 12);
            this.pictureBoxUnaltered.Name = "pictureBoxUnaltered";
            this.pictureBoxUnaltered.Size = new System.Drawing.Size(292, 194);
            this.pictureBoxUnaltered.TabIndex = 4;
            this.pictureBoxUnaltered.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxUnaltered, "Unaltered");
            // 
            // pictureBoxCompressed
            // 
            this.pictureBoxCompressed.Location = new System.Drawing.Point(496, 212);
            this.pictureBoxCompressed.Name = "pictureBoxCompressed";
            this.pictureBoxCompressed.Size = new System.Drawing.Size(292, 194);
            this.pictureBoxCompressed.TabIndex = 5;
            this.pictureBoxCompressed.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxCompressed, "Altered");
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optimizeToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filenameToolStripMenuItem,
            this.filePathToolStripMenuItem,
            this.sizeToolStripMenuItem,
            this.typeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewToolStripMenuItem.Text = "View...";
            // 
            // filenameToolStripMenuItem
            // 
            this.filenameToolStripMenuItem.Name = "filenameToolStripMenuItem";
            this.filenameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filenameToolStripMenuItem.Text = "Filename";
            // 
            // filePathToolStripMenuItem
            // 
            this.filePathToolStripMenuItem.Name = "filePathToolStripMenuItem";
            this.filePathToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filePathToolStripMenuItem.Text = "File path";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.typeToolStripMenuItem.Text = "Type";
            // 
            // optimizeToolStripMenuItem
            // 
            this.optimizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.selectedToolStripMenuItem});
            this.optimizeToolStripMenuItem.Name = "optimizeToolStripMenuItem";
            this.optimizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optimizeToolStripMenuItem.Text = "Optimize...";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allToolStripMenuItem.Text = "All";
            // 
            // selectedToolStripMenuItem
            // 
            this.selectedToolStripMenuItem.Name = "selectedToolStripMenuItem";
            this.selectedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectedToolStripMenuItem.Text = "Selected";
            // 
            // Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxCompressed);
            this.Controls.Add(this.pictureBoxUnaltered);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listViewFiles);
            this.Name = "Batch";
            this.Text = "Batch";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnaltered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompressed)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxUnaltered;
        private System.Windows.Forms.PictureBox pictureBoxCompressed;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filenameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedToolStripMenuItem;
    }
}