namespace FastOrder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveRowButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ArtTextBox = new System.Windows.Forms.TextBox();
            this.ShTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SavePriceButton = new System.Windows.Forms.Button();
            this.AddPriceButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Штрихкод";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Артикул";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Наименование";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HelpButton);
            this.panel1.Controls.Add(this.ReloadButton);
            this.panel1.Controls.Add(this.RemoveRowButton);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.CountTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.ArtTextBox);
            this.panel1.Controls.Add(this.ShTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 57);
            this.panel1.TabIndex = 3;
            // 
            // RemoveRowButton
            // 
            this.RemoveRowButton.Location = new System.Drawing.Point(768, 6);
            this.RemoveRowButton.Name = "RemoveRowButton";
            this.RemoveRowButton.Size = new System.Drawing.Size(119, 23);
            this.RemoveRowButton.TabIndex = 9;
            this.RemoveRowButton.Text = "Удалить строку";
            this.RemoveRowButton.UseVisualStyleBackColor = true;
            this.RemoveRowButton.Click += new System.EventHandler(this.RemoveRowButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bosch",
            "Craftmate",
            "Gross",
            "Hardax",
            "Hauser",
            "Hobby",
            "Irwin",
            "Makita",
            "Matrix",
            "Mungo",
            "Norma",
            "RWS Electric",
            "Sparta",
            "TDM",
            "Tytan",
            "Барс",
            "Интерскол",
            "Сибртех",
            "Энкор"});
            this.comboBox1.Location = new System.Drawing.Point(12, 22);
            this.comboBox1.MaxLength = 30;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Фирма";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(768, 31);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(119, 23);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Очистить таблицу";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(578, 23);
            this.CountTextBox.MaxLength = 30;
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(76, 20);
            this.CountTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Кол-во, ед.";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(338, 23);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(234, 20);
            this.NameTextBox.TabIndex = 5;
            // 
            // ArtTextBox
            // 
            this.ArtTextBox.Location = new System.Drawing.Point(227, 23);
            this.ArtTextBox.MaxLength = 30;
            this.ArtTextBox.Name = "ArtTextBox";
            this.ArtTextBox.Size = new System.Drawing.Size(105, 20);
            this.ArtTextBox.TabIndex = 4;
            // 
            // ShTextBox
            // 
            this.ShTextBox.Location = new System.Drawing.Point(127, 23);
            this.ShTextBox.MaxLength = 30;
            this.ShTextBox.Name = "ShTextBox";
            this.ShTextBox.Size = new System.Drawing.Size(94, 20);
            this.ShTextBox.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 346);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 346);
            this.dataGridView1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 403);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 158);
            this.panel3.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(200, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(744, 145);
            this.panel5.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(744, 145);
            this.textBox1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SavePriceButton);
            this.panel4.Controls.Add(this.AddPriceButton);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.PriceTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 158);
            this.panel4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Новый ценник";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(6, 22);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(187, 20);
            this.PriceTextBox.TabIndex = 11;
            this.PriceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PriceTextBox_KeyDown);
            // 
            // HelpButton
            // 
            this.HelpButton.BackgroundImage = global::FastOrder.Properties.Resources.w256h2561383075043HelpSupporticon;
            this.HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HelpButton.FlatAppearance.BorderSize = 0;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Location = new System.Drawing.Point(893, 6);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(48, 48);
            this.HelpButton.TabIndex = 13;
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackgroundImage = global::FastOrder.Properties.Resources.refresh_arrows_14418;
            this.ReloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReloadButton.FlatAppearance.BorderSize = 0;
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadButton.Location = new System.Drawing.Point(714, 7);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(48, 48);
            this.ReloadButton.TabIndex = 12;
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackgroundImage = global::FastOrder.Properties.Resources.add_1_icon;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(660, 7);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(48, 48);
            this.AddButton.TabIndex = 7;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SavePriceButton
            // 
            this.SavePriceButton.BackgroundImage = global::FastOrder.Properties.Resources.Toolbar___Save;
            this.SavePriceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SavePriceButton.FlatAppearance.BorderSize = 0;
            this.SavePriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePriceButton.Location = new System.Drawing.Point(6, 102);
            this.SavePriceButton.Name = "SavePriceButton";
            this.SavePriceButton.Size = new System.Drawing.Size(48, 48);
            this.SavePriceButton.TabIndex = 13;
            this.SavePriceButton.UseVisualStyleBackColor = true;
            this.SavePriceButton.Click += new System.EventHandler(this.SavePriceButton_Click);
            // 
            // AddPriceButton
            // 
            this.AddPriceButton.BackgroundImage = global::FastOrder.Properties.Resources.add_1_icon;
            this.AddPriceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddPriceButton.FlatAppearance.BorderSize = 0;
            this.AddPriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPriceButton.Location = new System.Drawing.Point(6, 48);
            this.AddPriceButton.Name = "AddPriceButton";
            this.AddPriceButton.Size = new System.Drawing.Size(48, 48);
            this.AddPriceButton.TabIndex = 12;
            this.AddPriceButton.UseVisualStyleBackColor = true;
            this.AddPriceButton.Click += new System.EventHandler(this.AddPriceButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(200, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ценники";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Быстрый заказ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox ArtTextBox;
        private System.Windows.Forms.TextBox ShTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RemoveRowButton;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AddPriceButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SavePriceButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Label label6;
    }
}

