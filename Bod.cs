using System;

namespace ShlukovaAnalyza
{
    class Bod
    {
        private int x,y;
        private int id;

        /// <summary>
        /// Vytvoří bod se 2D souřadníci a unikátním ID
        /// </summary>
        /// <param name="x">X souřadnice</param>
        /// <param name="y">Y souřadnice</param>
        /// <param name="id">Unikátní id bodu. ÁÁÁle stejně nikdo nekontroluje jestli je unikatni </param>
        public Bod(int x, int y, int id)
        {
            this.x = x;
            this.y = y;
            this.id = id;
        }

        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public int Id
        {
            get { return id; }
        }

        /// <summary>
        /// Vypočítá vzdálenost dvou bodů
        /// </summary>
        /// <param name="bod1">První bod</param>
        /// <param name="bod2">Druhý bod</param>
        /// <returns></returns>
        public static int VypoctiVzdalenost(Bod bod1, Bod bod2)
        {
            //Kontrola jestli body existují
            if (bod1 == null || bod2 == null)
            {
                return -1;
            }

            //Vzorec na výpočet vzdálenost dvou 2D bodů
            int vzdalenost = (int)Math.Sqrt(Math.Pow(bod2.X - bod1.X, 2) + Math.Pow(bod2.Y - bod1.Y, 2)); 
            return vzdalenost;
        }

    }
}
