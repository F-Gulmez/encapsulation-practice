namespace PostApp;

public class Post
{
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public DateTime DateTime { get; } = DateTime.Now;
    public int VoteCounter { get; private set; } = 0;

    public void UpVote()
    {
        VoteCounter += 1;
    }
    
    public void DownVote()
    {
        VoteCounter -= 1;
    }
    
}