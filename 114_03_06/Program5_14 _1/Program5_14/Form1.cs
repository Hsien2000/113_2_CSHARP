using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Program5_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader inputFile; // 宣告StreamReader物件
            int sum = 0; // 宣告變數sum用來存放總和
            int count = 0; // 宣告變數count用來存放數字個數
            int temp = 0; // 宣告變數temp用來存放讀取的數字
            try
            {
                inputFile = File.OpenText("numbers.txt"); // 開啟檔案
                while (!inputFile.EndOfStream) // 檔案未結束
                {
                    count++; // 計算數字個數
                    temp = int.Parse(inputFile.ReadLine()); // 將讀取的數字存入temp
                    sum += temp; // 將數字加總
                    listBox1.Items.Add(temp);// 將資料加入ListBox
                }
                listBox1.Items.Add("總共有: " + count+"個數字\n總和"+sum); // 將總和加入ListBox
                inputFile.Close(); // 關閉檔案
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // 顯示錯誤訊息    
            }
        }
    }
}
