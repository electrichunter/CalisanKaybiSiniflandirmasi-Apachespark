using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using static Microsoft.Spark.Sql.Functions;
using MaterialSkin.Controls;
using Microsoft.Spark.Sql; // MaterialSkin kontrol sınıfları için gerekli using ifadesi
namespace calışan_Kaybı_Sınıflandırmas
{
   
    public partial class ana_Frm : MaterialForm
    {


        classİslemler classlar = new classİslemler();
        public ana_Frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void tabPageCalışanYaş_Click(object sender, EventArgs e)
        {



        }

        private void performansTabPage_Click(object sender, EventArgs e)
        {

        }

        private void yasTabPage_Click(object sender, EventArgs e)
        {
         
        }

        private void mHesaplaBtn_Click(object sender, EventArgs e)
        {
            // Dosya yolunu belirleyin
            string dosyaYolu = "/home/CalisanKaybiSiniflandirmasi.txt";

            // Dosya yolu boş veya null ise uyarı verin ve işlemi sonlandırın
            if (string.IsNullOrEmpty(dosyaYolu))
            {
                MessageBox.Show("Lütfen dosya yolunu belirt!");
                return;
            }

            // SparkSession oluşturma
            SparkSession spark = SparkSession.Builder()
               .AppName("calısanyasları")
               .GetOrCreate();

            // Metin verilerini yükleyin
            DataFrame veriCercevesi = spark.Read().Text(dosyaYolu);

            // Veri çerçevesindeki sütunları ayıklama
            DataFrame yaskolonlar = veriCercevesi.Select(
                Split(veriCercevesi.Col("value"), ",").GetItem(0).As("KişiID"),
                Split(veriCercevesi.Col("value"), ",").GetItem(1).As("Yas"),
                Split(veriCercevesi.Col("value"), ",").GetItem(2).As("Cinsiyet"),
                Split(veriCercevesi.Col("value"), ",").GetItem(3).As("Şirkette Geçirilen Yıl"),
                Split(veriCercevesi.Col("value"), ",").GetItem(4).As("İş Rolü"),
                Split(veriCercevesi.Col("value"), ",").GetItem(5).As("Aylık Gelir"),
                Split(veriCercevesi.Col("value"), ",").GetItem(6).As("İş-Hayat Denge"),
                Split(veriCercevesi.Col("value"), ",").GetItem(7).As("İş Memnuniyeti"),
                Split(veriCercevesi.Col("value"), ",").GetItem(8).As("Performans Derecelendirmesi"),
                Split(veriCercevesi.Col("value"), ",").GetItem(9).As("Promosyon Sayısı"),
                Split(veriCercevesi.Col("value"), ",").GetItem(10).As("Fazla Mesai"),
                Split(veriCercevesi.Col("value"), ",").GetItem(11).As("Evden Uzaklık"),
                Split(veriCercevesi.Col("value"), ",").GetItem(12).As("Eğitim Seviyesi"),
                Split(veriCercevesi.Col("value"), ",").GetItem(13).As("Medeni Durum"),
                Split(veriCercevesi.Col("value"), ",").GetItem(14).As("Bakmakla Yükümlü Olduğu Sayı"),
                Split(veriCercevesi.Col("value"), ",").GetItem(15).As("İş Seviyesi"),
                Split(veriCercevesi.Col("value"), ",").GetItem(16).As("Şirket Büyüklüğü"),
                Split(veriCercevesi.Col("value"), ",").GetItem(17).As("Şirkette Çalışma Süresi"),
                Split(veriCercevesi.Col("value"), ",").GetItem(18).As("Uzaktan Çalışma"),
                Split(veriCercevesi.Col("value"), ",").GetItem(19).As("Liderlik Fırsatları"),
                Split(veriCercevesi.Col("value"), ",").GetItem(20).As("İnovasyon Fırsatları"),
                Split(veriCercevesi.Col("value"), ",").GetItem(21).As("Şirket İtibarı"),
                Split(veriCercevesi.Col("value"), ",").GetItem(22).As("Çalışan Tanınması"),
                Split(veriCercevesi.Col("value"), ",").GetItem(23).As("İşten Ayrılma Durumu")
            );


            DataFrame ayrilmaDurumuGruplama = yaskolonlar
                      .GroupBy("Yas")
                      .Agg(Functions.Count("*").Alias("ToplamAyrılanKisiSayisi"))
                      .OrderBy(Functions.Desc("Yas"));








            string kaydetmeKonumu = "/home/" + yolTbox.Text;

            // CSV formatında veriyi kaydetme
            ayrilmaDurumuGruplama.Coalesce(1).Write().Format("csv")
                .Option("header", true)
                .Option("delimiter", "  |  ")
                .Mode("overwrite")
                .Save(kaydetmeKonumu);


         
        

            // CSV dosyasının gösterileceği konumu belirleyin
            string gösterkonum = "C:\\Users\\ouysa\\OneDrive\\Masaüstü\\docker_net_volume\\" + yolTbox.Text;

            // Gösterim için CSV dosyasının yolunu belirleyin
            string filePath = classlar.csvFile(gösterkonum, "*.csv");

            // *.csv dosyalarını arayın
            string searchPattern = "*.csv";

            // CSV dosyasını DataTable'a yükleme
            DataTable dataTable = classlar.LoadCsvToDataTable(filePath);

            // DataGridView kontrolünün DataSource özelliğine DataTable'ı atama
            dataGrıdYas.DataSource = dataTable;




            // İşlem tamamlandı mesaj kutusu gösterme
            MessageBox.Show("İşlem başarıyla tamamlandı!");
        }

        private void yasSave_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";
            classlar.savecsvdatagrid(dataGrıdYas, save);

            MessageBox.Show("Başarı ile veriler kaydedilmiştir.");
        }

        private void yolTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            classlar.YolTboxKeyPress(sender, e);
        }

      
    }
}
