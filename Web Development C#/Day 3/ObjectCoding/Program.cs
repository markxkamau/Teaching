// Inheritance, Polymorphism, Abstraction, Encapsulation

class Program
{
    public static void Main(string[] args)
    {

        //// Polymorphism
        // Animal animal = new Dog();
        // animal.MakeSound();
        // Console.WriteLine(animal.Name);

        // Dog dog = new Dog();
        // dog.Name="Lee";
        // dog.getName();
        // dog.MakeSound();

        // Square square = new Square();
        // Console.WriteLine(square.Name);

        BankAccount bankAccount = new BankAccount();
        bankAccount.setBalance(100);
        bankAccount.Deposit(100);
        bankAccount.Withdraw(150);
        Console.WriteLine(bankAccount.getBalance());
    }
}

// Inheritance
// Parent class 
public class Animal
{
    public string Name { get; set; } = "Animal";

    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound");
    }

}

// child to animal parent to Dog 
public class Pet : Animal
{
    // Its features
}

// child class 
public class Dog : Pet
{
    // Name = Inherited Characteristic 
    // public string Name { get; set; } = "Lee";
    public void getName()
    {
        Console.WriteLine(Name);
    }
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks");
    }
}



// Abstraction
public abstract class Shape
{
    public abstract double Area();
    public string Name { get; set; } = string.Empty;
}

public class Square : Shape
{
    // public string Name { get; set; } = "Square";
    public double SideLength { get; set; }

    public override double Area()
    {
        return SideLength * SideLength;
    }
}

public class Triangle : Shape
{
    // public string Name { get; set; } = "Triangle";

    public double adjusentLength { get; set; }
    public double oppositeLength { get; set; }
    public double hypotenuseLength { get; set; }

    public override double Area()
    {
        return 0.5 * adjusentLength * oppositeLength;
    }
}


// Encapsulation
public class BankAccount
{
    // Will be having a declared value after the setBalance
    private decimal balance;
    public decimal Balance = 0;

    public decimal getBalance()
    {
        return balance;
    }
    public void setBalance(decimal Balance)
    {
        balance = Balance;

    }
    public void Deposit(decimal amount)
    {
        balance += amount; //balance = balance + amount
    }

    public void Withdraw(decimal amount)
    {
        balance -= amount; //balance = balance - amount
    }
}
