using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    class Kocka
    {
        /// <summary>
        /// Generator nahodnych cisel
        /// </summary>
        private Random random;
        /// <summary>
        /// Pocet stran kocky
        /// </summary>
        private int pocetStran;

        public Kocka()
        {
            pocetStran = 6;
            random = new Random();
        }
        public Kocka(int pocetStran)
        {
            this.pocetStran = pocetStran;
            random = new Random();
        }
        /// <summary>
        /// Sluzi na citanie poctu stien koncky
        /// </summary>
        /// <returns>pocet stien kocky</returns>
        public int VraciaPocetStien()
        {
            return pocetStran;
        }
        /// <summary>
        /// Hod kockou
        /// </summary>
        /// <returns>Vracia hodnotu od 1 po pocet stran kocky</returns>
        public int Hod()
        {
           return  random.Next(1, pocetStran+1);
        }
        /// <summary>
        /// Vracia textovu reprezentaciu kocky
        /// </summary>
        /// <returns>Tato kocka ma "pocetStran" stran.</returns>
        public override string ToString()
        {
            return String.Format("Tato kocka ma {0} stran.", pocetStran);
        }
    }
}
