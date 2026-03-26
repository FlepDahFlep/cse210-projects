using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video vid1 = new Video("sakanaction / Kaiju -Music Video-", "sakanaction", 289);
        vid1.AddComment(new Comment("Bosspameur", "10% of the profit of this video goes to Potocki"));
        vid1.AddComment(new Comment("takmate", "I'm a middle-aged man who just started listening."));
        vid1.AddComment(new Comment("Nametake", "The fact that Chi ends up giving the egg to someone she doesn't know is connected to the 'inheritance' depicted in the story."));
        videos.Add(vid1);

        Video vid2 = new Video("Hoshimachi Suisei - BIBBIDIBA (official)", "Suisei Channel", 171);
        vid2.AddComment(new Comment("bokunokamisama", "Suisei in fortnite so peak"));
        vid2.AddComment(new Comment("YoutubeJapan", "Their singing, music videos, and dancing just keep evolving..."));
        vid2.AddComment(new Comment("la1_mei", "Hoshimachi has thrown shoes at the director approximately 100 million times."));
        videos.Add(vid2);

        Video vid3 = new Video("Persona 3 Reload - Pull the Trigger -reload-", "_Mosq", 214);
        vid3.AddComment(new Comment("galactg9218", "I LOVE the atention kotone is getting after being completly excluded from reload"));
        vid3.AddComment(new Comment("mechaisraphel", "How in the absolute Frick did you manage to replicate Reload's vibe yet keep the flow and feel that the PQ2 version was going for so SEAMLESSLY??? This is actually TOO good, holy crap, phenomenal work."));
        vid3.AddComment(new Comment("TheTrollingShuckle722", "If you're attempting to bait me into ambushing every single enemy in Tartarus with this theme… you’re absolutely succeeding, holy crap this remix is literal god tier"));
        videos.Add(vid3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Video Title: " + video.Title);
            Console.WriteLine("Content Creator: " + video.Author);
            Console.WriteLine("Video Length: " + video.Length + " seconds");
            Console.WriteLine("Comments Written: " + video.GetCommentCount());

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" {comment._Name}: {comment._Text}");
            }
            Console.WriteLine();
        }

    }
}