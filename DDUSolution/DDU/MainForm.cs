using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDU
{
    public partial class MainForm : Form
    {
        private FileInfo[] DroppedFiles;

        public MainForm()
        {
            InitializeComponent();
        }

        private void pnlDrop_DragDrop(object sender, DragEventArgs e)
        {
            DroppedFiles = (e.Data.GetData(DataFormats.FileDrop) as string[]).Select(o => new FileInfo(o)).ToArray();

            var menuItems = cmActions.Items.OfType<ToolStripMenuItem>().ToList();

            menuItems.ForEach(o => o.Enabled = false);

            if (DroppedFiles.Any(file => file.IsImage()))
            {
                menuTrimWhitespaces.Enabled = true;
            }

            cmActions.Show(e.X, e.Y);
        }

        private void pnlDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void menuTrimWhitespaces_Click(object sender, EventArgs e)
        {
            if (DroppedFiles?.Any() != true) 
                return;

            foreach (var droppedFile in DroppedFiles)
            {
                var img = Image.FromFile(droppedFile.FullName);
                var bmp = new Bitmap(img);
                try
                {
                    var newBitmap = bmp.TrimImage();
                    try
                    {
                        newBitmap.Save(Path.Combine(droppedFile.Directory.FullName,
                            droppedFile.Name + "-trimmed" + droppedFile.Extension));
                    }
                    finally
                    {
                        newBitmap.Dispose();
                    }
                }
                finally
                {
                    img.Dispose();
                    bmp.Dispose();
                }
            }
        }
    }
}
