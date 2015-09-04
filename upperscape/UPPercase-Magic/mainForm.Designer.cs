namespace upperscape
{
    partial class mainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btn_convert = new System.Windows.Forms.Button();
            this.ViewHistory = new System.Windows.Forms.ListView();
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gBoxHistory = new System.Windows.Forms.GroupBox();
            this.chkBoxHistory = new System.Windows.Forms.CheckBox();
            this.lblCopy = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.gBoxHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_convert
            // 
            this.btn_convert.BackColor = System.Drawing.Color.Transparent;
            this.btn_convert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_convert.Image = global::upperscape.Properties.Resources.uppercase_logo;
            this.btn_convert.Location = new System.Drawing.Point(0, 0);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(272, 78);
            this.btn_convert.TabIndex = 0;
            this.btn_convert.UseVisualStyleBackColor = false;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // ViewHistory
            // 
            this.ViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTime,
            this.colText});
            this.ViewHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewHistory.FullRowSelect = true;
            this.ViewHistory.Location = new System.Drawing.Point(3, 16);
            this.ViewHistory.Name = "ViewHistory";
            this.ViewHistory.Size = new System.Drawing.Size(629, 286);
            this.ViewHistory.TabIndex = 1;
            this.ViewHistory.UseCompatibleStateImageBehavior = false;
            this.ViewHistory.View = System.Windows.Forms.View.Details;
            this.ViewHistory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ViewHistory_MouseDoubleClick);
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            this.colTime.Width = 49;
            // 
            // colText
            // 
            this.colText.Text = "Text";
            this.colText.Width = 551;
            // 
            // gBoxHistory
            // 
            this.gBoxHistory.Controls.Add(this.ViewHistory);
            this.gBoxHistory.Location = new System.Drawing.Point(0, 115);
            this.gBoxHistory.Name = "gBoxHistory";
            this.gBoxHistory.Size = new System.Drawing.Size(635, 305);
            this.gBoxHistory.TabIndex = 2;
            this.gBoxHistory.TabStop = false;
            this.gBoxHistory.Text = "History";
            // 
            // chkBoxHistory
            // 
            this.chkBoxHistory.AutoSize = true;
            this.chkBoxHistory.Location = new System.Drawing.Point(3, 83);
            this.chkBoxHistory.Name = "chkBoxHistory";
            this.chkBoxHistory.Size = new System.Drawing.Size(88, 17);
            this.chkBoxHistory.TabIndex = 3;
            this.chkBoxHistory.Text = "Show History";
            this.chkBoxHistory.UseVisualStyleBackColor = true;
            this.chkBoxHistory.CheckStateChanged += new System.EventHandler(this.chkBoxHistory_CheckStateChanged);
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopy.Location = new System.Drawing.Point(0, 420);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(124, 14);
            this.lblCopy.TabIndex = 4;
            this.lblCopy.Text = "© Johann Weisenburger";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(128, 420);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Version";
            // 
            // mainForm
            // 
            this.AcceptButton = this.btn_convert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(272, 105);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.chkBoxHistory);
            this.Controls.Add(this.gBoxHistory);
            this.Controls.Add(this.btn_convert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "uppercase";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.gBoxHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.ListView ViewHistory;
        private System.Windows.Forms.GroupBox gBoxHistory;
        private System.Windows.Forms.CheckBox chkBoxHistory;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colText;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.Label lblVersion;
    }
}

