namespace Praktika
{
    partial class Destytojas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Destytojas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exitbtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.TDalykascb = new System.Windows.Forms.ComboBox();
            this.TPavardetbl = new System.Windows.Forms.TextBox();
            this.TVardastbl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DestytojaiDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.EditBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exitbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestytojaiDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.Exitbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 120);
            this.panel1.TabIndex = 5;
            // 
            // Exitbtn
            // 
            this.Exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("Exitbtn.Image")));
            this.Exitbtn.Location = new System.Drawing.Point(879, 12);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(73, 64);
            this.Exitbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exitbtn.TabIndex = 1;
            this.Exitbtn.TabStop = false;
            this.Exitbtn.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(404, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dėstytojai";
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.Gold;
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn.Location = new System.Drawing.Point(734, 234);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(99, 39);
            this.Backbtn.TabIndex = 21;
            this.Backbtn.Text = "Atgal";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Tomato;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Location = new System.Drawing.Point(534, 234);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(97, 39);
            this.Deletebtn.TabIndex = 20;
            this.Deletebtn.Text = "Ištrinti";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.LightGreen;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Location = new System.Drawing.Point(126, 234);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(101, 39);
            this.Addbtn.TabIndex = 18;
            this.Addbtn.Text = "Pridėti";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // TDalykascb
            // 
            this.TDalykascb.FormattingEnabled = true;
            this.TDalykascb.Items.AddRange(new object[] {
            "",
            "Matematika",
            "informatika"});
            this.TDalykascb.Location = new System.Drawing.Point(504, 180);
            this.TDalykascb.Name = "TDalykascb";
            this.TDalykascb.Size = new System.Drawing.Size(145, 23);
            this.TDalykascb.TabIndex = 17;
            // 
            // TPavardetbl
            // 
            this.TPavardetbl.Location = new System.Drawing.Point(288, 180);
            this.TPavardetbl.Name = "TPavardetbl";
            this.TPavardetbl.Size = new System.Drawing.Size(153, 23);
            this.TPavardetbl.TabIndex = 16;
            // 
            // TVardastbl
            // 
            this.TVardastbl.Location = new System.Drawing.Point(74, 180);
            this.TVardastbl.Name = "TVardastbl";
            this.TVardastbl.Size = new System.Drawing.Size(153, 23);
            this.TVardastbl.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(504, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dalykas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(288, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pavardė";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(74, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vardas";
            // 
            // DestytojaiDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DestytojaiDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DestytojaiDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DestytojaiDGV.ColumnHeadersHeight = 25;
            this.DestytojaiDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DestytojaiDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DestytojaiDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DestytojaiDGV.Location = new System.Drawing.Point(74, 298);
            this.DestytojaiDGV.Name = "DestytojaiDGV";
            this.DestytojaiDGV.RowHeadersVisible = false;
            this.DestytojaiDGV.RowTemplate.Height = 25;
            this.DestytojaiDGV.Size = new System.Drawing.Size(813, 282);
            this.DestytojaiDGV.TabIndex = 22;
            this.DestytojaiDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DestytojaiDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DestytojaiDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DestytojaiDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DestytojaiDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DestytojaiDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DestytojaiDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DestytojaiDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSalmon;
            this.DestytojaiDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DestytojaiDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DestytojaiDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DestytojaiDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DestytojaiDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.DestytojaiDGV.ThemeStyle.ReadOnly = false;
            this.DestytojaiDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DestytojaiDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DestytojaiDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DestytojaiDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DestytojaiDGV.ThemeStyle.RowsStyle.Height = 25;
            this.DestytojaiDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DestytojaiDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DestytojaiDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DestytojaiDGV_CellContentClick);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Location = new System.Drawing.Point(310, 237);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(115, 36);
            this.EditBtn.TabIndex = 23;
            this.EditBtn.Text = "Redaguoti";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // Destytojas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 671);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DestytojaiDGV);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.TVardastbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TDalykascb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TPavardetbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Destytojas";
            this.Text = "Dėstytojas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exitbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestytojaiDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox Exitbtn;
        private Label label1;
        private Button Backbtn;
        private Button Deletebtn;
        private Button Addbtn;
        private ComboBox TDalykascb;
        private TextBox TPavardetbl;
        private TextBox TVardastbl;
        private Label label4;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView DestytojaiDGV;
        private Button EditBtn;
    }
}