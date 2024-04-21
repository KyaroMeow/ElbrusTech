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
<<<<<<< Updated upstream
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Gray;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(58, 20);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(197, 39);
			this.button1.TabIndex = 0;
			this.button1.Text = "Генерация сотрудников";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(261, 19);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(197, 40);
			this.button2.TabIndex = 1;
			this.button2.Text = "Сохранить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(464, 19);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(197, 39);
			this.button3.TabIndex = 2;
			this.button3.Text = "Удалить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(152)))), ((int)(((byte)(164)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
			this.dataGridView1.GridColor = System.Drawing.Color.Gray;
			this.dataGridView1.Location = new System.Drawing.Point(52, 47);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(834, 325);
			this.dataGridView1.TabIndex = 3;
			// 
			// button4
			// 
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.Location = new System.Drawing.Point(675, 20);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(197, 40);
			this.button4.TabIndex = 4;
			this.button4.Text = "Удалить все";
			this.button4.UseVisualStyleBackColor = true;
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
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
			this.panel1.Controls.Add(this.guna2CirclePictureBox1);
			this.panel1.Controls.Add(this.guna2ControlBox3);
			this.panel1.Controls.Add(this.guna2ControlBox2);
			this.panel1.Controls.Add(this.guna2ControlBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(944, 47);
			this.panel1.TabIndex = 6;
			// 
			// guna2ControlBox1
			// 
			this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox1.BorderRadius = 11;
			this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
			this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new System.Drawing.Point(908, 12);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new System.Drawing.Size(24, 24);
			this.guna2ControlBox1.TabIndex = 7;
			// 
			// guna2ControlBox2
			// 
			this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox2.BorderRadius = 11;
			this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
			this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Default;
			this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
			this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.guna2ControlBox2.Location = new System.Drawing.Point(878, 12);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.Size = new System.Drawing.Size(24, 24);
			this.guna2ControlBox2.TabIndex = 8;
			// 
			// guna2ControlBox3
			// 
			this.guna2ControlBox3.BorderRadius = 11;
			this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
			this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.guna2ControlBox3.Location = new System.Drawing.Point(848, 12);
			this.guna2ControlBox3.Name = "guna2ControlBox3";
			this.guna2ControlBox3.Size = new System.Drawing.Size(24, 24);
			this.guna2ControlBox3.TabIndex = 8;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 372);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(944, 95);
			this.panel2.TabIndex = 7;
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 47);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(52, 325);
			this.panel3.TabIndex = 8;
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(892, 47);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(52, 325);
			this.panel4.TabIndex = 9;
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
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(152)))), ((int)(((byte)(164)))));
			this.ClientSize = new System.Drawing.Size(944, 467);
			this.Controls.Add(this.panel4);
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
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
			this.ResumeLayout(false);
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "генерация сотрудников";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(723, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 210);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 377);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ElbrusTech";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
>>>>>>> Stashed changes

        }

        #endregion

        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.BindingSource methodsBindingSource;
		private System.Windows.Forms.DataGridView dataGridView1;
<<<<<<< Updated upstream
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
	}
=======
    }
>>>>>>> Stashed changes
}

