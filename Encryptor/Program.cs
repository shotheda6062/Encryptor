using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    class Program
    {
        class Encrypt
        {
            public string cArray;

            public void setArray()
            {
                Random rand = new Random();
                int a = rand.Next(1, 10);
                int b = rand.Next(1, 10);

                int x, y, m;

                char c = 'a';

                int i;

                System.Text.StringBuilder s = new System.Text.StringBuilder();

                for (i = 0; i< 26; i++)
                {
                    x = c;
                    y = x * a + b;
                    m = y % 26;
                    s.Append((char)(m + 97));
                    c++;
                }

                this.cArray = s.ToString();
            }
        }
        static void Main(string[] args)
        {
            Encrypt e = new Encrypt();
            e.setArray();
            System.Console.WriteLine("e: " + e.cArray);
            Console.Read();

        }
    }
}
