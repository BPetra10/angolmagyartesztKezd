using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTester
{
    class TestContainer
    {
        List<String> wordsPair;

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
        public String this[int n] { get => wordsPair[n]; }
        public String GetWordUK(int n)
        {
            return wordsPair[n].Split(';')[0];
        }
        public String GetWordHU(int n)
        {
            return wordsPair[n].Split(';')[1];
        }
    }
}
