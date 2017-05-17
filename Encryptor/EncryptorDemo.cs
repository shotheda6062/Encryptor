using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    class EncryptorDemo
    {
        static void Main()
        {
            Encrypt e = new Encrypt();
            System.Console.WriteLine("e: " + e.Code);

            string s1 = "There is no spoon.";
            System.Console.WriteLine(s1);
            string s2 = e.toEncode(s1);
            System.Console.WriteLine(s2);
            string s3 = e.toDecode(s2);
            System.Console.WriteLine(s3);
            Console.Read();
        }

    }

}

