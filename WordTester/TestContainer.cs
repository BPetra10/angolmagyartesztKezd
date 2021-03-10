using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTester
{
    public class TestContainer
    {
        List<String> wordsPair;
        List<String> RNDwordsPair;

        public TestContainer(String fileName)
        {
            //kivételkezelés - állomány nem létezik?
            try
            {
                wordsPair = File.ReadAllLines(fileName).ToList();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException($"A kapott {fileName} teszt nem létezik!");
            }
        }

        public int Count => wordsPair.Count;

        /// <summary>
        /// A teljes szólistából adja vissza az angol szót
        /// </summary>
        /// <param name="n">A szó sorszáma. Számozás 0-tól indul</param>
        /// <returns>Angol szó</returns>
        public String GetWordUK(int n)
        {
            return wordsPair[n].Split(';')[0];
        }


        /// <summary>
        /// A teljes szólistából adja vissza a magyar szót
        /// </summary>
        /// <param name="n">A szó sorszáma. Számozás 0-tól indul</param>
        /// <returns>Magyar szó</returns>
        public String GetWordHU(int n)
        {
            return wordsPair[n].Split(';')[1];
        }
        /// <summary>
        /// Létrehoz egy véletlenszerű szólistát
        /// </summary>
        /// <param name="percent">Az eredeti lista hány %-a kerüljön a listába</param>
        public void DoRandomListPercent(double percent)
        {
            //Hibavizsgálat!!!
            DoRandomListNumber((int)(Math.Round(wordsPair.Count * percent / 100d)));
        }
        /// <summary>
        /// Létrehoz egy véletlenszerű szólistát
        /// </summary>
        /// <param name="num">Hány szó kerüljön bele?</param>
        public void DoRandomListNumber(int num)
        {
            //Hibavizsgálat!!!
            Random rnd = new Random();
            RNDwordsPair = new List<string>();
            List<String> temp = wordsPair.Select(s => s).ToList();

            for (int i = 0; i < num; i++)
            {
                int tempRND = rnd.Next(temp.Count);
                RNDwordsPair.Add(temp[tempRND]);
                temp.RemoveAt(tempRND);
            }
        }
        /// <summary>
        /// A véletlenszerűen leszűkített szólistából adja vissza az angol szót
        /// </summary>
        /// <param name="n">A szó sorszáma. Számozás 0-tól indul</param>
        /// <returns>Angol szó</returns>
        public String GetRandomWordUK(int n)
        {
            return RNDwordsPair[n].Split(';')[0];
        }
        /// <summary>
        /// A véletlenszerűen leszűkített szólistából adja vissza a magyar szót
        /// </summary>
        /// <param name="n">A szó sorszáma. Számozás 0-tól indul</param>
        /// <returns>Magyar szó</returns>
        public String GetRandomWordHU(int n)
        {
            return RNDwordsPair[n].Split(';')[1];
        }

        public int RandomCount => RNDwordsPair.Count;

    }
}
