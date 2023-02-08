// Arrays 
// First way to decalare arrays having constant size
int[] numbers = new int[10];

// Storing values in the array's index
numbers[0] = 10; // First value
numbers[6] = 54; // second value
numbers[9] = 9; // 10th value, last value

// 0,1,2,3,4,5,6,7,8,9
// 10,0,0,0,0,0,0,0,0,9

// nth value, index = n - 1;

// Console.WriteLine(numbers[5]);

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i;
    // Console.WriteLine(numbers[i]);

}

// Declaring an array by values

string[] cars = {"Toyota","Nissan", "BMW", "VolksWagen","Mercedes-Benz","Ford"};

Console.WriteLine(cars.Length);
// for (int i = 0; i < cars.Length; i++)
// {
//     Console.WriteLine(cars[i]);

// }

// Second way to declare arrays with varying size 
// Declare size
// int size;
// Console.WriteLine("How many items do you want to put?");
// string arraySize = Console.ReadLine();
// size = int.Parse(arraySize);
// string[] items = new string[size];


// for (int i = 0; i < items.Length; i++)
// {
//     Console.WriteLine("Item No:"+ (i+1));
//     items[i] = Console.ReadLine();

// }
// Console.WriteLine(items.Length);

// Third way to declare an array 
string[] movieGenre = {"Action","Comedy","Drama","Romantic"};
string[] daysInAWeek ={"Monday","Tuesday", "Wednesday","Thursday","Friday","Saturday","Sunday"};

Console.WriteLine("How many days do you want to work in a week?");
int number = int.Parse(Console.ReadLine());
string[] workTimes =  new string[number];
for (int i = 0; i < number; i++)
{
    for (int j = 0; j < daysInAWeek.Length; j++)
    {
        Console.WriteLine(j + daysInAWeek[j]);
    }
    workTimes[i] = Console.ReadLine();
}
for (int i = 0; i < workTimes.Length; i++)
{
    Console.WriteLine(daysInAWeek[int.Parse(workTimes[i])]);
    
}
// // Lists
// List<string> list = new List<string>();
// List<int> number = new List<int>();

// list.Add("item1"); // Adds an item at the end of the list
// list.Clear(); // Deletes everything from the list
// list.Remove("item1"); // Deletes the first instance of the value in the list
// list.Count(); // gets the number of elements in the list
// // Where usedstring
// // Similar to arrays but with no con// Dictionaries
// sistent size
// // mainly used as a collection of similar dataset items


// // Dictionaries
// Dictionary<string, string> fullName = new Dictionary<string, string>();

// string FirstName = "John";
// string LastName = "Doe";

// fullName.Add(FirstName,LastName);
// // Where used
// // Mainly used in JSON and hstore objects
// Console.WriteLine(fullName);
// // Other Collections but to list
// LinkedList<string> linkedList = new LinkedList<string>();

// // Enumerator
// public enum Gender
// {
//     Male,Female    
// }