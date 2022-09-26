using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzikDosyam_Prolab3
{
    class Vt
    {
        public static Entities db = new Entities();
        public static string[] UlkeGetir()
        {
            string[] ulkeler = new string[db.Ulkeler.Count()];
            int i = 0;
            foreach (Ulke ulke in db.Ulkeler)
            {
                ulkeler[i] = ulke.Id + "-" + ulke.UlkeAdi;
                i++;
            }
            return ulkeler;
        }
        public static string[] AbonelikGetir()
        {
            string[] abonelikler = new string[db.Abonelikler.Count()];
            int i = 0;
            foreach (Abonelik abonelik in db.Abonelikler)
            {
                abonelikler[i] = abonelik.Id + "-" + abonelik.AbonelikTuru;
                i++;
            }
            return abonelikler;
        }
        public static string[] SanatciGetir()
        {
            string[] sanatcilar = new string[db.Sanatcilar.Count()];
            int i = 0;
            foreach (Sanatci sanatci in db.Sanatcilar)
            {
                sanatcilar[i] = sanatci.Id + "-" + sanatci.Adi + " " + sanatci.Soyadi;
                i++;
            }
            return sanatcilar;
        }
        public static string[] TurGetir()
        {
            string[] turler = new string[db.Turler.Count()];
            int i = 0;
            foreach (Tur tur in db.Turler)
            {
                turler[i] = tur.Id + "-" + tur.TurAdi;
                i++;
            }
            return turler;
        }
        public static string[] SarkiGetir(int turID)
        {
            string[] sarkilar = new string[db.Sarkilar.Where(sarki => sarki.TurID == turID).ToList().Count()];
            int i = 0;
            foreach (Sarki sarki in db.Sarkilar.Where(x => x.TurID == turID).ToList())
            {
                sarkilar[i] = sarki.SarkiID + "-" + sarki.Adi;
                i++;
            }
            return sarkilar;
        }
        public static string[] SanatciSarkisiGetir(int sanatciID)
        {
            string[] sarkilar = new string[db.Sarkilar.Where(x => x.SanatciID == sanatciID).ToList().Count()];
            int i = 0;
            foreach (Sarki sarki in db.Sarkilar.Where(x => x.SanatciID == sanatciID).ToList())
            {
                sarkilar[i] = sarki.SarkiID + "-" + sarki.Adi;
                i++;
            }
            return sarkilar;
        }
        public static string[] SarkiGetir()
        {
            string[] sarkilar = new string[db.Sarkilar.Count()];
            int i = 0;
            foreach (Sarki sarki in db.Sarkilar)
            {
                sarkilar[i] = sarki.SarkiID + "-" + sarki.Adi;
                i++;
            }
            return sarkilar;
        }
    }
}
