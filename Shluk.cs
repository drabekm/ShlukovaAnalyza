using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShlukovaAnalyza
{
    class Shluk
    {
        public List<Bod> body = new List<Bod>();
        private int id;
        private Color barva;
        
        public Color Barva
        {
            get{ return barva; }
        }

        /// <summary>
        /// Vytvoří jednoprvkový shluk.
        /// </summary>
        /// <param name="bod">Shluk pro vytvoření potřebuje alespoň jeden prvek který pak bude obsahovat</param>
        /// <param name="id">Každý shluk má svoje unikátní id. Ikdyž se nekontroluje jestli je unikátní</param>
        /// <param name="rnd">Každý shluk má svoji barvu. Ta se vytváří náhodně a potřebuje proto poskytnout třídu random</param>
        public Shluk(Bod bod, int id, Random rnd)
        {
            barva = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            body.Add(bod);
            this.id = id;
        }

        /// <summary>
        /// Vypíše na konzolu všechny body které shluk obsahuje. Spíš hlavně pro debug
        /// </summary>
        public void VypisBody()
        {
            Console.WriteLine("Shluk {0}:", this.id); //Označení který shluk se zrovna vypisuje
            for(int i = 0; i < body.Count; i++)
            {
                Console.WriteLine("Bod[{0}]:  [{1}] [{2}]", body[i].Id, body[i].X, body[i].Y); //Informace o bodu
            }
        }


        /// <summary>
        /// Vypočítá vzdálenost dvou shluků. Nejmenší vzdálenost mezi body obou shluků se bere jako vzdálenost dvou shluků.
        /// </summary>
        /// <param name="shluk1">První shluk</param>
        /// <param name="shluk2">Druhý shluk</param>
        /// <returns></returns>
        public static int VzdalenostShluku(Shluk shluk1, Shluk shluk2)
        {
            if (shluk1 == null || shluk2 == null)
                return -1;

            int nejmensiVzdalenost = 99999;
            int soucasnaVzdalenost = nejmensiVzdalenost;
            for(int i = 0; i < shluk1.body.Count; i++) //Procházení bodů ze shluku 1
            {
                for (int j = 0; j < shluk2.body.Count; j++) //procházení bodů ze shluku 2
                {
                    //Vypočítá se vzdálenost a popřípadě se uloží
                    soucasnaVzdalenost = Bod.VypoctiVzdalenost(shluk1.body[i], shluk2.body[j]); 
                    if (soucasnaVzdalenost < nejmensiVzdalenost)
                        nejmensiVzdalenost = soucasnaVzdalenost;
                }
            }

            return nejmensiVzdalenost;
        }

        /// <summary>
        /// Vrátí počet bodů ve shluku
        /// </summary>
        /// <returns></returns>
        public int PocetBodu()
        {
            return body.Count;
        }

        public static Shluk SpojShluky (Shluk shluk1, Shluk shluk2)
        {
            if (shluk1 == null || shluk2 == null)
                return null;
            for(int i = 0; i < shluk2.PocetBodu(); i++)
            {
                shluk1.body.Add(shluk2.body[i]);
            }
            shluk2 = null;
            return shluk1;
        }
    }
}
