using System;

namespace Classes
{
	public class FantasyPet
	{
		public string Name {  get; set; }
		public string Species { get; set; }
		public int Age { get; set; }
		public decimal Price { get; set; }
		public string MagicPower { get; set; }

		public void DescribePet()
		{
			Console.WriteLine($"{this.Name} is a {this.Age} year old {this.Species}. Its magical power is {this.MagicPower}. It costs {this.Price}");
		}

		public decimal DiscountPrice(int percent)
		{
			return (decimal)(this.Price - ( ( (decimal)percent / 100) * this.Price) );
		}

		public void PerformMagic()
		{
			Console.WriteLine($"You see a glint of light as {this.Name} uses its {this.MagicPower} power.");
		}

		public FantasyPet(string name, string species, int age, decimal price, string magicPower)
		{
			Name = name;
			Species = species;
			Age = age;
			Price = price;
			MagicPower = magicPower;
		}
	}
}

