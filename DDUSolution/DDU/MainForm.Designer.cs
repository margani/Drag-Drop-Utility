namespace DDU
{
    partial class MainForm
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
            this.pnlDrop = new System.Windows.Forms.Panel();
            this.cmActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuTrimWhitespaces = new System.Windows.Forms.ToolStripMenuItem();
            this.cmActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrop
            // 
            this.pnlDrop.AllowDrop = true;
            this.pnlDrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDrop.Location = new System.Drawing.Point(0, 0);
            this.pnlDrop.Name = "pnlDrop";
            this.pnlDrop.Size = new System.Drawing.Size(331, 284);
            this.pnlDrop.TabIndex = 0;
            this.pnlDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDrop_DragDrop);
            this.pnlDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDrop_DragEnter);
            // 
            // cmActions
            // 
            this.cmActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrimWhitespaces});
            this.cmActions.Name = "cmActions";
            this.cmActions.Size = new System.Drawing.Size(166, 26);
            // 
            // menuTrimWhitespaces
            // 
            this.menuTrimWhitespaces.Name = "menuTrimWhitespaces";
            this.menuTrimWhitespaces.Size = new System.Drawing.Size(165, 22);
            this.menuTrimWhitespaces.Text = "Trim whitespaces";
            this.menuTrimWhitespaces.Click += new System.EventHandler(this.menuTrimWhitespaces_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 284);
            this.Controls.Add(this.pnlDrop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DDU";
            this.cmActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrop;
        private System.Windows.Forms.ContextMenuStrip cmActions;
        private System.Windows.Forms.ToolStripMenuItem menuTrimWhitespaces;
    }
}

