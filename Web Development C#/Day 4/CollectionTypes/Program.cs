// Main program 
class Program
{
    public static void Main(string[] args)
    {
        Array array = new Array();
        Lists list = new Lists();
        // list.addItem("item1");
        // list.addItem("item2");
        // list.addItem("item3");
        // list.addItem("item4");
        // list.addItem("item2");

        // Console.WriteLine("Before the clear list \n Count: " + list.itemCount());

        // foreach (var item in list.StringList)
        // {
        //     Console.WriteLine(item);
        // }
        // // list.removeItem("item2");
        // // list.clearList();
        // Console.WriteLine("After the clear list");

        // foreach (var item in list.StringList)
        // {
        //     Console.WriteLine(item);
        // }

        // list.addItem("item1");
        Dictionarys dictionarys = new Dictionarys();
        dictionarys.decalareictionary();
        
        foreach (var item in dictionarys.fullName)
        {
        Console.WriteLine(item);
        }
        // dictionarys.displayDictionary(dictionarys.fullName);
    }



}

// Arrays 
class Array
{
    // First way to decalare arrays having constant size
    public void firstWay()
    {
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

        string[] cars = { "Toyota", "Nissan", "BMW", "VolksWagen", "Mercedes-Benz", "Ford" };

        Console.WriteLine(cars.Length);
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);

        }

    }
    // Second way to declare arrays with varying size 
    // Declare size
    public void secondWay()
    {
        int size;
        Console.WriteLine("How many items do you want to put?");
        string arraySize = Console.ReadLine();
        size = int.Parse(arraySize);
        string[] items = new string[size];


        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine("Item No:" + (i + 1));
            items[i] = Console.ReadLine();

        }
        Console.WriteLine(items.Length);


    }


    public void thirdWay()
    {
        // Third way to declare an array 
        string[] movieGenre = { "Action", "Comedy", "Drama", "Romantic" };
        string[] daysInAWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        Console.WriteLine("How many days do you want to work in a week?");
        int number = int.Parse(Console.ReadLine());
        string[] workTimes = new string[number];
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

    }



}

// Lists
public class Lists
{
    // Where usedstring
    // Similar to arrays but with no conconsistent size
    // mainly used as a collection of similar dataset items
    // Saves a specific memory size in the system
    // They vary as to the data type being stored
    public List<string> StringList = new List<string>(); // Occupies more space than the int
    List<int> number = new List<int>();

    // List<float> floats = new ArrayList<>();
    public List<string> getLitst()
    {
        return StringList;
    }

    public void addItem(string item)
    {
        StringList.Add(item); // Adds an item at the end of the list

    }
    public void clearList()
    {
        StringList.Clear(); // Deletes everything from the list

    }
    public void removeItem(string item)
    {
        StringList.Remove(item); // Deletes the first instance of the value in the list

    }
    public void removeAllInstances(Predicate<string> item)
    {
        StringList.RemoveAll(item);
    }
    public String itemCount()
    {
        return StringList.Count().ToString(); // gets the number of elements in the list

    }

}

// Dictionaries
public class Dictionarys
{
    // JSON/ Hstore<mainly while using the postgres database>
    // Example Json
    // {
    //     ["Title","Data"]
    // }
    // Example Hstore
    // {
    //     "Title"=>"Data"
    // }

    public Dictionary<string, string> fullName = new Dictionary<string, string>();
        public Dictionary<int, string> personList = new Dictionary<int, string>();


    public void decalareictionary()
    {
        string FirstName = "John";
        string LastName = "Doe";

        fullName.Add(FirstName, LastName);
        personList.Add(1,FirstName);
    }

    public void displayDictionary(Dictionary<string, string> d)
    {
        // Where used
        // Mainly used in JSON and hstore objects
        Console.WriteLine(d);
    }


}
// // Other Collections but to list
// LinkedList<string> linkedList = new LinkedList<string>();

// // Enumerator
// public enum Gender
// {
//     Male,Female    
// }