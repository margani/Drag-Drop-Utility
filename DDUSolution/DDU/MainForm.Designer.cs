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
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuTrimWhitespaces = new System.Windows.Forms.ToolStripMenuItem();
            this.cmActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrop
            // 
            this.pnlDrop.AllowDrop = true;
            this.pnlDrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDrop.Location = new System.Drawing.Point(0, 121);
            this.pnlDrop.Name = "pnlDrop";
            this.pnlDrop.Size = new System.Drawing.Size(331, 163);
            this.pnlDrop.TabIndex = 0;
            this.pnlDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDrop_DragDrop);
            this.pnlDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDrop_DragEnter);
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(331, 121);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmActions
            // 
            this.cmActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrimWhitespaces});
            this.cmActions.Name = "cmActions";
            this.cmActions.Size = new System.Drawing.Size(181, 48);
            // 
            // menuTrimWhitespaces
            // 
            this.menuTrimWhitespaces.Name = "menuTrimWhitespaces";
            this.menuTrimWhitespaces.Size = new System.Drawing.Size(180, 22);
            this.menuTrimWhitespaces.Text = "Trim whitespaces";
            this.menuTrimWhitespaces.Click += new System.EventHandler(this.menuTrimWhitespaces_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 284);
            this.Controls.Add(this.pnlDrop);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DDU";
            this.cmActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrop;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip cmActions;
        private System.Windows.Forms.ToolStripMenuItem menuTrimWhitespaces;
    }
}

