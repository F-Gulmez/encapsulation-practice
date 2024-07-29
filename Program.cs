namespace PostApp;

class Program
{
    public static List<Post> Posts { get; set; } = new List<Post>();
    static void Main(string[] args)
    {
        Post test = new();
        test.Title = "Title";
        test.Description = "Description";
        
        test.UpVote();
        test.UpVote();
        
        Post test2 = new();
        test2.Title = "Title 2";
        test2.Description = "Description 2"; 
        test2.UpVote();
        test2.UpVote();
        test2.DownVote();
        
        Post test3 = new();
        test3.Title = "Title 3";
        test3.Description = "Description 3";
        test3.DownVote();
        test3.DownVote();
        test3.DownVote();
        
        Posts.Add(test);
        Posts.Add(test2);
        Posts.Add(test3);

        foreach (var post in Posts)
        {
            Console.WriteLine(post.Description);
            Console.WriteLine(post.Title);
            Console.WriteLine(post.DateTime);
            Console.WriteLine(post.VoteCounter);
            Console.WriteLine("----------");
        }
        
        
    }
}