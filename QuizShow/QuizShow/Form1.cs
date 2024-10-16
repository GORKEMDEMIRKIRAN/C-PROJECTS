using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int q_no = 0, tr = 0,fl = 0;


        private void next_Click(object sender, EventArgs e)
        {
            // "next" butonu tıkladığımızda gerçekleşen olaylar.
            // A,B,C,D butonları aktif oldu.
            // Next butonu pasif oldu.
            // red ve green buton resileri görünmez oldu.

            // soru sayısı 1 arttırıldı ve label aktarıldı.
            // soru sayısına göre richtextbox soru ve butonlara cevaplar aktarıldı.
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            next.Enabled = false;
            green.Visible = false;
            red.Visible = false;

            q_no = q_no + 1;
            question_no.Text = q_no.ToString();
            if (q_no == 1)
            {
                richTextBox1.Text = "Türkiyenin başkenti hangisidir ?";
                btnA.Text = "İstanbul";
                btnB.Text = "Ankara";
                btnC.Text = "İzmir";
                btnD.Text = "Bursa";
                //Doğru cevabın yazıldığı label
                label7.Text = "Ankara";
                
            }
            if (q_no == 2)
            {
                richTextBox1.Text = "İzmirin nüfusu kaçtır ?";
                btnA.Text = "1 milyon";
                btnB.Text = "2 milyon";
                btnC.Text = "3 milyon";
                btnD.Text = "4 milyon";
                //Doğru cevabın yazıldığı label
                label7.Text = "2 milyon";
            }
            if (q_no == 3)
            {
                richTextBox1.Text = "Dünya'nın büyük fast food zinciri hangisidir ?";
                btnA.Text = "Burger King";
                btnB.Text = "McDonald's";
                btnC.Text = "Popeyes";
                btnD.Text = "Arbys";
                //Doğru cevabın yazıldığı label
                label7.Text = "McDonald's";

                next.Text = "Sonuçlar";
            }
            else if(q_no >3)
            {
                // Sorular bittiğinde;

                // butonların aktifliği kalkacak.
                // kırmızı ve yeşil renkler yok olacak.
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                next.Enabled = false;
                // kırmızı ve yeşil botun resimleri "visible" hale geldi.
                green.Visible = false;
                red.Visible = false;

                MessageBox.Show("The correct number of question: " + tr + "\n" + "The wrong number of question: " + fl);
            }
        }



        private void btnA_Click(object sender, EventArgs e)
        {
            // A butonuna tıklandığında;
            
            // Butonlar pasif olmaktadır.
            // next butonu aktif olmaktadır.

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            next.Enabled = true;
            
            // A butonundaki cevap ve soru sayısındaki cevaplar karşılaştırılmaktadır.
            // eğer eşitse doğru sayısı 1 artar ve yeşil buton resmi görünür olur.
            // eğer değilse yanlış sayısı 1 artar ve kırmızı buton resmi görünür olur.

            // Bu işlem 4 buton için aynı olur.

            label8.Text = btnA.Text;
            if (label7.Text == label8.Text)
            {
                tr = tr + 1;
                question_true.Text = tr.ToString();
                green.Visible = true;
            }
            else
            {
                fl = fl + 1;
                question_false.Text = fl.ToString();
                red.Visible = true;
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            next.Enabled = true;

            label8.Text = btnB.Text;
            if (label7.Text == label8.Text)
            {
                tr = tr + 1;
                question_true.Text = tr.ToString();
                green.Visible = true;
            }
            else
            {
                fl = fl + 1;
                question_false.Text = fl.ToString();
                red.Visible = true;
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            next.Enabled = true;

            label8.Text = btnC.Text;
            if (label7.Text == label8.Text)
            {
                tr = tr + 1;
                question_true.Text = tr.ToString();
                green.Visible = true;
            }
            else
            {
                fl = fl + 1;
                question_false.Text = fl.ToString();
                red.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            next.Enabled = true;

            label8.Text = btnD.Text;
            if (label7.Text == label8.Text)
            {
                tr = tr + 1;
                question_true.Text = tr.ToString();
                green.Visible = true;
            }
            else
            {
                fl = fl + 1;
                question_false.Text = fl.ToString();
                red.Visible = true;
            }
        }
    }
}
