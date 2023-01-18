//int[] numbers = { 12, 76, 90, 124, 35 };
//int temp;
//for (int i = 0; i < numbers.Length; i++)
//{
//    for (int j = i + 1; j < numbers.Length; j++)
//    {
//        if (numbers[i] > numbers[j])
//        {
//            temp = numbers[i];
//            numbers[i] = numbers[j];
//            numbers[j] = temp;

//        }
//    }
//    Console.WriteLine(numbers[i]);
//}

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

int[] numbers = { 20, 30, 40, 50, 60, 70 };
int reversedArray;
int dddd = 0;
for (int i = 0; i < numbers.Length; i++)
{
    for (int y = i + 1; y < numbers.Length; y++)
        reversedArray = numbers[i] + dddd;
    {
        if (numbers[i] > numbers[y])
        {
            numbers[i] = dddd;
            numbers[i] = numbers[y];
            numbers[y] = dddd;

        }


    }
    Console.WriteLine(reversedArray);

}


