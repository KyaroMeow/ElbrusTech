namespace ElbrusTech
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.GenereticEmployees = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(152)))), ((int)(((byte)(164)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
			this.dataGridView1.GridColor = System.Drawing.Color.Gray;
			this.dataGridView1.Location = new System.Drawing.Point(286, 47);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(646, 390);
			this.dataGridView1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(58, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(236, 31);
			this.label1.TabIndex = 5;
			this.label1.Text = "Отдел кадров HR";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
			this.panel1.Controls.Add(this.guna2CirclePictureBox1);
			this.panel1.Controls.Add(this.guna2ControlBox3);
			this.panel1.Controls.Add(this.guna2ControlBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(944, 47);
			this.panel1.TabIndex = 6;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1MouseMove);
			// 
			// guna2CirclePictureBox1
			// 
			this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
			this.guna2CirclePictureBox1.Image = global::ElbrusTech.Properties.Resources.people_app_logo_icon_digital_a;
			this.guna2CirclePictureBox1.ImageRotate = 0F;
			this.guna2CirclePictureBox1.Location = new System.Drawing.Point(14, 6);
			this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
			this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CirclePictureBox1.Size = new System.Drawing.Size(38, 38);
			this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2CirclePictureBox1.TabIndex = 9;
			this.guna2CirclePictureBox1.TabStop = false;
			// 
			// guna2ControlBox3
			// 
			this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox3.BorderRadius = 11;
			this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
			this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.guna2ControlBox3.Location = new System.Drawing.Point(878, 12);
			this.guna2ControlBox3.Name = "guna2ControlBox3";
			this.guna2ControlBox3.Size = new System.Drawing.Size(24, 24);
			this.guna2ControlBox3.TabIndex = 8;
			// 
			// guna2ControlBox1
			// 
			this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox1.BorderRadius = 11;
			this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
			this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new System.Drawing.Point(908, 12);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new System.Drawing.Size(24, 24);
			this.guna2ControlBox1.TabIndex = 7;
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 438);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(944, 29);
			this.panel2.TabIndex = 7;
			// 
			// guna2Button3
			// 
			this.guna2Button3.Animated = true;
			this.guna2Button3.AutoRoundedCorners = true;
			this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button3.BorderRadius = 19;
			this.guna2Button3.BorderThickness = 1;
			this.guna2Button3.DefaultAutoSize = true;
			this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
			this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
			this.guna2Button3.ForeColor = System.Drawing.Color.White;
			this.guna2Button3.Location = new System.Drawing.Point(12, 345);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new System.Drawing.Size(224, 40);
			this.guna2Button3.TabIndex = 13;
			this.guna2Button3.Text = "Очистить таблицу";
			this.guna2Button3.UseTransparentBackground = true;
			this.guna2Button3.Click += new System.EventHandler(this.DeleteAll_click);
			// 
			// guna2Button2
			// 
			this.guna2Button2.Animated = true;
			this.guna2Button2.AutoRoundedCorners = true;
			this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button2.BorderRadius = 19;
			this.guna2Button2.BorderThickness = 1;
			this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
			this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
			this.guna2Button2.ForeColor = System.Drawing.Color.White;
			this.guna2Button2.Location = new System.Drawing.Point(65, 136);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(144, 40);
			this.guna2Button2.TabIndex = 12;
			this.guna2Button2.Text = "Удалить";
			this.guna2Button2.UseTransparentBackground = true;
			this.guna2Button2.Click += new System.EventHandler(this.Delete_click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.guna2Button3);
			this.panel3.Controls.Add(this.GenereticEmployees);
			this.panel3.Controls.Add(this.guna2Button2);
			this.panel3.Controls.Add(this.guna2Button1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 47);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(245, 391);
			this.panel3.TabIndex = 8;
			// 
			// GenereticEmployees
			// 
			this.GenereticEmployees.Animated = true;
			this.GenereticEmployees.AutoRoundedCorners = true;
			this.GenereticEmployees.BackColor = System.Drawing.Color.Transparent;
			this.GenereticEmployees.BorderRadius = 18;
			this.GenereticEmployees.BorderThickness = 1;
			this.GenereticEmployees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.GenereticEmployees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.GenereticEmployees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.GenereticEmployees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.GenereticEmployees.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
			this.GenereticEmployees.Font = new System.Drawing.Font("Segoe UI", 15.75F);
			this.GenereticEmployees.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.GenereticEmployees.Location = new System.Drawing.Point(78, 27);
			this.GenereticEmployees.Name = "GenereticEmployees";
			this.GenereticEmployees.Size = new System.Drawing.Size(39, 38);
			this.GenereticEmployees.TabIndex = 10;
			this.GenereticEmployees.UseTransparentBackground = true;
			this.GenereticEmployees.Click += new System.EventHandler(this.GenereticEmployees_click);
			// 
			// guna2Button1
			// 
			this.guna2Button1.Animated = true;
			this.guna2Button1.AutoRoundedCorners = true;
			this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
			this.guna2Button1.BorderRadius = 19;
			this.guna2Button1.BorderThickness = 1;
			this.guna2Button1.DefaultAutoSize = true;
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Location = new System.Drawing.Point(64, 90);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(145, 40);
			this.guna2Button1.TabIndex = 11;
			this.guna2Button1.Text = "Сохранить";
			this.guna2Button1.UseTransparentBackground = true;
			this.guna2Button1.Click += new System.EventHandler(this.Save_click);
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(191)))), ((int)(((byte)(193)))));
			this.ClientSize = new System.Drawing.Size(944, 467);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ElbrusTech";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.BindingSource methodsBindingSource;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
		private Guna.UI2.WinForms.Guna2Button GenereticEmployees;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private Guna.UI2.WinForms.Guna2Button guna2Button3;
		private Guna.UI2.WinForms.Guna2Button guna2Button2;
	}
}

