using System;

namespace Password_retry
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please choose the mode of the game and enter the corresponding number to play.");
            Console.WriteLine("1. Endless");
            Console.WriteLine("2. Easy");
            Console.WriteLine("3. Difficult");
            Console.WriteLine("4. Unfair");

            int choice = Convert.ToInt32(Console.ReadLine());

            

            string congrats = "Congratulations for guessing the right number.";
            string wrong = "Sorry the number you entered is incorrect";
            string again = "Do you want to try again? Enter 'y' for 'yes' and 'n' for 'no'.";
            

            switch (choice)
            {
                case 1:
                    {
                        Random rand = new Random();
                        int randNum = rand.Next(1, 101);

                        while (true)
                        {
                            Console.WriteLine("What do you think is the number? Please enter a number between 1 and 100.");
                            int response = Convert.ToInt32(Console.ReadLine());
                            if (response == randNum)
                            {
                                Console.WriteLine($"{congrats}");
                                break;
                            } else
                            {
                                Console.WriteLine($"{wrong}");
                                Console.WriteLine($"{again}");
                                string res = Console.ReadLine().ToLower();

                                if (res == "n")
                                {
                                    break;
                                }



                            }

                        }

                        break;
                    }

                case 2:
                    {
                        Random rand = new Random();
                        int randNum = rand.Next(1, 16);
                        

                        for (int attemptsRemaining = 10; attemptsRemaining > 0; attemptsRemaining--)
                        {
                            Console.WriteLine($"Please enter a number between 1 and 15. You can attempt {attemptsRemaining} times.");
                            int response = Convert.ToInt32(Console.ReadLine());

                            if (response == randNum)
                            {
                                Console.WriteLine($"{congrats}");
                                break;
                            } else if (attemptsRemaining > 1)
                            {
                                Console.WriteLine($"{wrong}");
                                Console.WriteLine($"{again}");
                                string res = Console.ReadLine().ToLower();

                                if (res == "n")
                                {
                                    break;
                                }



                            }
                        }

                            break;
                    }

                case 3:
                    {
                        Random rand = new Random();
                        int randNum = rand.Next(1, 51);


                        for (int attemptsRemaining = 5; attemptsRemaining > 0; attemptsRemaining--)
                        {
                            Console.WriteLine($"Please enter a number between 1 and 50. You can attempt {attemptsRemaining} times.");
                            int response = Convert.ToInt32(Console.ReadLine());

                            if (response == randNum)
                            {
                                Console.WriteLine($"{congrats}");
                                break;
                            }
                            else if (attemptsRemaining > 1)
                            {
                                Console.WriteLine($"{wrong}");
                                Console.WriteLine($"{again}");
                                string res = Console.ReadLine().ToLower();

                                if (res == "n")
                                {
                                    break;
                                }



                            }
                        }

                        break;
                    }

                case 4:
                    {
                        Random rand = new Random();
                        int randNum = rand.Next(1, 101);


                        for (int attemptsRemaining = 3; attemptsRemaining > 0; attemptsRemaining--)
                        {
                            Console.WriteLine($"Please enter a number between 1 and 100. You can attempt {attemptsRemaining} times.");
                            int response = Convert.ToInt32(Console.ReadLine());

                            if (response == randNum)
                            {
                                Console.WriteLine($"{congrats}");
                                break;
                            }
                            else if (attemptsRemaining >1)
                            {
                                Console.WriteLine($"{wrong}");
                                Console.WriteLine($"{again}");
                                string res = Console.ReadLine().ToLower();

                                if (res == "n")
                                {
                                    break;
                                }



                            }
                        }

                        break;
                    }




            }
















        }

    }
}

