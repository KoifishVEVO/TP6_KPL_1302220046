using System;
using System.Diagnostics;
using System.Numerics;

class SayaTubeUser
{
	private int id;
	private List<SayaTubeVideo> uploadedVideos;
	public string Username;


	public SayaTubeUser(string username)
	{
		this.Username = username;
		this.uploadedVideos = new List<SayaTubeVideo>();

        Random random = new Random();
        this.id = random.Next(10000, 99999);

    }

	public int GetTotalVideoPlayCount()
	{
		int total = 0;

		foreach (SayaTubeVideo video in uploadedVideos)
		{
			total += video.GetPlayCount();

			
		}
		return total ;

		
	}

	public void AddVideo(SayaTubeVideo video)
	{
		int i = this.uploadedVideos.Count + 1;

		this.uploadedVideos.Add(video);
	}

	public void PrintAllVideoPlayCount()
	{
        Console.WriteLine("User: " + this.Username);
		for (int i = 0; i < this.uploadedVideos.Count; i++)
		{


			Console.WriteLine("Video " + (i+1) + "judul: " + uploadedVideos[i].GetTitle);
		}
		}

}
