namespace app6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part1

            //Q1
            //            using System;

            //class PersonClass
            //        {
            //            public string Name;
            //        }

            //        struct PersonStruct
            //        {
            //            public string Name;
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                // Class Example
            //                PersonClass p1 = new PersonClass();
            //                p1.Name = "Mariam";

            //                PersonClass p2 = p1;
            //                p2.Name = "Ahmed";

            //                Console.WriteLine("Class Output: " + p1.Name);
            //                // Ahmed → لأنه Reference Type

            //                // Struct Example
            //                PersonStruct s1;
            //                s1.Name = "Mariam";

            //                PersonStruct s2 = s1;
            //                s2.Name = "Ahmed";

            //                Console.WriteLine("Struct Output: " + s1.Name);
            //                // Mariam → لأنه Value Type
            //            }
            //        }








            //Q2


            //            using System;

            //class Student
            //        {
            //            public string Name;        // Accessible anywhere
            //            private int Age;           // Hidden

            //            public void SetAge(int age)
            //            {
            //                Age = age;
            //            }

            //            public void ShowData()
            //            {
            //                Console.WriteLine("Name: " + Name);
            //                Console.WriteLine("Age: " + Age);
            //            }
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                Student s = new Student();
            //                s.Name = "Mariam";     // allowed

            //                // s.Age = 20; ❌ Error لأنه private

            //                s.SetAge(20);
            //                s.ShowData();
            //            }
            //        }





            // part2




//            using System;

//namespace MovieBookingSystem
//    {
//        // 1️⃣ Enum for Ticket Type
//        enum TicketType
//        {
//            Standard = 0,
//            VIP = 1,
//            IMAX = 2
//        }

//        // 2️⃣ Struct for Seat Location
//        struct Seat
//        {
//            public char Row;
//            public int Number;

//            public Seat(char row, int number)
//            {
//                Row = row;
//                Number = number;
//            }

//            public override string ToString()
//            {
//                return $"{Row}{Number}";
//            }
//        }

//        // 3️⃣ Ticket Class
//        class Ticket
//        {
//            public string MovieName { get; set; }
//            public TicketType Type { get; set; }
//            public Seat Seat { get; set; }

//            private double Price;

//            // 🔹 Main Constructor
//            public Ticket(string movieName, TicketType type, Seat seat, double price)
//            {
//                MovieName = movieName;
//                Type = type;
//                Seat = seat;
//                Price = price;
//            }

//            // 🔹 Overloaded Constructor (Default values without repeating logic)
//            public Ticket(string movieName)
//                : this(movieName, TicketType.Standard, new Seat('A', 1), 50)
//            {
//            }

//            // 4️⃣ Method: Calculate Total with Tax
//            public double CalcTotal(double taxPercent)
//            {
//                double total = Price + (Price * taxPercent / 100);
//                return total;
//            }

//            // 4️⃣ Method: Apply Discount
//            public void ApplyDiscount(ref double discountAmount)
//            {
//                if (discountAmount > 0 && discountAmount <= Price)
//                {
//                    Price -= discountAmount;
//                    discountAmount = 0; // consumed
//                }
//            }

//            // 4️⃣ Method: Print Ticket Info
//            public void PrintTicket()
//            {
//                Console.WriteLine("Movie  : " + MovieName);
//                Console.WriteLine("Type   : " + Type);
//                Console.WriteLine("Seat   : " + Seat);
//                Console.WriteLine("Price  : " + Price.ToString("F2"));
//            }
//        }

//        class Program
//        {
//            static void Main(string[] args)
//            {
//                Console.Write("Enter Movie Name: ");
//                string movie = Console.ReadLine();

//                Console.Write("Enter Ticket Type (0 = Standard, 1 = VIP, 2 = IMAX): ");
//                int typeInput = int.Parse(Console.ReadLine());
//                TicketType type = (TicketType)typeInput;

//                Console.Write("Enter Seat Row (A, B, C...): ");
//                char row = char.Parse(Console.ReadLine());

//                Console.Write("Enter Seat Number: ");
//                int number = int.Parse(Console.ReadLine());

//                Console.Write("Enter Price: ");
//                double price = double.Parse(Console.ReadLine());

//                Console.Write("Enter Discount Amount: ");
//                double discount = double.Parse(Console.ReadLine());

//                // Create Seat
//                Seat seat = new Seat(row, number);

//                // Create Ticket
//                Ticket ticket = new Ticket(movie, type, seat, price);

//                Console.WriteLine("\n===== Ticket Info =====");
//                ticket.PrintTicket();

//                double total = ticket.CalcTotal(14);
//                Console.WriteLine("Total (14% tax): " + total.ToString("F2"));

//                Console.WriteLine("\n===== After Discount =====");
//                Console.WriteLine("Discount Before: " + discount.ToString("F2"));

//                ticket.ApplyDiscount(ref discount);

//                Console.WriteLine("Discount After : " + discount.ToString("F2"));
//                ticket.PrintTicket();

//                Console.ReadKey();
//            }
//        }
//    }



}
}
}
