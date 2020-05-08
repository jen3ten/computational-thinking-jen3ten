using System;

namespace ComputationalThinkingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("COMPUTATIONAL THINKING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Are These Integers Equal?");
                Console.WriteLine("2. Even or Odd?");
                Console.WriteLine("3. Vowel or Consonant?");
                Console.WriteLine("4. Find the Largest Number");
                Console.WriteLine("5. Divisible by 3");
                Console.WriteLine("6. Reverse Counting");
                Console.WriteLine("7. Restaurant Bill");
                Console.WriteLine("8. Age Category");
                Console.WriteLine("9. Words to Digits");
                Console.WriteLine("10. Which Name is Longer?");
                Console.WriteLine("11. Are these Numbers the Same?");
                Console.WriteLine("12. Name and Place of Birth");
                Console.WriteLine("13. Sort the Numbers");
                Console.WriteLine("14. Shopping List");
                Console.WriteLine("15. What's the Longest Word?");
                Console.WriteLine("16. What's the Second to Last Word?");
                Console.WriteLine("17. Which Day of the Week?");
                Console.WriteLine("18. Print a Triangle");
                Console.WriteLine("19. Guess the Magic Number");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch(userChoice)
                {
                    case "1":
                        AreTheseIntegersEqual();
                        break;
                    case "2":
                        EvenOrOdd();
                        break;
                    case "3":
                        VowelOrConsonant();
                        break;
                    case "4":
                        FindLargestNumber();
                        break;
                    case "5":
                        DivisibleBy3();
                        break;
                    case "6":
                        ReverseCounting();
                        break;
                    case "7":
                        RestaurantBill();
                        break;
                    case "8":
                        AgeCategory();
                        break;
                    case "9":
                        WordsToDigits();
                        break;
                    case "10":
                        WhichNameIsLonger();
                        break;
                    case "11":
                        AreNamesSame();
                        break;
                    case "12":
                        NameAndBirthplace();
                        break;
                    case "13":
                        SortNumbers();
                        break;
                    case "14":
                        ShoppingList();
                        break;
                    case "15":
                        LongestWord();
                        break;
                    case "16":
                        SecondToLastWord();
                        break;
                    case "17":
                        WhichDayOfWeek();
                        break;
                    case "18":
                        PrintTriangle();
                        break;
                    case "19":
                        GuessMagicNumber();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void AreTheseIntegersEqual()
        {
            // Write a console application to ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here
            // Ask user for 1st integer
            Console.WriteLine("Enter an integer");

            // Save integer in a variable
            string firstInteger = Console.ReadLine();

            // Ask user for 2nd integer
            Console.WriteLine("Enter another integer");

            // Save integer in a variable
            string secondInteger = Console.ReadLine();

            // Compare the integers
            // bool isEqual = (firstInteger == secondInteger);

            // If the integers are equal, print "they are equal"
            if (firstInteger.Equals(secondInteger))
            {
                Console.WriteLine("The integers are equal!");
            }
            // If the integer are not equal, print "they are not equal"
            else
            {
                Console.WriteLine("The integers are NOT equal!");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void EvenOrOdd()
        {
            // Write a console application that asks the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here
            // Ask the user for a number
            Console.WriteLine("Enter a number");

            // Store the number in a variable
            int number = Int32.Parse(Console.ReadLine());

            // Determine if number is even or odd
            bool isEven = (number % 2 == 0);
            // Console.WriteLine(isEven);

            // If number is odd, print "odd" to console
            if(number % 2 != 0)
            {
                Console.WriteLine("This number is odd");
            }
            // If number is even, print "even" to console
            else
            {
                Console.WriteLine("This number is even");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void VowelOrConsonant()
        {
            // Write a console application to check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void FindLargestNumber()
        {
            // Write a console application that prompts the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void ReverseCounting()
        {
            // Ask the user for a number between 1-20. Starting at the number given,
            // count backwards to 1 and print the numbers to the console.

            Console.Clear();
            Console.WriteLine("REVERSE COUNTING\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void RestaurantBill()
        {
            // At a restaurant, Mike and his three friends decided to divide the bill evenly.
            // If each person paid $13 then what was the total bill?

            // Returning to the above problem, replace hard-coded values of 4(number of diners)
            // and 13(cost per diner) with values provided by the user.
            
            // How nice!The restaurant is having Customer Appreciation Week.
            // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            // Otherwise, they’ll receive a 5 % discount.

            Console.Clear();
            Console.WriteLine("RESTAURANT BILL\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AgeCategory()
        {
            // You're responsible for providing a demographic report for your local school district based on age.
            // To do this, you're going to determine which 'category' each person fits into based on their age.
            // The person's age will determine which category they should be in:

            // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
            // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
            // From 12 to 14: 'Middle School'
            // From 15 to 18: 'High School'
            // From 19 to 22: 'College'
            // From 23 to 65: 'Working for the Man'
            // From 66 to 100: 'The Golden Years'
            // If the age of the person is less than 0 or more than 100 - it might be an alien
                    // print: "This program is for humans".

            Console.Clear();
            Console.WriteLine("AGE CATEGORY\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void SortNumbers()
        {
            // Ask 10 people for their favorite numbers and create an array of those numbers.
            // Order the numbers using the sort method. Print the first and last numbers.

            Console.Clear();
            Console.WriteLine("SORT THE NUMBERS\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void ShoppingList()
        {
            // Initialize an array with 4 food items. Print this shopping list to the console.

            Console.Clear();
            Console.WriteLine("SHOPPING LIST\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void LongestWord()
        {
            // Ask the user for a phrase consisting of 1-4 words (no punctuation).
            // Print the longest word in the phrase. If 2 words have the same length, print both.

            Console.Clear();
            Console.WriteLine("WHAT'S THE LONGEST WORD?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void SecondToLastWord()
        {
            // Ask the user for a sentence or phrase consisting of at least 4 words.
            // Find the second to last word and print it.

            Console.Clear();
            Console.WriteLine("WHAT'S THE SECOND TO LAST WORD?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WhichDayOfWeek()
        {
            // Declare and initialize a string array with the 7 days of the week.
            // Print the number corresponding to each day and the day of the week. (1 = Sunday, 2 = Monday, etc.)

            // Ask the user for a number between 1 - 7.
            // Print the day of the week that corresponds to the number
            
            Console.Clear();
            Console.WriteLine("WHICH DAY OF WEEK?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void PrintTriangle()
        {
            // Ask the user for a number between 3 and 6. Print one asterisk to the screen.
            // On the next line print 2 asterisks, and continue until the users number is reached.

            Console.Clear();
            Console.WriteLine("PRINT A TRIANGLE\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void GuessMagicNumber()
        {
            // Write a console application that asks the user for an integer.
            // If that integer is evenly divisible by 3, then print “You Won!”.
            // If it isn’t, ask the user to “Try again.”
            // Keep asking them for a number (looping) until they win.

            Console.Clear();
            Console.WriteLine("GUESS THE MAGIC NUMBER\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
    }
}
