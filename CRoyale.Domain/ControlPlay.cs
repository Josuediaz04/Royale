using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRoyale.Domain
{
	public class ControlPlay
	{
		Random rnd = new Random();
		private int _xp = 25;
		public void Attack(int damage, Card player)
		{
			int rndShield = rnd.Next(1, player.Shield + 1);
			player.HP -= damage - (rndShield);
		}

		public bool ValidateHP(int hp)
		{
			return hp <= 0;
		}

		public void GainXP(Card playerWin)
		{
			playerWin.XP += _xp;
		}


	}
}
