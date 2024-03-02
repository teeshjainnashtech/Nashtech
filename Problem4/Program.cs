namespace Problem4;
public class Problem4
{
    static void Main(string[] args)
        {
            StackOverflowPost post = new StackOverflowPost("C# Programming", "This is a post about C# programming.");

            // Up-vote and down-vote the post
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();
            post.DownVote();

            // Display current vote value
            Console.WriteLine("Current vote value: " + post.GetVotes());
        }
}
