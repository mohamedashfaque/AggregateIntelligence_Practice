namespace DependInj2.Services;

public class NumberClient : INumberService
{
    private int number=new Random().Next(0, 100);
    public int GenerateNumber(){
        Console.WriteLine("This is the NumberClient 1 is running");
            return number;
    }
}
