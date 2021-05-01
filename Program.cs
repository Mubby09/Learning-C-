using System;

namespace newToCsharp
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("   /|");
            //Console.WriteLine("  / |");
            //Console.WriteLine(" /  |");
            //Console.WriteLine("/___|");

            //Declaring variables
            //string characterName = "Mubarak";
            //int characterAge = 25;
            //char characterGrade = 'A';
            //float and decimal are alternatives to double but they all have their use cases
            //double characterAccountBalance = 456.97;
            //bool isMale = true;



            //Console.WriteLine("my name is " + characterName);
            //Console.WriteLine("I am " + characterAge + " years old");
            //Console.WriteLine("I got an " + characterGrade + " in the web and network services module");
            //Console.WriteLine("I am broke because I\'ve got just " + characterAccountBalance + " pounds left in my bank account");

            //Console.WriteLine("Mubarak \n Akinsola");
            //Console.WriteLine(characterName.Length);
            //Console.WriteLine(characterName.ToUpper());
            //Console.WriteLine(characterName.ToLower());



            //Returns a boolean value, True if the character is present in the string or false if the character is not present in the string
            //Console.WriteLine(characterName.Contains("M"));
            //Console.WriteLine(characterName.Contains("G"));

            //Returns the char at the index 5, NOTE that counting starts at 0
            //Console.WriteLine(characterName[5]);

            //Returns the index position of the character
            //Console.WriteLine(characterName.IndexOf("r"));

            //You get a -1 when you try to find for a  char that is not present in the string
            //Console.WriteLine(characterName.IndexOf("o"));

            //Returns the characters at index 5 and counts the next character to the index 5 as the second value. 
            //Console.WriteLine(characterName.Substring(5, 2));



            //Getting input from User (.ReadLine() allows a user to input stuff into the terminal)

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your age: ");
            //string age = Console.ReadLine();

            //Console.WriteLine("Hello " + name + " you are " + age + " years old");




            //converting a string to an integer

            //int num = Convert.ToInt32("45");
            //Console.WriteLine(num + 6 );

            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter another number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num1 * num2);

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter another number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(num1 + num2);





            //MAD LIBS

            //string color, pluralNoun, favoriteFootballer;

            //Console.Write("Enter a color: ");
            //color = Console.ReadLine();

            //Console.Write("Enter a Plural noun: ");
            //pluralNoun = Console.ReadLine();

            //Console.Write("Enter your favorite Footballer: ");
            //favoriteFootballer = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("Roses are " + color);
            //Console.WriteLine(pluralNoun + " are blue");
            //Console.WriteLine("I Love " + favoriteFootballer);


            //ARRAYS

            //creating an array of strings|| when we do not exactly what
            //elements that'll go into the array, we can simply instantiate it and give it a number,
            //...that tells C# how many elements we want the array to be abel to hold, Below we put 3,
            //...that tells C# that we will be expecting 3 friends in the array
            string[] myFriends = new string[3];
            myFriends[0] = "Mariam";
            myFriends[1] = "Zainab";
            myFriends[2] = "Yinka";
            

            //If we attempt to put in more than the specified number of elements, C# throws an Out of range error
            //myFriends[3] = "Wale";

            //create an an of integers
            int[] luckyNumbers = { 4, 7, 18, 90, 83, 2 };

            Console.WriteLine(luckyNumbers[4]);


            Console.ReadLine();
        }
    }
}
