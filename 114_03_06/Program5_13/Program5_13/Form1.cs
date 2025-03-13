using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Program5_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();//亂數
            StreamWriter outputFile;
            int count;

            try
            {
                if (saveFile.ShowDialog() == DialogResult.OK) 
                {
                    outputFile = File.CreateText(saveFile.FileName);
                    if (int.TryParse(textBox1.Text, out count))
                    {
                        for (int i = 0; i < count; i++)
                        {
                            outputFile.WriteLine(rand.Next(100) + 1);

                        }
                        outputFile.Close();
                        MessageBox.Show("已建檔");

                    }
                    else
                    {
                        MessageBox.Show("請輸入數字");
                    }
                }
                else
                {
                    MessageBox.Show("按了取消");
                }

                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);//顯示錯誤訊息
            }
        }
    }
}
