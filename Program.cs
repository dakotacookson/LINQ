using System;
using System.Collections.Generic;
using System.Linq;

namespace linq {

    public class Custmer {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }
    public class BankReport {
        public string BankName { get; set; }
        public int BankNumber { get; set; }
    }
    public class Program {
        // Find the words in the collection that start with the letter 'L'

        public static void Main () {

            List<int> wheresSquaredo = new List<int> () {
                66,
                12,
                8,
                27,
                82,
                34,
                7,
                50,
                19,
                46,
                81,
                23,
                30,
                4,
                68,
                14
            };
            IEnumerable<int> wheresSquaredo2 = wheresSquaredo.Where (wheresSquared => wheresSquared * 2 == wheresSquared * 2);
            foreach (var squeare in wheresSquaredo2) {
                Console.WriteLine (squeare);
            }

            List<double> prices = new List<double> () {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };

            Console.WriteLine (prices.Max ());
            Console.WriteLine ("-----------------------------------------------------");

            List<double> purchases = new List<double> () {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };
            Console.WriteLine (purchases.Sum ());
            Console.WriteLine ("-----------------------------------------------------");

            List<int> numbers = new List<int> () {

                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96

            };
            IEnumerable<int> fourMultiples = numbers.Where (number => number % 4 == 0);
            IEnumerable<int> SixMultiples = numbers.Where (number => number % 6 == 0);
            foreach (var numberset2 in fourMultiples) {
                Console.WriteLine (numberset2);

            }
            Console.WriteLine ("-----------------------------------------------------");
            foreach (var numberset3 in SixMultiples) {
                Console.WriteLine (numberset3);

            }
            Console.WriteLine ("-----------------------------------------------------");
            foreach (var numberset in numbers) {
                Console.WriteLine (numberset);
            }
            Console.WriteLine ("-----------------------------------------------------");

            Console.WriteLine (numbers.LongCount ());
            Console.WriteLine ("-----------------------------------------------------");

            List<string> fruits = new List<string> () { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
            where fruit.Contains ("L")
            orderby fruit ascending
            select fruit;
            foreach (var fruitiy in LFruits) {
                Console.WriteLine (fruitiy);
            }
            Console.WriteLine ("-----------------------------------------------------");
            List<string> names = new List<string> () {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            List<Custmer> customers = new List<Custmer> () {
                new Custmer () { Name = "Bob Lesman", Balance = 80345.66, Bank = "FTB" },
                new Custmer () { Name = "Joe Landy", Balance = 9284756.21, Bank = "WF" },
                new Custmer () { Name = "Meg Ford", Balance = 487233.01, Bank = "BOA" },
                new Custmer () { Name = "Peg Vale", Balance = 7001449.92, Bank = "BOA" },
                new Custmer () { Name = "Mike Johnson", Balance = 790872.12, Bank = "WF" },
                new Custmer () { Name = "Les Paul", Balance = 8374892.54, Bank = "WF" },
                new Custmer () { Name = "Sid Crosby", Balance = 957436.39, Bank = "FTB" },
                new Custmer () { Name = "Sarah Ng", Balance = 56562389.85, Bank = "FTB" },
                new Custmer () { Name = "Tina Fey", Balance = 1000000.00, Bank = "CITI" },
                new Custmer () { Name = "Sid Brown", Balance = 49582.68, Bank = "CITI" }
            };

            IEnumerable<BankReport> millionaireReport = (from customer in customers where customer.Balance >= 1000000 group customer by customer.Bank into customerGroup select new BankReport {
                BankName = customerGroup.Key,
                    BankNumber = customerGroup.Count (m => m.Bank == customerGroup.Key)
            }).ToList ();

            Console.WriteLine ("---------------------");
            Console.WriteLine ($"List of milionaires per bank ");

            foreach (BankReport b in millionaireReport) {
                Console.WriteLine ($"{b.BankName}  {b.BankNumber}");
            }

        }
    }
}