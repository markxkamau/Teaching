// Main Class having same name as the document
class Program
{
    // Attribute to declare the class Program as main
    public static void Main(string[] args)
    {
        // Basic plain functions
        // return function
        int addNumbers(int a, int b)
        {
            return a + b;
        }

        string getHelloWorld()
        {
            return "Hello World";
        }

        int first = 0;
        int second = 0;

        void getNumbers()
        {
            Console.WriteLine("Input first number");
            // ReadLine to collect inputs
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Input second number");
            string secondNumber = Console.ReadLine();
            first = Int32.Parse(firstNumber);
            second = Int32.Parse(secondNumber);
        }

        //Calls the function
        // getNumbers();

        // Place the interger in value result
        int result = addNumbers(first, second);

        TvProgram tvProgram = new TvProgram();

        tvProgram.declareProgram();

        // Instantiate from main
        tvProgram.ChannelName = "Ntv";
        tvProgram.ChannelNumber = 99;
        tvProgram.Costs = 0;


        tvProgram.getChannelInfo();
    }
}

// Print out the value result
// Console.WriteLine("Answer = " + result);

// Declare class in C#
class TvProgram
{
    // Universal Attributes
    public int ChannelNumber;
    public string ChannelName = "";
    public int Costs;

    //funcions
    // Declare the program
    public void declareProgram()
    {
        Console.WriteLine("What is the channel number");
        // Local attributes
        string channelNumber = Console.ReadLine();
        Console.WriteLine("What is the channel name");
        // Universal attributes
        ChannelName = Console.ReadLine();
        Console.WriteLine("What is the channel cost");
        string channelCosts = Console.ReadLine();
        ChannelNumber = Int32.Parse(channelNumber);
        Costs = Int32.Parse(channelCosts);
    }

    public void getChannelInfo()
    {
        Console.WriteLine("Channel number = " + ChannelNumber);
        Console.WriteLine("Channel Name = " + ChannelName);
        Console.WriteLine("Channel Costs = " + Costs);
    }

}


// Inheritance, Polymorphism, Abstraction, Encapsulation