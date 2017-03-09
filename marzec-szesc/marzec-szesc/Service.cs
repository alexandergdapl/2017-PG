using System;

namespace marzec_szesc
{
    class Service
    {
        public void Reverse(string text)
        {            
            for (int i = text.Length-1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
        }

        public void IsPalindrom(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == text[text.Length-1]-i)
                {
                    Console.WriteLine("Tekst '{0}' jest palindromem.", text);
                    break;
                }
                else
                {
                    Console.WriteLine("Tekst '{0}' nie jest palindromem.", text);
                    break;
                }               
            }
        }

        public void EveryTwo(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                i++;
            }
        }
    }
}
