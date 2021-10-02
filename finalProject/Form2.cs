using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace finalProject
{
    public partial class Form2 : Form
    {
        private int question_index = 0;
        public Form2()
        {
            InitializeComponent();
            initial();
        }
        private void initial()
        {
            button1.Hide();
            button2.Hide();
            button4.Hide();
            button5.Show();
            listBox1.Hide();
            pictureBox9.Hide();
            panel2.Hide();
            label2.Text = ("你有多了解珍珠奶茶呢?");
        }
        private void FirstQ()
        {
            button1.Show();
            button2.Show();
            button4.Show();
            button5.Hide();
            label2.Text = ("珍珠是用甚麼做的?");
            button1.Text = ("麵粉");
            button2.Text = ("玉米粉");
            button4.Text = ("樹薯粉");  //O
            question_index = 1;
        }
        private void SecondQ()
        {
            label2.Text = ("一杯珍珠奶茶熱量大約相當於...");
            button1.Text = ("一個排骨便當");    //O
            button2.Text = ("一個飯糰");
            button4.Text = ("一根香蕉");
            question_index = 2;
        }
        private void ThirdQ()
        {
            label2.Text = ("台灣人每年共喝下約多少珍奶?");
            button1.Text = ("五千萬杯");
            button2.Text = ("八千萬杯");
            button4.Text = ("一億杯");   //O
            question_index = 3;
        }
        private void FourthQ()
        {
            label2.Text = ("珍珠奶茶大約出現多久了?");
            button1.Text = ("20年");
            button2.Text = ("30年");  //O
            button4.Text = ("40年");
            question_index = 4;
        }
        private void SecretMenu()
        {
            label2.Text = ("恭喜你全部答對! 獲得隱藏菜單~");
            List();
            listBox1.Show();
            pictureBox9.Show();
            panel2.Show();
            button1.Hide();
            button2.Hide();
            button4.Hide();
            button5.Hide();
            question_index = 0;
        }
        private void List()
        {
            StreamReader
            sr = new StreamReader("隱藏菜單.txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
            while (sr.Peek() > -1)
            {
                listBox1.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }
        private void compareList(string name, int price, string bubble, string sugar, string milktea, int star, string special)
        {
            label16.Text = name;
            label10.Text = price.ToString();
            label11.Text = bubble;
            label12.Text = sugar;
            label13.Text = milktea;
            label14.Text = star.ToString() + "★";
            label15.Text = special;
        }
        //back button
        private void button3_Click(object sender, EventArgs e)
        {
            switch (question_index)
            {
                case 0:
                    this.Close();
                    break;
                default:
                    initial();
                    break;
            }
            /*switch (question_index)
            {
                case 0:
                    this.Close();
                    break;
                case 1:
                    initial();
                    break;
                case 2:
                    FirstQ();
                    break;
                case 3:
                    SecondQ();
                    break;
                case 4:
                    ThirdQ();
                    break;
            }*/
        }
        //第三個選項
        private void button4_Click(object sender, EventArgs e)
        {
            switch (question_index)
            {
                case 1:
                    SecondQ();
                    break;
                case 3:
                    FourthQ();
                    break;
                default:
                    initial();
                    break;
            }
        }
        //第二個選項
        private void button2_Click(object sender, EventArgs e)
        {
            switch (question_index)
            {
                case 4:
                    SecretMenu();
                    break;
                default:
                    initial();
                    break;
            }
        }
        //第一個選項
        private void button1_Click(object sender, EventArgs e)
        {
            switch (question_index)
            {
                case 2:
                    ThirdQ();
                    break;
                default:
                    initial();
                    break;
            }
        }
        //開始作答
        private void button5_Click(object sender, EventArgs e)
        {
            FirstQ();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "黃氏波霸奶茶專賣店(北區)")
            {
                compareList("波霸奶茶", 35, "軟Q", "微糖", "茶味十分濃厚", 4, "基底是台灣高山茶，而且很便宜");
                pictureBox9.Image = Image.FromFile(@"黃氏.jpg");
                pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (listBox1.Text == "OAAO (中西)")
            {
                compareList("巫婆奶奶", 50, "Q彈", "半糖", "偏甜", 4, "烏龍味很重><");
                pictureBox9.Image = Image.FromFile(@"OAAO.jpg");
                pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (listBox1.Text == "林紅茶嫩仙草珍珠粉圓專賣店(中西)")
            {
                compareList("珍珠香水鮮奶茶", 60, "Q彈", "半糖", "黑糖很香", 4, "無");
                pictureBox9.Image = Image.FromFile(@"林紅茶.jpg");
                pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (listBox1.Text == "小將好茶(安平)")
            {
                pictureBox9.Image = Image.FromFile(@"小將.jpg");
                pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                compareList("波霸黑糖鮮奶", 60, "普通", "半糖", "有焦糖香", 4, "雞蛋糕好吃><");
            }
        }
    }
}
