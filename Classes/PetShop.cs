using System;

namespace Classes
{
	public class PetShop
	{
        public List<FantasyPet> PetsInShop = new List<FantasyPet>();

		public void AddPet(FantasyPet pet)
		{
			PetsInShop.Add(pet);
		}

		public void ListPets()
		{
			FantasyPet[] PetsInShopArr = PetsInShop.ToArray();

			foreach (FantasyPet pet in PetsInShopArr)
			{
				Console.WriteLine($"Name: {pet.Name}\nSpecies: {pet.Species}\nAge: {pet.Age}\nPrice: ${pet.Price}\nPower: {pet.MagicPower}\n--------------------------------------------------");
			}
		}

		public PetShop(List<FantasyPet> petsInShop)
		{
			PetsInShop = petsInShop;
		}
	}
}
