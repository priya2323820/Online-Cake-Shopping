using System;
using System.Collections.Generic;
using System.Text;

namespace online_application.Cake
{
	class Cakes
	{
		public int Id;
		public string CakeName;
		public string Flavour;
		public int Kilogram;
		public int Price;

        public Cakes()
        {
        }
		
        public Cakes(int id,string cakeName, string flavour, int kilogram, int price)
        {
			Id = id;
            CakeName = cakeName;
            Flavour = flavour;
            Kilogram = kilogram;
            Price = price;
        }
		public int id { get => Id; set => Id = value; }
		public string cakename { get => CakeName; set => CakeName = value; }
		public string flavour{ get => Flavour; set => Flavour = value; }
		public int kilogram { get => Kilogram; set => Kilogram= value; }
		public int price { get => Price; set => Price= value; }


        public override string ToString()
        {
            return String.Format(Id+"\t"+CakeName+"\t"+Flavour+"\t"+Kilogram+"\t"+Price+"\t");
        }
		

    }



}


/*private string name { get; set; }
private string authorName { get; set; }
private string genre { get; set; }
private int noOfChapters { get; set; }
private int noOfLikes { get; set; }
private int noOfReads { get; set; }

public Story(string name, string authorName, string genre, int noOfChapters, int noOfLikes, int noOfReads)
{
	this.name = name;
	this.authorName = authorName;
	this.genre = genre;
	this.noOfChapters = noOfChapters;
	this.noOfLikes = noOfLikes;
	this.noOfReads = noOfReads;
}

public string Name
{
	set { name = value; }
	get { return name; }
}

public string AuthorName
{
	set { authorName = value; }
	get { return authorName; }
}

public string Genre
{
	set { genre = value; }
	get { return genre; }
}

public int NoOfChapters
{
	set { noOfChapters = value; }
	get { return noOfChapters; }
}

public int NoOfLikes
{
	set { noOfLikes = value; }
	get { return noOfLikes; }
}

public int NoOfReads
{
	set { noOfReads = value; }
	get { return noOfReads; }
}	
}
*/