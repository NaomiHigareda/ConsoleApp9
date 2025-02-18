using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a number");//prompt user to input number

            string userInput = Console.ReadLine(); //get the information user typed

            int number = Convert.ToInt32(userInput); //convert the user input to the number

            int[] numbers = new int[number];//create the array of n number integer 
            UpdateArray(numbers); //call the method to update array
            printArray(numbers);//call a method to print array
            Console.WriteLine("sum: " + calSum(numbers));
            Console.WriteLine("max: " + maxVal(numbers));
            Console.WriteLine("min: "+ minVal(numbers));
            int[] reversedArray = reverseArray(numbers);
            printArray(reversedArray);
        }
        static int[] UpdateArray(int[] aArray) //create the method to take in an array then process to update the array
        {
            for (int i = 0; i < aArray.Length; i++)//create a loop to go to every element of the array 
            {
                Console.WriteLine("Input a number for element " + i);//print a question that asks user to input a number
                aArray[i] = Convert.ToInt32(Console.ReadLine());//take in what user input the value of the element
            }
            return aArray;
        }
        static void printArray(int[] aArray)//create a method to print out all elements of array
        {
            Console.WriteLine("Here are all elements");
            for (int i = 0; i < aArray.Length; i++)//create a loop to go to every element of the array 
            {
                Console.WriteLine(aArray[i]);
            }

        }
        static int calSum(int[] aArray) //create the method to take in an array then process to update the array
        {
            int sum = 0;
            for (int i = 0; i < aArray.Length; i++)//create a loop to go to every element of the array 
            {
                sum += aArray[i];// sum = sum+ each element of array
            }
            return sum;
        }
        static int maxVal(int[] aArray) 
        {
            int max = aArray[0];//assign the max to the first element
            for (int i = 1;i < aArray.Length; i++)//create a loop starting from the second element 
            {
                if (aArray[i] > max)//the array element is greater than the max element
                {
                    max = aArray[i];//assign array element to max element
                }
                     
            }
            return max;// return the max element 
        }
        static int minVal(int[] aArray)
        {
            int min = aArray[0];//assign the min to the first element
            for (int i = 1; i < aArray.Length; i++)//create a loop starting from the second element 
            {
                if (aArray[i] < min)//the array element is less than the min element
                {
                    min = aArray[i];//assign array element to min element
                }

            }
            return min;// return the min element 
        }
        static int[] reverseArray(int[] aArray) //create the method to take in an array then process to update the array
        {
            int[] reversedArray = new int[aArray.Length];
            for (int i = 0; i < reversedArray.Length; i++)//create a loop to go to every element of the array 
            {
                reversedArray[i]=aArray[aArray.Length -1 -i];
            }
            return reversedArray;
        }
    }
}
