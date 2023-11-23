using System;

namespace Student
{
    public class StudentDetails : IStudent
    {

        public string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string ManualReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            int left = 0;
            int right = chars.Length - 1;

            while (left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }

            return new string(chars);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a string: ");
            string original = Console.ReadLine();

            IStudent student = new StudentDetails();

            string reversedBuiltIn = student.ReverseString(original);
            string reversedManual = student.ManualReverseString(original);

            Console.WriteLine("Reversed string Built-in: {0}", reversedBuiltIn);
            Console.WriteLine("Reversed string Manual: {0}", reversedManual);
        }

    }

}