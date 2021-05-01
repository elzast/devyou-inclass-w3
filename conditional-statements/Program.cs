using System;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {

            //ex 1
            int age = 22;
            if (age >= 21)
            {
                Console.WriteLine("You may enter.");
            }
            else if (age <= 21)
            {
                Console.WriteLine("You may not enter");
            }
            else if (age == 21)
            {
                Console.WriteLine("You are exactly the right age");
            }
            else 
            {
                Console.WriteLine("You are either older than 21 or younger than 21.");
            }



            //ex 2
            Console.WriteLine("Enter your age");
            int age2 = int.Parse(Console.ReadLine());
            if (age2 >= 18)
            {
                Console.WriteLine("Admission is $20");
            }
            else { Console.WriteLine("Admission is $10"); }

            //ex 3
            int creditScore = 650;

            if (creditScore > 400 && creditScore < 600)
            {
                Console.WriteLine("Credit is bad");
            }
            else if (creditScore >= 600 && creditScore < 700)
            {
                Console.WriteLine("Credit is average");

            }
            else if (creditScore >= 700 && creditScore < 800) {
                Console.WriteLine("Credit is good");
            }
            else if (creditScore > 800)
            {
                Console.WriteLine("Credit is great");

            }
            else
            {
                Console.WriteLine("You need to work on your credit");
            }










            //ex 4
            Console.WriteLine("Choose a quote: inspirational, morning, or funny.");
            string quote = Console.ReadLine().ToLower();
            

            switch (quote)
            {
                case "inspirational":
                    Console.WriteLine("Be yourself; everyone else is already taken.");
                    break;
                case "morning":
                    Console.WriteLine("The early bird gets the worm");
                    break;
                case "funny":
                    Console.WriteLine("Before you judge a man, walk a mile in his shoes. After that who cares?... He's a mile away and you've got his shoes!");
                    break;
                default:
                    Console.WriteLine("We can only handle Funny, Morning and Inspirational quotes");
                    break;
            }
        }
    }
}
// code snippet example
//        Console.WriteLine("What is your name?");
//        string name = Console.ReadLine();

//        Console.WriteLine("What is your age?");
//        int age = int.Parse(Console.ReadLine());

//        if (age >= 21)
//        {
//            Console.WriteLine("You are legal in the state of Michigan.");

//            Console.WriteLine($"How many bottles of adult beverages would you like {name}?");
//            int amountOfDrink = int.Parse(Console.ReadLine());

//            double totalPrice = amountOfDrink * 1.99;
//            Console.WriteLine($"You owe: {totalPrice:C}");
//        }


//    else
//        {
//            Console.WriteLine($"You are not legal and not permitted to buy these beverages. Goodbye {name}.");
//        }


//Console.WriteLine("Press ENTER to Exit");
//        Console.ReadLine();
//    }


//}
//}
