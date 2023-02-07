// Arrays 
// First way to decalare arrays having constant size
/*int[] numbers = new int[10];

// Storing values in the array's index
numbers[0] = 0;
numbers[9] = 9;

Console.WriteLine(numbers[5]);

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i;
}

// Declaring an array by values

string[] cars = {"Toyota","Nissan", "BMW", "VolksWagen","Mercedes-Benz","Ford"};

Console.WriteLine(cars.Length);*/
// Second way to declare arrays with varying size 
// Declare size
/*int size;
Console.WriteLine("How many items do you want to put?");
string[] items = new string[size];

Console.WriteLine(items.Length);*/
// Third way to declare an array 
var movieGenre = {"Action","Comedy","Drama","Romantic"};
// var month = {"January"}
// Lists
List<string> list = new ArrayList();
list<int> number = new list<int>();

list.append();
list.remove();
// Where usedstring
// Similar to arrays but with no consistent size
// mainly used as a collection of similar dataset items
// Dictionaries
Dictionary<string, string> fullName = new Dictionary<string, string>();

string FirstName = "John";
string LastName = "Doe";

fullName.Add(FirstName,LastName);
// Where used
// Mainly used in JSON and hstore objects
Console.WriteLine(fullName);
// Other Collections but to list
HashMap hashMap = new HashMap();
LinkedList<string> linkedList = new LinkedList<string>();

// Enumerator
public enum Gender
{
    Male,Female    
}