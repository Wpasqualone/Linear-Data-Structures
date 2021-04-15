    using System;
using System.Collections;
using System.Collections.Generic;

namespace Linear_Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2
            Console.WriteLine("How many numbers would you like to input?");
            int amountOfNumbers = Int32.Parse(Console.ReadLine());
            Stack<int> integerStack = new Stack<int>();
            int input;

            for (int iteration = 0; iteration < amountOfNumbers; iteration++) 
            {
                Console.WriteLine("Number {0}: ", iteration + 1);
                input = Int32.Parse(Console.ReadLine());
                integerStack.Push(input);

            }

            string reversedString = "Your reversed list of numbers is: ";
            for (int iteration = 0; iteration < amountOfNumbers; iteration++) 
            {
                //Making sure the last number does not have a comma.
                if (iteration == amountOfNumbers - 1)
                {
                    reversedString = reversedString + integerStack.Pop();
                }
                else
                {
                    reversedString = reversedString + integerStack.Pop() + ", ";
                }

            }
            Console.WriteLine(reversedString);

            //Excersise 7
            Console.WriteLine("\nExcersise 7");

            ArrayList numbersArray = new ArrayList();
            numbersArray.Add(3);
            numbersArray.Add(4);
            numbersArray.Add(4);
            numbersArray.Add(2);
            numbersArray.Add(3);
            numbersArray.Add(3);
            numbersArray.Add(4);
            numbersArray.Add(3);
            numbersArray.Add(2);

            List<int> amountOfOccurances = new List<int>();
            for (int i = 0; i < 1001; i++)
            {
                amountOfOccurances.Add(0);
            }

            int numberAtIndex;
            for (int iteration = 0; iteration < numbersArray.Count; iteration++)
            {
                numberAtIndex = (int)numbersArray[iteration];
                amountOfOccurances[numberAtIndex] = amountOfOccurances[numberAtIndex] + 1;
            }

            for (int i = 0; i < 1001; i++)
            {
                if (amountOfOccurances[i] > 0) 
                {
                    Console.WriteLine("The number {0} occurs {1} times.", i, amountOfOccurances[i]);
                }
            }

            //Excersise 9
            Console.WriteLine("\nExcersise 9");

            Queue<int> sequenceQueue = new Queue<int>();
            Queue<int> printQueue = new Queue<int>();
            int startNum = 2;
            int currentElement = startNum;
            sequenceQueue.Enqueue(startNum);

            while (printQueue.Count < 50)
            {
                currentElement = sequenceQueue.Dequeue();
                printQueue.Enqueue(currentElement);

                sequenceQueue.Enqueue(currentElement + 1);
                sequenceQueue.Enqueue((2 * currentElement) + 1);
                sequenceQueue.Enqueue(currentElement + 2);
            }

            string outputString = "The sequence is: ";
            int queueLength = printQueue.Count;
            for (var iteration = 0; iteration < queueLength; iteration++)
            {
                if (iteration == queueLength - 1 )
                {
                    outputString = outputString + printQueue.Dequeue() ;

                }
                else
                {
                    outputString = outputString + printQueue.Dequeue() + ", ";

                }
            }
            Console.WriteLine(outputString);
           
        }
    }
}
