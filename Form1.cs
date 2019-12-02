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

namespace ShlukovaAnalyza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Shluk> shluky = new List<Shluk>();
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Vykresleni bodů shluku na picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            //Projde všechny shluky v seznamu shluků
            for(int i = 0; i < shluky.Count; i++)
            {
                //Každý shluk má nastavenou svoji barvu
                SolidBrush b = new SolidBrush(shluky[i].Barva);
                //Vykreslení jednotlivých bodů shluku
                for(int j = 0; j < shluky[i].PocetBodu(); j++)
                {
                    //Vyplnění barvou
                    g.FillRectangle(b, shluky[i].body[j].X, shluky[i].body[j].Y, 10, 10);
                    //Obkreslení vzniklého čtverečku černým okrajem
                    g.DrawRectangle(Pens.Black, shluky[i].body[j].X, shluky[i].body[j].Y, 10, 10);
                }
            }
        }

        private void label_count_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Otevře uživatelem vybraný soubor. A načte z něho body.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_soubor_Click(object sender, EventArgs e)
        {
            //Otevření okna na vyhledávání souboru
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) //Když si uživatel vybere
            {
                //Začne se číst vybraný soubor
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    Random rnd = new Random();
                    //První řádek je vždy ve formátu: "count=XX". Proto prvních 6 symbolů odstraníme a necháme si jen číslo
                    string radek = sr.ReadLine();
                    radek = radek.Remove(0, 6);
                    //To potom převedeme na int
                    int pocet = int.Parse(radek);
                    label_count.Text = ("Počáteční počet shluků: " + pocet);

                    //Vyčištění seznamu shluků
                    shluky.Clear(); 
                    //Přidání nových shluků do seznamu
                    for (int i = 0; i < pocet; i++)
                    {
                        radek = sr.ReadLine(); //Data jsou ve formátu X Y Z. (x = id, Y = x souřadnice, Z = y souřadnice)
                        string[] udaje = radek.Split(' ');
                        //Přidání shluku do seznamu shluků a přidání bodu tomu shluku
                        shluky.Add(new Shluk(new Bod(int.Parse(udaje[1]), int.Parse(udaje[2]), int.Parse(udaje[0])), i, rnd));
                    }
                    //Překreslení pictureboxu
                    this.canvas.Invalidate();
                }

            }
        }

        private void canvas_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        /// <summary>
        /// Vytvoří náhodné jednoprvkové shluky
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_random_Click(object sender, EventArgs e)
        {
            //Počet shluků k vytvoření
            int pocet = (int)number_random.Value;
            label_count.Text = ("Počáteční počet shluků: " + pocet);
            //Vyčištění seznamu
            shluky.Clear();
            //Přidání nových prvků do seznamu
            for (int i = 0; i < pocet; i++)
            {
                shluky.Add(new Shluk(new Bod( rnd.Next(460), rnd.Next(460), i), i, rnd));
            }
            
            //překreslení pictureboxu
            this.canvas.Invalidate();
        }

        private void Shlukuj(Shluk shluk1, Shluk shluk2, int shlukIndex1, int shlukIndex2)
        {
            //Nalezení dvou nejbližších shluků
            int minimum = 99999;
            for (int i = 0; i < shluky.Count; i++)
            {
                for (int j = 0; j < shluky.Count; j++)
                {
                    if (j == i) //Podmínka aby se nekotroloval shluk sám se sebou
                        continue;
                    //Pokud se našel nový nejbližší pár
                    if (Shluk.VzdalenostShluku(shluky[i], shluky[j]) < minimum)
                    {
                        //Uloží se které shluky jsou sobě nejbližší
                        minimum = Shluk.VzdalenostShluku(shluky[i], shluky[j]);
                        shluk1 = shluky[i];
                        shluk2 = shluky[j];
                        shlukIndex1 = i;
                        shlukIndex2 = j;
                    }
                }
            }

            //Teď mám nalezené dva blízké shluky. Tak je spojím
            shluk1 = Shluk.SpojShluky(shluk1, shluk2);
            shluky[shlukIndex1] = shluk1;
            //ten druhý smažu
            shluky.RemoveAt(shlukIndex2);
        }

        private void button_start_Click(object sender, EventArgs e)
        {  
                Shluk shluk1 = null, shluk2 = null;
                int shlukIndex1 = 0, shlukIndex2 = 0;
                //Cykl se bude opakovat tak dlouho dokud se počet shluků nezredukuje na zadaný počet
                while (shluky.Count != (int)number_final.Value)
                {
                    //Kontrola jestli nejsou zadány špatné parametry či cokoliv.
                    //Po metodě "shlukuj" se má počet shluků zmenšit.
                    //Pokud se nezmenší něco nefunguje a potřeba přerušit program
                    int velikostPredShlukem = shluky.Count; //Velikost před sloučením dvou shluků
                    int velikostPoShluku = 0;

                    Shlukuj(shluk1, shluk2, shlukIndex1, shlukIndex2);

                    velikostPoShluku = shluky.Count(); //Velikost po sloučení

                    if (velikostPoShluku == velikostPredShlukem) //Pokud se velikosti rovnají => něco se posralo
                        break;
                }
                //Poté co je hotovo se překreslí picture box
                canvas.Invalidate();
        }

        private void checkBox_krokovat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_krokovat.Checked)
                button_krok.Enabled = true;
            else
                button_krok.Enabled = false;
        }

        private void button_krok_Click(object sender, EventArgs e)
        {
            if(checkBox_krokovat.Checked)
            { 
                Shluk shluk1 = null, shluk2 = null;
                int shlukIndex1 = 0, shlukIndex2 = 0;
                if (shluky.Count != (int)number_final.Value)
                {
                     Shlukuj(shluk1, shluk2, shlukIndex1, shlukIndex2);
                }
                //Poté co je hotovo se překreslí picture box
                canvas.Invalidate();
            }

        }
    }
}
