using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Tabsters
{
	public abstract class Animal 
	{
		public double prix;
		public string type;
		// on considère que type veut dire sou-race : berger allemand/terrier
		// pour les chiens par exemple et siamois/ persan pour les chats

		public Animal()
		{
		}
	}
}
