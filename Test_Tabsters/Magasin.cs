using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Tabsters
{
	public class Magasin
	{
		public Magasin()
		{
		}
		public double Trésorerie;

		public List<Animal> animaux = new List<Animal>();

		public void achatAnimal( Animal pet)
        {
			this.animaux.Add(pet);
			this.Trésorerie -= pet.prix;

        }

		public void achatGroupe (List<Animal> pets)
        {
			this.animaux.AddRange(pets);

			foreach ( Animal pet in pets )
            {
				this.Trésorerie -= pet.prix;
            }

        }

		public void venteAnimal(Animal pet) 
		{
			this.animaux.Remove(pet);
			this.Trésorerie += pet.prix;

		}

		public void venteGroupe(List<Animal> pets)
		{
			pets.ForEach(p => this.animaux.Remove(p));

			foreach (Animal pet in pets)
			{
				this.Trésorerie += pet.prix;
			}

		}






	}
}

