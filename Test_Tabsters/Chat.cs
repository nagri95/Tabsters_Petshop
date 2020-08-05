using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Tabsters
{
	public class Chat : Animal
	{
		public Chat() 
		{
			this.prix = 110;
		}
		public Chat(double prix, string type)
		{
			this.type = type;

			this.prix = 110;
		}
	}
}

