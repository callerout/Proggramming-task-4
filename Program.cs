using System;
using System.Threading;
using System.Collections.Generic;

namespace Proggramming_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Input();
        }

        public static void Input()
        {
            Console.WriteLine("Enter a string");
            string message = Console.ReadLine();
            string key = ("1001101");
            int asciiconv = 1;
            List<string> Ascii = new List<string>();
            List<string> keys = new List<string>();
            //char[] Ascii = new char[key.Length];
            //char[] keys = key.ToCharArray();
            string ans = "";
            string final = "";
            string binary = "";
            
            foreach (char i in message)
            { 
                asciiconv = i;
                binary = Convert.ToString(asciiconv, 2);
                //Console.WriteLine(binary);
                Ascii.Add (binary);
                keys.Add(key);
                //int l = 4;
            }

            //foreach (string n in Ascii)
            //{
                //Console.WriteLine(n);
            //}
            int l = 4;

            for (int x = 0; x < l ; x++)
            {
                if (Ascii[x] == keys[x])
                {
                    ans += "0";
                }
                else
                {
                    ans += "1";
                }

                foreach (var a in ans)
                { 
                    final = Convert.ToString(ans);
                }

                Console.WriteLine(final);
                
            }
            
            
            
            
        }
    }
}