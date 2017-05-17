using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    class Encrypt
    {
        private string cArray;

        public string Code
        {
            get { return cArray; }
            set
            {
                if (value is string && value.Length == 26)
                {
                    cArray = value;
                }
                else
                {
                    System.Console.WriteLine("something worng!!"); ;
                }
            }
        }

        public Encrypt()
        {
            System.Random r = new System.Random();
            int a = 0;
            int b = 0;
            // 限定 a 為偶數
            while (a % 2 == 0)
            {
                a = r.Next(1, 10);
                b = r.Next(1, 10);
            }
            System.Console.Write("a: " + a + ", b: " + b + ", ");

            int x, y, m;
            char c = 'a';
            int i;
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            for (i = 0; i < 26; i++)
            {
                x = c;
                y = x * a + b;
                m = y % 26;
                s.Append((char)(m + 97));
                c++;
            }

            this.cArray = s.ToString();
        }

        public string toEncode(string s)
        {
            System.Text.StringBuilder r = new System.Text.StringBuilder();

            // 進行編碼轉換
            char c;
            int i, m;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] >= 97 && s[i] <= 122)
                {
                    c = s[i];
                    m = c - 97;
                    r.Append(this.Code[m]);
                }
                else
                {
                    r.Append(s[i]);
                }
            }

            // 回傳字串
            return r.ToString();
        }

        public string toDecode(string s)
        {
            System.Text.StringBuilder r = new System.Text.StringBuilder();

            // 進行解碼的工作
            int i, j;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] >= 97 && s[i] <= 122)
                {
                    // 找出表格中對應的索引值
                    for (j = 0; j < 26; j++)
                    {
                        if (s[i] == this.Code[j])
                        {
                            r.Append((char)(j + 97));
                            break;
                        }
                    }
                }
                else
                {
                    r.Append(s[i]);
                }
            }

            return r.ToString();
        }
    }
}
