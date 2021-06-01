using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  //kütüptane ekledik StreamWriter için

namespace Dosya_Islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyaadi, dosyayolu;
        StreamWriter sw; //akış yazıcı


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
                //openfiledialog aracındaki dialog aracını calıstır
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }
       

        private void button5_Click_1(object sender, EventArgs e)
        {
            dosyaadi = textBox2.Text;
            sw = File.CreateText(dosyayolu+"\\"+dosyaadi+".txt"); //metin belgesi oluştur methodunu 
            sw.Close(); //yazma işlemini durdur
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //ok tusuna basarsam
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName); //içini file da seçilen dosya adı ile doldur
                string satir = sr.ReadLine(); //satırı oku
                while (satir !=null) //satır değeri null değer olana kadar ekle
                {
                    listBox1.Items.Add(satir);
                    satir = sr.ReadLine(); //satırı okut tekrardan
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) //ok tusuna basarsam
            {
                dosyayolu = folderBrowserDialog1.SelectedPath.ToString(); //seçilen yolu string formatta tut
                textBox1.Text = dosyayolu; //ve dosya yolunu buraya yaz
            }
        }
    }
}
