﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//How to declare a variable
int number = 5;
// long longNumber = 1;
// float decimalNumber = 0.1F; // Include suffix F
// decimal largeDecimalNumber = 0.1M; //Include suffix M
// string text = "Hello World";
// bool check = true;


// Universal variable
var Universal1 = 0;
var Universal2 = "String";


Console.WriteLine(Universal1.GetType());
Console.WriteLine(Universal2.GetType());

//Conditions if, else and switch
if (true || false)
{

}
//Number is the variable coming in 
switch (number)
{
    // case are conditions being checked
    case 0:
        Console.WriteLine("Number is zero");
        break;
    case 1:
        Console.WriteLine("Number is one");
        break;
    case 2:
        Console.WriteLine("Number is tqwo");
        break;
    default:
        Console.WriteLine("Number is unknown");
        break;
}

if (number == 0)
{

}
else if (number == 1)
{

}
else if (number == 2)
{

}
else
{

}

// Loops for, foreach, while
// for loop
int length = 5;
for (
    //local attributes
    int i = 0; i < length; i++)
{
    // Console.WriteLine(i);
}
// global attribute 
// int i = 0;
// [1,2,3,4,5,6,7,8]
int index = 0;
while (index < 10)
{
    //what to be done
    Console.WriteLine(index);
    // length++; // Similar to length = lenght +1;
    // length--; // Similar to length = lenght -1;
    index += 2; //Similar to lenght = length + 2;
    // length *= 2; //Similar to lenght = length * 2;


}


int[] collection = { 1, 1, 3, 4, 65 };
//foreach
foreach (var item in collection)
{
    Console.WriteLine(item);

}
