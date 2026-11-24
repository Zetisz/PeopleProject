using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleProject
{
    internal class People
    {
        private List<int> eletkorok;

        public People() {
            this.eletkorok = new List<int>();
        }

        internal void UjSzemely(int eletkor)
        {
            if (eletkor < 0)
            {
                throw new ArgumentException("Életkor nem lehet negatív");
            }

            eletkorok.Add(eletkor);
        }

        internal double AtlagEletkor(int minEletkor, int maxEletkor)
        {
            if (eletkorok.Count == 0)
            {
                throw new InvalidOperationException("Nincs személy a listában");
            }

            if (minEletkor < 0 || maxEletkor < 0 || minEletkor > maxEletkor)
            {
                throw new ArgumentException("Érvénytelen min vagy max életkor");
            }

            int osszeg = 0;
            int elemek = 0;
            foreach (var e in eletkorok)
            {
                if (e >= minEletkor && e <= maxEletkor)
                {
                    osszeg += e;
                    elemek++;
                }
            }

            return (double)osszeg / elemek;
        }

        internal string Kategoria(double atlag)
        {
            if (atlag <= 18)
            {
                return "gyermek";
            }
            else if (atlag <= 65)
            {
                return "felnott";
            }
            else
            {
                return "nyugdijas";
            }
        }
    }
}
