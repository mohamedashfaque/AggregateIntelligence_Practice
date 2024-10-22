public class NumberPost : IPostNumberCheck{
    public int PostNumber(int number,int guess){
        Console.WriteLine("The Number you entered :");
        //var num=Convert.ToInt32(Console.ReadLine());
        if (guess==number){
            return 1;
        }
        else {
            return 0;
        }
    }
}