using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRoyale.Domain;

namespace CRoyale.Client
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Card player1 = new Card();
			player1.Name = "Golem";
			Card player2 = new Card("Pekka");

			player2.ScaleLevel(player2.Level + 5);
			player1.ScaleLevel(player1.Level + 10);

			ControlPlay engine = new ControlPlay();

			for (int i = 0; i < 5; i++)
			{
				MessageBox.Show("Jugando! Turno del " + player1.Name);
				engine.Attack(player1.Damage, player2);
				if (engine.ValidateHP(player2.HP))
				{
					MessageBox.Show(player2.Name + " PERDIO");
					MessageBox.Show($"{player2.Name}. {player2.HP} ");
					engine.GainXP(player1);
					MessageBox.Show(player1.Name + " GANA y Obtiene mas experiencia: " + player1.XP);
					return;
				}
				else
				{
					MessageBox.Show($"{player2.Name}. {player2.HP} - {player2.Damage} - {player2.Shield} ");
				}

				MessageBox.Show("Jugando! Turno del " + player2.Name);
				engine.Attack(player2.Damage, player1);
				if (engine.ValidateHP(player1.HP))
				{
					MessageBox.Show(player1.Name + " PERDIO");
					MessageBox.Show($"{player1.Name}. {player1.HP}");
					engine.GainXP(player2);
					MessageBox.Show(player2.Name + " GANA y Obtiene mas experiencia: " + player2.XP);
					return;
				}
				else
				{
					MessageBox.Show($"{player1.Name}. {player1.HP} - {player1.Damage} - {player1.Shield} ");
				}



			}



		}
	}