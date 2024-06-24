using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calışan_Kaybı_Sınıflandırmas
{
    internal class classİslemler
    {
        // İzin verilen karakterlerin listesi
        private char[] karakerler = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        // Yanlış giriş sayacı
        private int hatalıkarakter = 0;








        public void YolTboxKeyPress(object sender, KeyPressEventArgs e)
        {

            
            char inputChar = e.KeyChar;

           
            if (inputChar == '\b')
            {
                return;
            }

            if (Array.IndexOf(karakerler, char.ToLower(inputChar)) == -1)
            {
                if (hatalıkarakter <= 0)
                {
                    MessageBox.Show("Yanlış karakter girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              

            
                hatalıkarakter++;

                
                if (hatalıkarakter == 10)
                {
                    MessageBox.Show("Çok fazla yanlış karakter denemesi yaptınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }

                
                e.Handled = true;
            
        }

            
            if (!karakerler.Contains(char.ToLower(e.KeyChar)))
            {
                
                e.Handled = true;
            }
        
    }






    //----------------------------------------------------------------------------------------------------------------






    public DataTable LoadCsvToDataTable(string filePath)
        {
            DataTable dataTable = new DataTable(); // Yeni bir DataTable oluşturuluyor

            using (StreamReader reader = new StreamReader(filePath)) // Dosya okumak için StreamReader kullanılıyor
            {
                bool isFirstRow = true; // İlk satırın kontrolü için bir bayrak değişkeni
                string[] headers = null; // Başlık satırını tutmak için bir dizi

                while (!reader.EndOfStream) // Dosyanın sonuna kadar okuma döngüsü
                {
                    var line = reader.ReadLine(); // Bir satır okunuyor
                    var values = line.Split('|'); // Satır virgüllerle ayrılarak parçalara ayrılıyor

                    if (isFirstRow) // Eğer ilk satır ise
                    {
                        headers = values; // Başlık satırını al
                        foreach (var header in headers) // Her bir başlık için
                        {
                            dataTable.Columns.Add(header); // DataTable'a sütun olarak ekle
                        }
                        isFirstRow = false; // İlk satır okundu olarak işaretleme
                    }
                    else
                    {
                        dataTable.Rows.Add(values); // İlk satır değilse, bu satırı DataTable'a satır olarak ekle
                    }

                }
            }

            return dataTable; // DataTable'ı geri döndür
        }







        //---------------------------------------------------------------------------------------------








        public string csvFile(string directoryPath, string searchPattern)
        {
            var directoryInfo = new DirectoryInfo(directoryPath); // Belirtilen dizin hakkında bilgi almak için DirectoryInfo oluşturuluyor
            var fileInfo = directoryInfo.GetFiles(searchPattern)
                .OrderByDescending(f => f.LastWriteTime) // Dosyaları son yazılma tarihine göre sırala
                .FirstOrDefault(); // En yeni dosyayı seç

            return fileInfo?.FullName; // Eğer dosya bulunursa tam yolunu döndür, bulunamazsa null döndür
        }










        //---------------------------------------------










        public void savecsvdatagrid(DataGridView dgv, SaveFileDialog save)
        {
            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";
                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgv.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
        }
    }
}
