// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo[] video = new SayaTubeVideo[9];
        int i;

        video[0] = new SayaTubeVideo("Mario Movie");

        video[1] = new SayaTubeVideo("Oppenheimer");

        video[2] = new SayaTubeVideo("Assasins Creed");

        video[3] = new SayaTubeVideo("John Wick");

        video[4] = new SayaTubeVideo("John Wick 2 Parabellum");

        video[5] = new SayaTubeVideo("1917");

        video[6] = new SayaTubeVideo("Mission Impossible:Fallout");

        video[7] = new SayaTubeVideo("Epic Sax Guy");

        video[8] = new SayaTubeVideo("Kung Fu Panda 2");



        SayaTubeUser user = new SayaTubeUser("Farhan");
        SayaTubeUser user2 = new SayaTubeUser("Adit");

        for (i = 0; i < video.Length; i++) {
            user.AddVideo(video[i]);
          }

        for ( i = 0; i < video.Length; i++)
        {
            Console.WriteLine("Review Film" + video[i].GetTitle() + "oleh " + user.Username);
            Console.WriteLine(" ");

        }

        user2.PrintAllVideoPlayCount();

        for (i = 0; i < 214; i++)
        {
            video[8].IncreasePlayCount(10000001);
        }
        video[8].IncreasePlayCount(10000001);

        video[9] = new SayaTubeVideo(null);

    }
}