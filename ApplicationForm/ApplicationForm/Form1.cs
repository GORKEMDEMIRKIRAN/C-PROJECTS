using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.IO;


namespace ApplicationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // TEMİZLEME İŞLEMİ İÇİN METOD TANIMLADIK.
        // Hücreleri temizlemek için tanımlanmıştır.
        void cell_clear()
        {
            name.Text = "";
            company.Text = "";
            phone.Text = "";
            email.Text = "";
            communication.Text = "";
            project_name.Text = "";
            project_target.Text = "";
            project_type.Text = "";
            project_scope.Text = "";
            money.Text = "";
            system.Text = "";
            technology.Text = "";
            entegration.Text = "";
            project_date.Text = "";
            hours.Text = "";
            extra.Text = "";

            name.Focus();
        }



        SqlConnection ways = new SqlConnection("Data Source=DESKTOP-6TD9LPM\\SQLEXPRESS;Initial Catalog=application_person;Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            // HER BİR DEĞİŞKEN FORM ÜZERİNDEKİ VERİ KUTULARINI İFADE EDİYOR.
            // Bu kutulara girilen verileri değişkenler üzerine aktarıyor.
            string number1 = name.Text;
            string number2 = company.Text;
            string number3 = phone.Text;
            string number4 = email.Text;
            string number5 = communication.Text;
            string number6 = project_name.Text;
            string number7 = project_target.Text;
            string number8 = project_type.Text;
            string number9 = project_scope.Text;
            string number10 = money.Text;
            string number11 = system.Text;
            string number12 = technology.Text;
            string number13 = entegration.Text;
            string number14 = project_date.Text;
            string number15 = hours.Text;
            string number16 = extra.Text;


            // PROJEMİZ İÇİNDEKİ METİN BELGESİNİN DOSYA YOLU
            string file_way = @"C:\Users\gorke\Desktop\ASP.NET CORE\ApplicationForm\ApplicationForm\saved_list.txt";

            using (StreamWriter sw = new StreamWriter(file_way, true)) // true ile dosyaya ekleme yapar.
            {
               
                    //GİRİLEN FORM BİLGİLERİNİ METİN BELGESİNDE TEK SATIRA VİRGÜL İLE AYRILMIŞ ŞEKİLDE YAZIYOR.
                 sw.WriteLine(number1+","+number2 + "," + number3
                        +"," + number4 + "," + number5 + "," + number6 + "," + number7
                        +"," + number8 + "," + number9 + "," + number10+"," + number11
                        +"," + number12 + "," + number13 + "," +number14 +"," + number5 + "," + number16);
            }
                // KAYIT İŞLEMİNİN TAMAMLANDIĞINI SÖYLEYEN MESAJI EKRANA YAZDIRIYOR.
                MessageBox.Show("Kayıt işlemi tamamlandı.");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // TANIMLADIĞIMIZ METOD TEMİZLEME BUTONUNDA ÇALIŞTIRARAK HÜCRELERİ TEMİZLEME İŞLEMİ GERÇEKLEŞTİRİYOR.
            cell_clear();

        }

    }
  
}
