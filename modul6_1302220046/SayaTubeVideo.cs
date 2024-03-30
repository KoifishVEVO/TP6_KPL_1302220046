using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;


    public SayaTubeVideo( string title)
    {

        Debug.Assert(title != null, "Title tidak boleh null");

        Debug.Assert(title.Length <= 200, "Title maksimal 200 karakter");
        try
        {
           

            checked
            {
                Random random = new Random();
                this.id = random.Next(10000, 99999);
                this.playCount = 0;
                this.title = title;
            }
        }
        catch { }
        {
            Console.WriteLine("Error prekondisi");
        }
        

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
        Contract.Assert(playCount <= 25000000);
        Contract.Assert(playCount >= 0);

        try
        {
            checked
            {
                this.playCount += playCount;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Inputtan Playcount tidak valid");
        }
        

    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Judul: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount);
        Console.WriteLine(" ");
    }
   
}
