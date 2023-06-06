namespace QUANLYBANVEMAYBAY
{
    partial class TraCuuChuyenBay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bnt_thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(791, 222);
            this.dataGridView1.TabIndex = 41;
            // 
            // bnt_thoat
            // 
            this.bnt_thoat.Location = new System.Drawing.Point(696, 322);
            this.bnt_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt_thoat.Name = "bnt_thoat";
            this.bnt_thoat.Size = new System.Drawing.Size(100, 28);
            this.bnt_thoat.TabIndex = 38;
            this.bnt_thoat.Text = "Thoát";
            this.bnt_thoat.UseVisualStyleBackColor = true;
            this.bnt_thoat.Click += new System.EventHandler(this.bnt_thoat_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(359, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "TRA CỨU LỊCH BAY";
            // 
            // TraCuuChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUANLYBANVEMAYBAY.Properties.Resources.anhdepmaybaycuoichieu_041751300;
            this.ClientSize = new System.Drawing.Size(879, 375);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bnt_thoat);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TraCuuChuyenBay";
            this.Text = "TraCuuChuyenBay";
            this.Load += new System.EventHandler(this.TraCuuChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bnt_thoat;
        private System.Windows.Forms.Label label1;
    }
}