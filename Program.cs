using System;

namespace midexam009 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Narumon Khanopthammakun 65120501009");
            Console.WriteLine("****************************************");
            Console.WriteLine("Please fill in Order");

            Console.Write("Input Day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Input Time ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Input menu: ");
            string menu = Console.ReadLine();

            int b = day/5;
            day = day - b * 5;
            int w = day/2;
            day = day - w * 2;
            int c = day/3;
            day = day - c * 3;
            

            if ((time >= 8 && time <= 18) && (day >= 1 && day <= 7) && (b >= 0 && b <= 5) && (w >= 0 && w <= 2) && (c >= 0 && c <= 3)) {

                if (menu == "Breakfast Set" || menu == "Weekend Set" || menu == "Coffee") {
                    switch (menu)
                    {
                        case "Breakfast Set" :           
                            if (time > 11 || b == 0) {
                                Console.WriteLine("Sorry your order is not available"); 
                            } else {
                                Console.WriteLine("Sorry your order is out of stock"); 
                            }

                        break;

                        case "Weekend Set" :
                            if ((day == 1 || day == 2 || day == 3 || day == 4 || day == 5) || w == 0 ) {
                                    Console.WriteLine("True");
                            } else {
                            Console.WriteLine("Sorry your order is out of stock"); }

                        break;

                        case "Coffee" :
                            if (c == 0) {
                                Console.WriteLine("Sorry your order is out of stock");}

                        break;
                    }
                } else {
                     Console.WriteLine("Please enter a valid menu"); }
                }
                Console.WriteLine("Sorry your order is out of stock"); }
        }
    }