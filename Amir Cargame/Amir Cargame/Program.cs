
using System;

public class Car
{
    public string Model { get; set; }
    private string position; // game done in order just to show off the code,,linear movement but later will add more stuff thanks teacher!! :D

    public Car(string model)
    {
        Model = model;
        position = "middle"; 
    }

    public void MoveLeft()
    {
        if (position == "middle")
        {
            position = "left";
            Console.WriteLine($"{Model} moved to the left lane.");
        }
        else if (position == "right")
        {
            position = "middle";
            Console.WriteLine($"{Model} moved to the middle lane.");
        }
        else
        {
            Console.WriteLine($"{Model} is already in the left lane.");
        }
    }

    public void MoveRight()
    {
        if (position == "middle")
        {
            position = "right";
            Console.WriteLine($"{Model} moved to the right lane.");
        }
        else if (position == "left")
        {
            position = "middle";
            Console.WriteLine($"{Model} moved to the middle lane.");
        }
        else
        {
            Console.WriteLine($"{Model} is already in the right lane.");
        }
    }

    public void ShowPosition()
    {
        Console.WriteLine($"{Model} is currently in the {position} lane.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car("RaceCar");
        car.ShowPosition();

        car.MoveLeft();   
        car.ShowPosition();

        car.MoveRight();  
        car.ShowPosition();

        car.MoveRight();  
        car.ShowPosition();
    }
}
