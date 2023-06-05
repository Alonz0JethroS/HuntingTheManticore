class Program
{
    public static void Main(string[] args)
    {
        Dialogs[] choices = { new Dialog1()};
        Console.WriteLine("Choose a destiny?");
        int input = Convert.ToInt32(Console.ReadLine());
        if(input == 1)
        {
            foreach(Dialogs x in choices)
            {
                x.choices();
            }
        }




    
        

    }
}

class Dialogs
{
    public virtual void choices()
    {
        Console.WriteLine("Choose again");
    }
}

class Dialog1 : Dialogs
{
    public override void choices()
    {
        Console.WriteLine("You choose number 1");
    }
}