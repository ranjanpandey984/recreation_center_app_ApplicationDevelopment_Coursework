namespace recreationapp
{
    partial class AdminForm
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.csvFileName = new System.Windows.Forms.TextBox();
            this.ImportCSVBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.IndianRed;
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.logoutBtn.Location = new System.Drawing.Point(17, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(87, 37);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // csvFileName
            // 
            this.csvFileName.Location = new System.Drawing.Point(17, 59);
            this.csvFileName.Multiline = true;
            this.csvFileName.Name = "csvFileName";
            this.csvFileName.Size = new System.Drawing.Size(629, 33);
            this.csvFileName.TabIndex = 1;
            // 
            // ImportCSVBtn
            // 
            this.ImportCSVBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ImportCSVBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ImportCSVBtn.Location = new System.Drawing.Point(652, 50);
            this.ImportCSVBtn.Name = "ImportCSVBtn";
            this.ImportCSVBtn.Size = new System.Drawing.Size(137, 58);
            this.ImportCSVBtn.TabIndex = 2;
            this.ImportCSVBtn.Text = "Import CSV";
            this.ImportCSVBtn.UseVisualStyleBackColor = false;
            this.ImportCSVBtn.Click += new System.EventHandler(this.ImportCSVBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 324);
            this.dataGridView1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ImportCSVBtn);
            this.Controls.Add(this.csvFileName);
            this.Controls.Add(this.logoutBtn);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.TextBox csvFileName;
        private System.Windows.Forms.Button ImportCSVBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}