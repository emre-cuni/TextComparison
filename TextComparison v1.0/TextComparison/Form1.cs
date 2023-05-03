using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextComparison
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox2.DrawMode = DrawMode.OwnerDrawFixed;
            listBox2.DrawItem += new DrawItemEventHandler(listBox_RenkAyarla);
        }

        OpenFileDialog fileDialog = new OpenFileDialog();
        string line = null;
        int firstFileLength = 0, secondFileLength = 0;

        private void buttonSelectFirstFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFile(1);
                buttonSelectSecondFile.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stackTrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "1. Dosya Seçimi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSelectSecondFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFile(2);
                buttonSelectFirstFile.Enabled = false;
                buttonSelectSecondFile.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stackTrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "2. Dosya Seçimi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenFile(int fileNumber)
        {
            try
            {
                fileDialog.Filter = "Metin Dosyası |*.txt";
                fileDialog.RestoreDirectory = true;
                fileDialog.Title = "Metin Dosyası Seçiniz";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader streamReader = new StreamReader(fileDialog.FileName);
                    line = streamReader.ReadLine();

                    while (line != null)
                    {
                        if (fileNumber == 1)
                        {
                            listBox1.Items.Add(line);
                            labelFirstFile.Text = fileDialog.FileName;
                        }
                        else if (fileNumber == 2)
                        {
                            listBox2.Items.Add(line);
                            labelSecondFile.Text = fileDialog.FileName;
                        }
                        line = streamReader.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stackTrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "Dosya Seçimi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void listBox_RenkAyarla(object sender, DrawItemEventArgs e)
        {
            Brush myBrush = Brushes.Red;
            e.DrawBackground();
            try
            {
                if (listBox1.Items[e.Index].ToString() == ((ListBox)sender).Items[e.Index].ToString())
                    myBrush = Brushes.Black;
            }
            catch
            {                
            }
            finally
            {
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }
    }
}
