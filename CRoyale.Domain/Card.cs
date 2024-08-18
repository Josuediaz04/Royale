using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRoyale.Domain
{

	public class Card
	{
		public int CardId { get; set; }
		public string Name { get; set; }
		public int HP { get; set; }
		public int HPBase { get; set; }
		public int Damage { get; set; }
		public int Shield { get; set; }
		public int Level { get; set; }
		public int MaxLevel { get; set; }
		public int XP { get; set; }

		public Card()
		{
			Name = "Anon";
			HPBase = 100;
			HP = HPBase;
			Damage = 10;
			Shield = 2;
			Level = 1;
		}

		public Card(string name)
		{
			Name = name;
			HPBase = 100;
			HP = HPBase;
			Damage = 10;
			Shield = 2;
			Level = 1;
		}

		public void ScaleLevel(int level)
		{
			HP = HPBase * level;
			Damage = Damage * 2;
			Shield = Shield * level;
			Level = level;
		}

	}
}
