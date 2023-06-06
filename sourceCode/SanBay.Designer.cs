namespace QUANLYBANVEMAYBAY
{
    partial class SanBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanBay));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Masanbay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensanbay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masanbay,
            this.Tensanbay});
            this.dataGridView1.Location = new System.Drawing.Point(12, 303);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(614, 386);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Masanbay
            // 
            this.Masanbay.DataPropertyName = "MASANBAY";
            this.Masanbay.HeaderText = "Mã sân bay";
            this.Masanbay.MinimumWidth = 8;
            this.Masanbay.Name = "Masanbay";
            this.Masanbay.ReadOnly = true;
            this.Masanbay.Width = 140;
            // 
            // Tensanbay
            // 
            this.Tensanbay.DataPropertyName = "Tensanbay";
            this.Tensanbay.HeaderText = "Tên sân bay";
            this.Tensanbay.MinimumWidth = 8;
            this.Tensanbay.Name = "Tensanbay";
            this.Tensanbay.ReadOnly = true;
            this.Tensanbay.Width = 220;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(192, 231);
            this.txt_2.Margin = new System.Windows.Forms.Padding(6);
            this.txt_2.Multiline = true;
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(247, 44);
            this.txt_2.TabIndex = 13;
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(192, 163);
            this.txt_1.Margin = new System.Windows.Forms.Padding(6);
            this.txt_1.Multiline = true;
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(247, 44);
            this.txt_1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 46);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên Sân Bay";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 42);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Sân Bay";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(202, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "THÊM SÂN BAY";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(468, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 48);
            this.button1.TabIndex = 17;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Salmon;
            this.button2.Location = new System.Drawing.Point(468, 188);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 49);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cập Nhật";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.Green;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.Salmon;
            this.bt_them.Location = new System.Drawing.Point(468, 138);
            this.bt_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(112, 40);
            this.bt_them.TabIndex = 15;
            this.bt_them.Text = "Thêm ";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // SanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 686);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_them);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SanBay";
            this.Text = "Sân Bay";
            this.Load += new System.EventHandler(this.frm_ThemSanBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masanbay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensanbay;
    }
}