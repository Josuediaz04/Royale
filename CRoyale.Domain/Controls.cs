using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRoyale.Domain
{
	public class Controls
	{
		Random rnd = new Random();

		public int Attack(int damage, int shield)
		{
			
			int rndShield = rnd.Next(1, 101);
			int result = damage -(rndShield) ;
			return result;

		}
	}
}
