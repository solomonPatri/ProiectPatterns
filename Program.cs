using ProiectPatterns.User;
using ProiectPatterns.User.CommandService;
using ProiectPatterns.User.QueryService;
using ProiectPatterns.User.Repository;
using ProiectPatterns.User.Singleton;

internal class Program
{
    private static void Main(string[] args)
    {

        //cod1

        try
        {

            int error = int.Parse("abc");

            //l1
            //l2
            //...
            //ln

        }
        catch(FormatException ex)
        {
            Console.WriteLine("A ti introdus formatul gresit !");


        }catch(Exception ex)
        {

            Console.WriteLine("Sa produs eroarea: " + ex.Message);

        }
       
     
        //cod2

        
    }
}