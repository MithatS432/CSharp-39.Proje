using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarih_ve_Saat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Şu anki tarih ve saat
            DateTime simdi = DateTime.Now;
            Console.WriteLine("Şu anki tarih ve saat: " + simdi);

            // Sadece tarihi al
            Console.WriteLine("Bugünün tarihi: " + simdi.ToShortDateString());

            // Sadece saati al
            Console.WriteLine("Şu anki saat: " + simdi.ToLongTimeString());

            // Belirli bir tarihi oluştur
            DateTime mezuniyetTarihi = new DateTime(2025, 6, 24);
            Console.WriteLine("Mezuniyet Tarihi: " + mezuniyetTarihi.ToLongDateString());

            // Tarihe 10 gün ekle
            DateTime tatilBaslangici = mezuniyetTarihi.AddDays(10);
            Console.WriteLine("Tatil Başlangıcı: " + tatilBaslangici.ToShortDateString());
        }
    }
}
