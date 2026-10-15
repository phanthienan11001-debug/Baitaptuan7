namespace QLSV.UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // dataGridView1
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(138, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(500, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // button1
            button1.Location = new Point(339, 83);
            button1.Name = "button1";
            button1.Size = new Size(140, 34);
            button1.TabIndex = 1;
            button1.Text = "Tải danh sách";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            // lblTrangThai
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(138, 30);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(100, 25);
            lblTrangThai.TabIndex = 2;
            lblTrangThai.Text = "Sẵn sàng";

            // Form1
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTrangThai);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Quản lý sinh viên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label lblTrangThai;
    }
}