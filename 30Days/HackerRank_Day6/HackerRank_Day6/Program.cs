using System;

namespace HackerRank_Day6 {
    class Program {
        static void Main(string[] args) {

            
            //used to store how many strings will be entered
            int noStrings = Convert.ToInt32(Console.ReadLine());

            //an array of all the inputs
            string[] inputs = new string[noStrings];


            //loops through the amount of strings
            for (int i = 0; i < noStrings; i++)

                //takes each string input
                inputs[i] = Console.ReadLine();
            

            //loops through the amount of strings
            for (int i = 0; i < noStrings; i++) {

                //loops through each even letter in the current string
                for (int j = 0; j < inputs[i].Length; j+= 2) {

                    //outputs each of the 
                    Console.Write(inputs[i].Substring(j, 1));


                }
                Console.Write(" ");
                //loops through each odd letter in the current string
                for (int j = 1; j < inputs[i].Length; j += 2) {

                    //outputs each of the 
                    Console.Write(inputs[i].Substring(j, 1));


                }

                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
