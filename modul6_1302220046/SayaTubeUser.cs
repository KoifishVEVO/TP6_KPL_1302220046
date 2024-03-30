using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Numerics;

class SayaTubeUser
{
	private int id;
	private List<SayaTubeVideo> uploadedVideos;
	public string Username;


	public SayaTubeUser(string username)
	{
		Contract.Assert(!string.IsNullOrEmpty(username));
		Contract.Assert(username.Length <= 100);
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
		Contract.Assert(video != null);
		Contract.Assert(this.uploadedVideos.Count <= 25000000);


        int i = this.uploadedVideos.Count + 1;


		this.uploadedVideos.Add(video);
	}

	public void PrintAllVideoPlayCount()
	{
		int i;
        Console.WriteLine("User: " + this.Username);
		for (i = 0; i < this.uploadedVideos.Count; i++)
		{


			Console.WriteLine("Video " + (i+1) + "judul: " + uploadedVideos[i].GetTitle());
		}

		Contract.Ensures(i < 8, "Video maksimal 8");
		}

}
