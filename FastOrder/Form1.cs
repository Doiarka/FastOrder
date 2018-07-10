using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FastOrder
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        DataSet dataSet = new DataSet();
        static string mydocpath = @"Z:\\Order\\" + DateTime.Today.Month + "-" + DateTime.Today.Day;

        public Form1()
        {
            InitializeComponent();
        }

        public void TbClear()
        {
            ShTextBox.Clear();
            ArtTextBox.Clear();
            NameTextBox.Clear();
            CountTextBox.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ShTextBox.Text + ArtTextBox.Text + NameTextBox.Text))
            {
                return;
            }

            string art = null;
            if (!String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                art = " - " + comboBox1.Text;
            }

            LoadXML();

            DataRow dr = dt.NewRow();
            dr[0] = ShTextBox.Text;
            dr[1] = ArtTextBox.Text + art;
            dr[2] = NameTextBox.Text;
            dr[3] = CountTextBox.Text;
            dr[4] = DateTime.Now.Hour + ":" + DateTime.Now.Second;
            dt.Rows.Add(dr);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;

            TbClear();
            art = null;
            
            comboBox1.Focus();
            Save();
            LoadXML();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                DialogResult result = MessageBox.Show("Удалить данные?", "Очистка таблицы", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dt.Clear();
                    TbClear();
                }
            }
            Save();
            LoadXML();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;

            DataColumn workCol = new DataColumn();
            workCol.AllowDBNull = false;
            workCol.Unique = true;

            dt.Columns.Add(label1.Text, typeof(string));
            dt.Columns.Add(label2.Text, typeof(string));
            dt.Columns.Add(label3.Text, typeof(string));
            dt.Columns.Add(label4.Text, typeof(string));
            dt.Columns.Add("Время", typeof(string));

            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            dataSet.Tables.Add(dt);
            try
            {
                if (!Directory.Exists("Z:\\Order\\" + DateTime.Today.Month + "-" + DateTime.Today.Day))
                {
                    Directory.CreateDirectory("Z:\\Order\\" + DateTime.Today.Month + "-" + DateTime.Today.Day);
                }
                if (!File.Exists("Z:\\Order\\" + DateTime.Today.Month + "-" + DateTime.Today.Day + "\\orders.xml"))
                {
                    Save();
                }
                else
                {
                    FileInfo fi = new FileInfo("Z:\\Order\\" + DateTime.Today.Month + "-" + DateTime.Today.Day + "\\orders.xml");
                    if (fi.CreationTime.Date == DateTime.Today.Date)
                    {
                        LoadXML();
                    }
                }
                LoadTXT();
                AllToolTips();
            }
            catch (Exception)
            {
                MessageBox.Show("Необходимо наличие локального диска Z. Программа сохраняет данные по пути Z:\\Order\\");
                this.Close();
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)       // Ctrl-Enter Add
            {
                AddButton.PerformClick();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }
            
            if (e.KeyCode == Keys.F1)       // F1 фокус окна фирмы
            {
                comboBox1.Focus();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }

            if (e.KeyCode == Keys.F2)       // F2 фокус окна штрихкода
            {
                ShTextBox.Focus();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }

            if (e.KeyCode == Keys.F3)       // F3 фокус окна артикула
            {
                ArtTextBox.Focus();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }

            if (e.KeyCode == Keys.F4)       // F4 фокус окна наименования
            {
                NameTextBox.Focus();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }

            if (e.KeyCode == Keys.F5)       // F5 фокус окна количества
            {
                LoadXML();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }

            if (e.Control && e.KeyCode == Keys.S)       // Ctrl-S Save Prices
            {
                SavePriceButton.PerformClick();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }
        }
        
        public void Save()
        {
            try
            {
                dataSet.WriteXml("Z:\\Order\\" + DateTime.Today.Month + "-" + DateTime.Today.Day + "\\orders.xml");
            }
            catch (Exception)
            {
                MessageBox.Show("Файл базы данных занят администратором базы данных. Для продолжения работы с программой дождитесь закрытия базы данных администратором.");
                return;
            }
        }
        
        public void LoadXML()
        {
            dt.Clear();
            try
            {
                dataSet.ReadXml("Z:\\Order\\" + DateTime.Today.Month + "-" + DateTime.Today.Day + "\\orders.xml");
            }
            catch (Exception)
            {
                MessageBox.Show("Файл базы данных занят администратором базы данных. Для продолжения работы с программой дождитесь закрытия базы данных администратором.");
                return;
            }
        }

        public void LoadTXT()
        {
            try
            {
                if (!File.Exists(mydocpath + "\\prices.txt"))
                {
                    StreamWriter sw = File.CreateText(mydocpath + "\\prices.txt");
                }
                else
                {
                    textBox1.Text = File.ReadAllText(mydocpath + "\\prices.txt");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Файл ценников занят администратором. Для продолжения работы с программой дождитесь закрытия файла администратором.");
                return;
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            LoadXML();
            LoadTXT();
        }

        private void RemoveRowButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
            }
            Save();
            LoadXML();
        }

        private void AddPriceButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(PriceTextBox.Text))
            {
                textBox1.Text += PriceTextBox.Text + "\r\n";
                WriteTextAsync(textBox1.Text);
                PriceTextBox.Clear();
            }
        }

        static async void WriteTextAsync(string text)
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, "prices.txt")))
                {
                    await outputFile.WriteAsync(text);
                }
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void PriceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)       // Enter Add
            {
                AddPriceButton.PerformClick();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }
        }

        private void SavePriceButton_Click(object sender, EventArgs e)
        {
            WriteTextAsync(textBox1.Text);
        }

        private void AllToolTips()
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(AddButton, "Добавить в базу дынных");
            t.SetToolTip(ReloadButton, "Обновить данные");
            t.SetToolTip(RemoveRowButton, "Удалить строку из базы данных");
            t.SetToolTip(ClearButton, "Очистить базу данных");
            t.SetToolTip(HelpButton, "Помощь");
            t.SetToolTip(AddPriceButton, "Добавить ценник");
            t.SetToolTip(SavePriceButton, "Сохранить ценники");
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Быстрые кнопки:\r\n" +
                "Tab - Перейти в следующее поле\r\n" +
                "F1 - Перейти в поле Фирма\r\n" +
                "F2 -Перейти в поле Штрихкод\r\n" +
                "F3 -Перейти в поле Артикул\r\n" +
                "F4 -Перейти в поле Наименование\r\n" +
                "F5 - Обновить данные\r\n" +
                "Ctrl + Enter - Добавить запись в базу данных\r\n" +
                "Enter - Добавить ценник (находясь в поле Новый ценник)\r\n" +
                "Секд + S - Сохранить ценники");
        }
    }
}
