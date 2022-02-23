using System;


namespace Fatai {
    class Program {
        static void Main(string[] args) {
            int i = 4;
            double d = 4.0;
            string s = "Polyilaro ";

            Console.Write("Enter a second integer: ");
            int sec_int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second double: ");
            double sec_double = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a second string: ");
            string sec_str = Console.ReadLine();

            Console.WriteLine(i + sec_int);
            Console.WriteLine(d + sec_double);
            Console.WriteLine(s + sec_str);

        }
    }
}
