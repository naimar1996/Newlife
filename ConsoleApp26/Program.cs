//int a = 358;
//int reminder = 0;
//int sum = 0;
//for (int i = 0; i < a; i++)
//{
//    reminder = a % 10;
//    sum += reminder;
//    a /= 10;
//}
//if (sum % 2 == 0)
//{
//    Console.WriteLine("sum is even");

//}

//int b = 100;
//int sum = 0;
//for (int i = b; i > 0; i--)
//{
//    if (i % 13 == 0)
//    {
//        Console.WriteLine(i);
//        sum += i;
//    }
//}
//Console.WriteLine(sum);

int logo = 571;
int min = 9;
int reminder;
for (int i = 0; i < logo; i++)
{
    reminder = logo % 10;
if ( reminder < min)
    {
        min = reminder;
    }
    logo = logo / 10; 
}
Console.WriteLine(min);





