using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace finalProject
{
    public partial class Form1 : Form
    {
        int back_index = 0;
        string[] shop = new string[] { "海鷗", "四季奶茶", "櫻桃菓子", "馬卡鮮飲", "杯子社", "迷客夏", "春紀本家", "日日裝茶", "穆納", "彤露おかわり" };
        Random r = new Random();
        int[] rd = new int[5];
        public Form1()
        {
            InitializeComponent();
            firstInterface();
        }
        void firstInterface()//一開始介面
        {
            panel6.Hide();
            for (int i = 0; i < 5; ++i)
            {
                rd[i] = r.Next(0, 10);
                for (int j = 0; j < i; ++j)
                {
                    if (rd[i] == rd[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            b11.Text = shop[rd[0]];
            b22.Text = shop[rd[1]];
            b33.Text = shop[rd[2]];
            b44.Text = shop[rd[3]];
            b55.Text = shop[rd[4]];
            label16.Text = "名稱";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            panel5.Hide();
            listBox2.Hide();
            button1.Show();//map btn
            button2.Show();//list btn
            label1.Show();//mode label
            label3.Show();//標題
            button7.Show();//心理測驗btn
            button3.Hide();//back
            panel2.Hide();//map
            panel3.Hide();//list
            panel4.Hide();
            button8.Show();//trivia
            label2.Text = "嗨嗨~今天要用甚麼模式來探索呢?";
        }
        void mapInterface()//點入地圖後的介面
        {
            panel5.Hide();
            listBox2.Hide();//map mousehover
            panel3.Hide();//list
            panel2.Show();//map
            button1.Hide();
            button2.Hide();
            label1.Hide();
            label3.Hide();
            button7.Hide();
            button3.Show();
            label2.Text = "選一個地區吧~";
        }
        void listInterface()//點入列表後的介面
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            listBox1.Items.Clear();
            panel5.Hide();
            panel3.Show();//list
            panel4.Show();
            groupBox1.Show();
            groupBox2.Show();
            panel2.Hide();//map
            button1.Hide();
            button2.Hide();
            label1.Hide();
            label3.Hide();
            button7.Hide();
            button3.Show();
            label2.Text = "今天要喝什麼樣的珍奶呢?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //map
            mapInterface();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //list
            listInterface();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile("0.png");
            b11.Enabled = false;
            b22.Enabled = false;
            b33.Enabled = false;
            b44.Enabled = false;
            b55.Enabled = false;
            if (back_index == 0) firstInterface();
            else
            {
                mapInterface();
                back_index = 0;                
                panel2.Show();
                panel3.Hide();
                panel4.Hide();
            }
        }

        //爬梯子的btn
        private void button7_Click(object sender, EventArgs e)
        {
            panel5.Show();
            button7.Hide();
            button8.Hide();
            button3.Show();
            //listBox2.Hide();//map mousehover
            //panel2.Hide();//map
            //panel3.Hide();//list
            button1.Hide();
            button2.Hide();
            label1.Hide();
            //label3.Hide();
            //button7.Hide();
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "不知道要喝甚麼的話就按這個按鈕吧!!";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "今天要喝什麼樣的珍奶呢?";
            if(panel5.Visible == true)
            {
                label2.Text = "點選一個數字吧~";
            }
        }

        private void button4_Click(object sender, EventArgs e)//永康
        {
            panel5.Hide();
            panel2.Hide();
            back_index = 1;
            label2.Text = "點選店家查看更多資訊~";
            //列表模式的工具
            panel3.Show();
            panel4.Show();
            groupBox1.Hide();
            groupBox2.Hide();
            //清空
            listBox1.Items.Clear();
            label16.Text = "名稱";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            StreamReader
               sr = new StreamReader("永康區(星).txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
            while (sr.Peek() > -1)
            {
                listBox1.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void button5_Click(object sender, EventArgs e)//東區
        {
            panel5.Hide();
            panel2.Hide();
            back_index = 1;
            label2.Text = "點選店家查看更多資訊~";
            //列表模式的工具
            panel3.Show();
            panel4.Show();
            groupBox1.Hide();
            groupBox2.Hide();
            listBox1.Items.Clear();
            label16.Text = "名稱";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            StreamReader
            sr = new StreamReader("東區(星).txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
            while (sr.Peek() > -1)
            {
                listBox1.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void button6_Click(object sender, EventArgs e)//中西
        {
            panel5.Hide();
            panel2.Hide();
            back_index = 1;
            label2.Text = "點選店家查看更多資訊~";
            //列表模式的工具
            panel3.Show();
            panel4.Show();
            groupBox1.Hide();
            groupBox2.Hide();
            listBox1.Items.Clear();
            label16.Text = "名稱";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            StreamReader
               sr = new StreamReader("中西區(星).txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
            while (sr.Peek() > -1)
            {
                listBox1.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "公館手作") compare("公館鮮奶紅茶", 55, "普通", "二分", "偏水", 2, "無");
            if (listBox1.Text == "黃氏波霸奶茶專賣店(北區)") compare("波霸奶茶", 35, "Q彈", "微糖", "茶很香", 4, "基底是台灣高山茶!");
            if (listBox1.Text == "雨前三毛") compare("黑鑽歐蕾", 40, "普通", "微糖", "黑糖很不錯><", 4, "無");
            if (listBox1.Text == "BIGSTYLE") compare("波霸奶茶", 45, "偏軟爛", "半糖", "偏淡", 2, "舒芙蕾比較好吃");
            if (listBox1.Text == "誠沏") compare("黑糖手作粉圓奶茶", 45, "普通", "微糖", "黑糖很不錯><", 4, "用料天然.有文藝氣息><");
            if (listBox1.Text == "青子菁茶舖") compare("波霸黑糖鮮奶", 45, "普通", "半糖", "中規中矩", 3, "炸雞比較讚!!!");
            if (listBox1.Text == "雨茶堂") compare("阿薩姆奶茶+波霸", 45, "普通", "微糖", "茶很香", 4, "無");
            if (listBox1.Text == "初花") compare("漂浮波霸奶茶(500cc)", 45, "Q彈", "微糖", "茶很有特色", 4, "無");
            if (listBox1.Text == "四季奶茶") compare("四季奶茶", 45, "普通", "全糖", "茶很香不苦澀", 4, "便宜用料沒在客");
            if (listBox1.Text == "台灣茶渠") compare("波霸鮮奶茶", 50, "偏硬偏小", "半糖", "茶味很奇怪", 1, "無");
            if (listBox1.Text == "井茶.好茶") compare("牛奶鮮奶紅", 45, "普通", "半糖", "很淡很像水", 2, "無");
            if (listBox1.Text == "OAAO (中西)") compare("巫婆奶奶", 50, "Q彈", "半糖", "偏甜", 4, "烏龍味很重><");
            if (listBox1.Text == "鮮茶道") compare("珍珠奶茶", 50, "軟爛", "半糖", "很像水ˊˋ", 0, "無");
            if (listBox1.Text == "清心") compare("珍珠奶茶", 50, "噁爛", "微糖", "淡如水", 0, "喝過最想吐的珍奶");
            if (listBox1.Text == "茶聚") compare("黑糖珍珠鮮奶(大)", 50, "Q彈", "固定", "茶很香", 4, "無");
            if (listBox1.Text == "春紀本家") compare("黑糖伯爵波阿鮮奶", 50, "讚", "微糖", "茶很香", 4, "無");
            if (listBox1.Text == "青蛙黑蛋奶") compare("黑蛋奶(大)", 50, "Q彈", "微糖", "普通", 2, "無");
            if (listBox1.Text == "波哥文學茶館") compare("珍珠鮮奶茶", 50, "普通", "半糖", "沒甚麼茶味", 2, "無");
            if (listBox1.Text == "東洲") compare("黑蛋奶(大)", 50, "Q彈", "微糖", "偏甜", 2, "甜到喉嚨會不舒服");
            if (listBox1.Text == "幸福堂") compare("黑糖珍珠鮮奶", 50, "軟爛", "半糖", "化學味", 1, "無");
            if (listBox1.Text == "彤露おかわり") compare("黑糖波霸鮮奶", 50, "Q彈有甜味", "半糖", "偏甜但順口", 4, "有其他小點心可以搭配><");
            if (listBox1.Text == "米塔黑糖") compare("黑糖珍珠鮮奶", 50, "很軟爛", "半糖", "黑糖香很夠", 3, "其他真的不好喝");
            if (listBox1.Text == "回春堂") compare("黑糖珍珠鮮乳", 50, "Q彈", "半糖", "偏甜", 3, "包裝跟整體風格是網美的fu(古風)");
            if (listBox1.Text == "冰封仙果") compare("珍珠鮮奶茶", 50, "有點軟爛", "半糖", "茶很香", 3, "珍珠奶茶冰");
            if (listBox1.Text == "木太郎茶飲") compare("珍珠鮮奶茶", 50, "偏軟爛", "半糖", "偏淡很普通", 2, "無");
            if (listBox1.Text == "50嵐") compare("珍珠 / 波霸奶茶(L)",50, "普通", "微糖", "普通偏淡", 2, "無");
            if (listBox1.Text == "雙囍茶會") compare("薩蘭鮮奶茶+波霸", 55, "普通", "微糖", "有特殊的味道但不是很喜歡", 2, "無");
            if (listBox1.Text == "穆納") compare("招牌鮮奶茶+波霸", 55, "Q彈", "半糖", "茶香很夠", 4, "無");
            if (listBox1.Text == "橘子水樣") compare("烏龍鮮奶茶+珍珠", 55, "偏軟爛", "半糖", "茶很香", 3, "學生證可打折!");
            if (listBox1.Text == "醇淬") compare("珍珠醇紅歐蕾", 55, "普通", "微糖", "蠻淡的", 2, "無");
            if (listBox1.Text == "蓋不同") compare("雙Q奶茶", 55, "普通", "微糖", "中規中矩", 3, "無");
            if (listBox1.Text == "漫渡拾光") compare("波霸鮮奶茶", 55, "普通偏爛", "中規中矩", "茶很香", 3, "無");
            if (listBox1.Text == "麻古茶坊") compare("波霸紅茶拿鐵", 55, "普通", "微糖", "中規中矩", 3, "無");
            if (listBox1.Text == "御私藏") compare("北海道鮮奶茶+波霸", 55, "普通", "微糖", "偏甜", 3, "北海道鮮奶本身有甜度所以覺得好甜");
            if (listBox1.Text == "茗茶園") compare("波霸紅茶拿鐵", 55, "軟爛", "微糖", "非常難喝", 1, "無");
            if (listBox1.Text == "東風御") compare("波霸紅茶拿鐵", 55, "普通", "微糖", "茶很香", 4, "無");
            if (listBox1.Text == "老虎堂") compare("老虎堂厚鮮奶", 55, "普通", "半糖", "超甜", 3, "太甜太膩");
            if (listBox1.Text == "米二代") compare("波霸鮮奶茶", 55, "偏軟爛", "半糖", "超甜", 2, "無");
            if (listBox1.Text == "双十八木") compare("鐵觀音拿鐵+波霸", 55, "Q彈", "微糖", "中規中矩", 4, "飲料很有特色");
            if (listBox1.Text == "八十八夜茶倉") compare("焙茶拿鐵+波霸", 55, "偏軟爛", "微糖", "茶很普", 3, "無");
            if (listBox1.Text == "一手私藏") compare("珍珠厚黑奶", 55, "普通", "微糖", "茶很香", 3, "無");
            if (listBox1.Text == "LinGo另果") compare("波霸紅茶拿鐵", 60, "普通", "半糖", "很甜很可怕", 3, "無");
            if (listBox1.Text == "櫻桃菓子") compare("英式鮮奶茶+山藥小圓", 60, "很特別有山藥><", "微糖", "茶很香", 4, "珍珠很特別");            
            if (listBox1.Text == "林紅茶嫩仙草珍珠粉圓專賣店(中西)") compare("珍珠香水鮮奶茶", 60, "Q彈", "半糖", "黑糖很香><", 4, "無");
            if (listBox1.Text == "侘茶") compare("招牌鮮奶茶+波霸", 60, "普通", "微糖", "中規中矩", 3, "無");
            if (listBox1.Text == "可不可") compare("白玉歐雷", 60, "Q彈", "微糖", "茶很有特色", 4, "無");
            if (listBox1.Text == "水野") compare("波霸鮮奶茶", 60, "有點軟爛", "微糖", "普通", 3, "無");
            if (listBox1.Text == "日日裝茶") compare("老鐵紅茶鮮奶+珍珠+OREO", 60, "Q彈", "微糖", "茶很香", 4, "有很多種特殊料可以選");
            if (listBox1.Text == "小將好茶(安平)") compare("波霸黑糖鮮奶", 60, "普通", "半糖", "有焦糖香><", 4, "雞蛋糕好吃><");
            if (listBox1.Text == "丸子") compare("黑糖丸子鮮奶", 60, "軟爛", "微糖", "很難喝", 1, "無");
            if (listBox1.Text == "上宇林") compare("鮮奶綠茶+珍珠", 60, "普通中上", "微糖", "普通", 3, "無");
            if (listBox1.Text == "十一") compare("珍珠醇奶歐蕾", 60, "Q彈", "微糖", "茶很香", 4, "有繽紛珍珠><");
            if (listBox1.Text == "馬卡鮮飲") compare("焦糖波霸撞奶", 65, "普通", "半糖", "有焦糖香><", 4, "無");
            if (listBox1.Text == "烏弄") compare("綠茶拿鐵 + 白珍珠", 65, "普通", "微糖", "中規中矩", 3, "無");
            if (listBox1.Text == "春陽茶事") compare("黑糖珍珠鮮奶", 65, "Q彈", "微糖", "黑糖很香", 4, "無");
            if (listBox1.Text == "古玥") compare("獨家厚乳+粉圓", 65, "普通偏甜", "微糖", "順口", 4, "無");
            if (listBox1.Text == "鮮自然") compare("新鮮果橙綠+珍珠", 70, "普通", "微糖", "淡如水", 2, "店員態度偏差");         
            if (listBox1.Text == "杯子社") compare("泰式奶茶+珍珠", 70, "Q彈", "微糖", "茶很香", 4, "貴妃珍珠是方的");
            if (listBox1.Text == "珍煮丹") compare("泰泰鮮奶茶+波霸", 80, "Q彈", "微糖", "偏甜", 3, "無");
            if (listBox1.Text == "迷客夏") compare("焙茶鮮奶茶+波霸", 90, "Q彈", "微糖", "茶很香", 4, "茶超好喝");
            if (listBox1.Text == "T茶館") compare("烏龍春珍珠奶茶", 120, "普通", "半糖", "中規中矩", 3, "最貴的奶茶!");
            if (listBox1.Text == "海鷗") compare("桂花鮮奶茶+珍珠", 70, "Q彈", "少", "茶很香", 5, "自家熬煮蔗糖甜度較低，比較健康");
        }

        private void compare(string name,int price, string bubble, string sugar, string milktea, int star, string special)
        {
            label16.Text = name;
            label10.Text = price.ToString();
            label11.Text = bubble;
            label12.Text = sugar;
            label13.Text = milktea;
            label14.Text = star.ToString() + "★";
            label15.Text = special;
        }

        private void compare2(string name, int price, string bubble, string sugar, string milktea, int star, string special)
        {
            label17.Text = name;
            label23.Text = price.ToString();
            label22.Text = bubble;
            label21.Text = sugar;
            label20.Text = milktea;
            label19.Text = star.ToString() + "★";
            label18.Text = special;
        }

        private void list()
        {
            listBox1.Items.Clear();
            if(radioButton1.Checked && radioButton5.Checked)
            {
                StreamReader 
                sr = new StreamReader("東區(星).txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
                while (sr.Peek() > -1)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
            if (radioButton1.Checked && radioButton6.Checked)
            {
                StreamReader
                sr = new StreamReader("東區(價格).txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
                while (sr.Peek() > -1)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
            if (radioButton2.Checked && radioButton5.Checked)
            {
                StreamReader
                sr = new StreamReader("中西區(星).txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
                while (sr.Peek() > -1)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
            if (radioButton2.Checked && radioButton6.Checked)
            {
                StreamReader
                sr = new StreamReader("中西區(價格).txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
                while (sr.Peek() > -1)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
            if (radioButton3.Checked && radioButton5.Checked)
            {
                StreamReader
                sr = new StreamReader("永康區(星).txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
                while (sr.Peek() > -1)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
            if (radioButton3.Checked && radioButton6.Checked)
            {
                StreamReader
                sr = new StreamReader("永康區(價格).txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
                while (sr.Peek() > -1)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            list();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            list();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Show();//顯示店家          
            listBox2.Items.Add("((按照推薦程度))");
            StreamReader
               sr = new StreamReader("東區(星).txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
            while (sr.Peek() > -1)
            {
                listBox2.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            listBox2.Hide();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Show();//顯示店家          
            listBox2.Items.Add("((按照推薦程度))");
            StreamReader
               sr = new StreamReader("中西區(星).txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
            while (sr.Peek() > -1)
            {
                listBox2.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            listBox2.Hide();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Show();//顯示店家          
            listBox2.Items.Add("((按照推薦程度))");
            StreamReader
               sr = new StreamReader("永康區(星).txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
            while (sr.Peek() > -1)
            {
                listBox2.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            listBox2.Hide();
        }
        //珍奶小知識問答
        private void button8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(this);
        }

        private void bClick()
        {
            label2.Text = "點選結果查看更多資訊~";
            b11.Enabled = false;
            b22.Enabled = false;
            b33.Enabled = false;
            b44.Enabled = false;
            b55.Enabled = false;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile("1.png");
            bClick();
            b11.Enabled = true;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile("2.png");
            bClick();
            b22.Enabled = true;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile("3.png");
            bClick();
            b33.Enabled = true;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile("4.png");
            bClick();
            b44.Enabled = true;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile("5.png");
            bClick();
            b55.Enabled = true;
        }

        private void b33_Click(object sender, EventArgs e)
        {
            choose(b33);
        }

        private void b22_Click(object sender, EventArgs e)
        {
            choose(b22);
        }

        private void b44_Click(object sender, EventArgs e)
        {
            choose(b44);
        }

        private void b55_Click(object sender, EventArgs e)
        {
            choose(b55);
        }

        private void b11_Click(object sender, EventArgs e)
        {
            choose(b11);
        }

        private void choose(Button b)
        {
            if (b.Text == "海鷗") compare2("桂花鮮奶茶+珍珠", 70, "Q彈", "少", "茶很香", 5, "自家熬煮蔗糖甜度較低，比較健康");
            if (b.Text == "四季奶茶") compare2("四季奶茶", 45, "普通", "全糖", "茶很香不苦澀", 4, "便宜用料沒在客");
            if (b.Text == "櫻桃菓子") compare2("英式鮮奶茶+山藥小圓", 60, "很特別有山藥><", "微糖", "茶很香", 4, "珍珠很特別");
            if (b.Text == "馬卡鮮飲") compare2("焦糖波霸撞奶", 65, "普通", "半糖", "有焦糖香><", 4, "無");
            if (b.Text == "杯子社") compare2("泰式奶茶+珍珠", 70, "Q彈", "微糖", "茶很香", 4, "貴妃珍珠是方ㄉ 好ㄘ");
            if (b.Text == "迷客夏") compare2("焙茶鮮奶茶+波霸", 90, "Q彈", "微糖", "茶很香", 4, "茶超好喝");
            if (b.Text == "春紀本家") compare2("黑糖伯爵波阿鮮奶", 50, "讚", "微糖", "茶很香", 4, "無");
            if (b.Text == "彤露おかわり") compare2("黑糖波霸鮮奶", 50, "Q彈有甜味", "半糖", "偏甜但順口", 4, "有其他小點心可以搭配><");
            if (b.Text == "穆納") compare2("招牌鮮奶茶+波霸", 55, "Q彈", "半糖", "茶香很夠", 4, "無");
            if (b.Text == "日日裝茶") compare2("老鐵紅茶鮮奶+珍珠+OREO", 60, "Q彈", "微糖", "茶很香", 4, "有很多種特殊料可以選");
            b.Enabled = false;
            panel6.Show();
        }
    }
}
