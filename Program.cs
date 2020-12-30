using System;
    class Program
    { 
        public class randomNumber {
            private readonly Random _random = new Random();

            public int GetranNum()
            {
                return _random.Next(1, 7);
            }
        }
        static void Main()
        {
            var gen = new randomNumber();
            string num = "";
            for (int i = 0; i < 4; i++)
                num = num + gen.GetranNum().ToString();
            int count = 0;          
            string val;
            bool check = true;
            Console.WriteLine("Your input: " + num);
            while (count < 10) {
                Console.WriteLine("Enter int: ");
                val = Console.ReadLine();
                check = true;
                for(int i = 0; i < 4; i++)
                {
                    if (String.Equals(num[i],val[i]))
                        Console.WriteLine("+ " + val[i]);
                    else if(num.Contains(val[i])) {
                        Console.WriteLine("- " + val[i]);
                        check = false;
                    }
                    else
                        check = false;
                }
                if(check) {
                    count = 11111;
                    Console.WriteLine("You win");
                }
                else if (count >= 10)
                    Console.WriteLine("You Lose");

            }         
        }
    }
