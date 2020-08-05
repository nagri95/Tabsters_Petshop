using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Tabsters
{
	public class Chien : Animal
	{
		public Chien() 
		{
			this.prix = 100;
		}
		public Chien(double prix, string type)
		{
			this.type = type;

			this.prix = 100;
		}

	}
}

