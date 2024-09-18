Random random = new Random();
int computerNumber = random.Next(0, 101);
try
{
    while (true)
    {
        Console.Write("Enter anumber between 0 and 100: ");
        int playerNumber = int.Parse(Console.ReadLine());
        if(playerNumber == computerNumber)
        {
            Console.WriteLine("Correct!");
            break;
        }
        else if(playerNumber > computerNumber)
        {
            Console.WriteLine("Too high!");
        }
        else
        {
            Console.WriteLine("Too low!");
        }
    }
}
catch
{
    Console.WriteLine("Invalid input!");
}