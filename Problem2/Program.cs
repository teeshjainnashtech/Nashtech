
namespace Problem2;
public class Problem2
{
    static void Main(string[] args){
        List<string> names = new List<string>();

        Console.WriteLine("Enter names and Press Enter when you are done");

        while (true)
        {
            Console.Write("Enter name: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                break;

            names.Add(input);
        }

        int length = names.Count();
        if(length ==1){
        Console.WriteLine(names[0] + " likes your post.");
        }
        else if(length == 2){
        Console.WriteLine( names[0] + " and " + names[1] + " like your post.");
        }
        else if(length > 2){
        Console.WriteLine( names[0] + "," + names[1]  + " and " +  (length-2).ToString()  +" others like your post.");
        }

    }

}
