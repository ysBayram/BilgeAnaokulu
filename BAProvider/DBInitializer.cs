using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAEntity;

namespace BAProvider
{
    public class DBInitializer : CreateDatabaseIfNotExists<BAContext>
    {
        protected override void Seed(BAContext context)
        {
            Random rd = new Random();

            string[] AdForSinif = new string[4] { "Güneş", "Samanyolu", "Galaksi", "Mars" };
            string[] subeForSinif = new string[4] { "A", "B", "C", "D" };


            foreach (string _ad in AdForSinif)
            {
                foreach (string _sube in subeForSinif)
                {
                    context.Sinif.Add(new Sinif()
                        {
                            Ad = _ad,
                            Sube = _sube
                        });
                }
            }
            
            context.SaveChanges();

            for (int i = 0; i < 10; i++)
            {
                context.Egitmen.Add(new Egitmen()
                    {
                        TCKimlikNo = FakeData.TextData.GetNumeric(10),
                        Ad = FakeData.NameData.GetFirstName(),
                        Soyad = FakeData.NameData.GetSurname(),
                        Sifre = FakeData.TextData.GetNumeric(10),
                        KanGrubu = FakeData.EnumData.GetElement<KanGrubulari>(),
                        Adres = FakeData.PlaceData.GetAddress()
                    });
            }

            context.SaveChanges();

            List<Sinif> sinifForDers = context.Sinif.ToList();
            List<Egitmen> egitmenForDers = context.Egitmen.ToList();

            for (int i = 0; i < 5; i++)
            {
                context.Ders.Add(new Ders()
                    {
                        Ad = FakeData.TextData.GetAlphabetical(10),
                        BaslamaZaman = FakeData.DateTimeData.GetDatetime(DateTime.Now, DateTime.Now.AddDays(7)),
                        BitisZaman = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddMinutes(45), DateTime.Now.AddDays(7).AddMinutes(45)),
                        Icerik = FakeData.TextData.GetSentence(),
                        Sinifi = sinifForDers[rd.Next(0, sinifForDers.Count - 1)],
                        Egitmeni = egitmenForDers[rd.Next(0, egitmenForDers.Count - 1)]
                    });
            }

            context.SaveChanges();

            List<Sinif> sinifForOgrenci = context.Sinif.ToList();
            List<Egitmen> egitmenForOgrenci = context.Egitmen.ToList();

            foreach (Sinif snf in sinifForOgrenci)
            {
                for (int i = 0; i < 5; i++)
                {
                    context.Ogrenci.Add(new Ogrenci()
                        {
                            TCKimlikNo = FakeData.TextData.GetNumeric(10),
                            Ad = FakeData.NameData.GetFirstName(),
                            Soyad = FakeData.NameData.GetSurname(),
                            Sifre = FakeData.TextData.GetNumeric(10),
                            KanGrubu = FakeData.EnumData.GetElement<KanGrubulari>(),
                            Adres = FakeData.PlaceData.GetAddress(),
                            KayitTarihi = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now.AddYears(1)),
                            VeliAd = FakeData.NameData.GetFirstName(),
                            VeliTel = FakeData.PhoneNumberData.GetInternationalPhoneNumber(),
                            VeliCepTel = FakeData.PhoneNumberData.GetInternationalPhoneNumber(),
                            Egitmeni = egitmenForOgrenci[rd.Next(0, egitmenForOgrenci.Count - 1)],
                            Sinifi = snf
                        });
                }
            }

            context.SaveChanges();

            List<Ogrenci> ogrenciForYoklama = context.Ogrenci.ToList();

            foreach (Ogrenci ogr in ogrenciForYoklama)
            {
                context.Yoklama.Add(new Yoklama()
                    {
                        DevamDurumu = FakeData.BooleanData.GetBoolean(),
                        Tarih = FakeData.DateTimeData.GetDatetime(ogr.KayitTarihi, DateTime.Now),
                        Ogrenci = ogr
                    });
            }

            context.SaveChanges();


            List<Sinif> sinifForSinav = context.Sinif.ToList();
            List<Egitmen> egitmenForSinav = context.Egitmen.ToList();
            List<Ders> dersForSinav = context.Ders.ToList();

            foreach (Ders drs in dersForSinav)
            {
                for (int i = 0; i < 3; i++)
                {
                    context.Sinav.Add(new Sinav()
                        {
                            Ad = FakeData.TextData.GetAlphabetical(10),
                            Puan = FakeData.NumberData.GetNumber(0, 100),
                            Sure = FakeData.NumberData.GetNumber(90),
                            BaslangicZaman = FakeData.DateTimeData.GetDatetime(DateTime.Now, DateTime.Now.AddDays(7)),
                            BitisZaman = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddMinutes(45), DateTime.Now.AddDays(7).AddMinutes(45)),
                            Egitmen = egitmenForSinav[rd.Next(0, egitmenForSinav.Count - 1)],
                            Ders = drs,
                            Sinif = sinifForSinav[rd.Next(0, sinifForSinav.Count - 1)]
                        });
                }
            }

            context.SaveChanges();


            List<Sinav> sinavForSoru = context.Sinav.ToList();

            foreach (Sinav snv in sinavForSoru)
            {
                for (int i = 0; i < 5; i++)
                {
                    context.Soru.Add(new Soru()
                        {
                            Icerik = FakeData.TextData.GetSentence(),
                            No = i + 1,
                            PuanDeger = FakeData.NumberData.GetNumber(0, 100),
                            Sinav = snv
                        });
                }
            }

            context.SaveChanges();


            List<Soru> soruForSecenek = context.Soru.ToList();
            string[] baslikForSecenek = new string[4] { "A", "B", "C", "D" };

            foreach (Soru sr in soruForSecenek)
            {
                for (int i = 0; i < 4; i++)
                {
                    context.Secenek.Add(new Secenek()
                        {
                            Soru = sr,
                            Baslik = baslikForSecenek[i],
                            IcerikTur = FakeData.EnumData.GetElement<SecenekTur>(),
                            Icerik = FakeData.TextData.GetSentence()
                        });
                }
            }

            context.SaveChanges();

        }
    }
}
