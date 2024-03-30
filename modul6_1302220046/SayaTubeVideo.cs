using System;

 class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;


    public SayaTubeVideo( string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.playCount = 0;
        this.title = title;

    }

    public int GetPlayCount()
    {
        return this.playCount;
    }

    public string GetTitle()
    {
        return this.title;
    }

    public void IncreasePlayCount(int playCount)
    {

        this.playCount += playCount;

    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Judul: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount);
    }
   
}
