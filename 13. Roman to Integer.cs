using System;

namespace Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your roman to integer number: ");
                string s = Console.ReadLine();
                if (s == null)
                {
                    s = "null";
                }
                int result = Roman_to_Integer(s);
                Console.WriteLine("{0} = {1}", s, result);
            }
            static int Roman_to_Integer(string s)
            {
                char[] characters = s.ToCharArray();
                int result = 0;
                for (int i = 0; i < characters.Length; i++)
                {
                    if (characters[i] == 'I')
                    {
                        result += 1;
                    }
                    else if (characters[i] == 'V')
                    {
                        result += 5;
                    }
                    else if (characters[i] == 'X')
                    {
                        result += 10;
                    }
                    else if (characters[i] == 'L')
                    {
                        result += 50;
                    }
                    else if (characters[i] == 'C')
                    {
                        result += 100;
                    }
                    else if (characters[i] == 'D')
                    {
                        result += 500;
                    }
                    else if (characters[i] == 'M')
                    {
                        result += 1000;
                    }
                }
                int _i;
                for (int i = 0; i < characters.Length; i++)
                {
                    _i = i;
                    _i++;
                    if (_i < characters.Length && characters[i] == 'C' && characters[_i] == 'M')
                    {
                        result -= 200;
                    }
                    if (_i < characters.Length && characters[i] == 'X' && characters[_i] == 'L')
                    {
                        result -= 20;
                    }
                    if (_i < characters.Length && characters[i] == 'X' && characters[_i] == 'C')
                    {
                        result -= 20;
                    }
                    if (_i < characters.Length && characters[i] == 'C' && characters[_i] == 'D')
                    {
                        result -= 200;
                    }
                    if (_i < characters.Length && characters[i] == 'I' && characters[_i] == 'X')
                    {
                        result -= 2;
                    }
                    if (_i < characters.Length && characters[i] == 'I' && characters[_i] == 'V')
                    {
                        result -= 2;
                    }
                }
                return result;
            }
        }
    }
}