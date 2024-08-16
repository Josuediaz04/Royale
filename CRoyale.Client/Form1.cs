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

			Card mago = new Card();
			mago.Name = "Mago";
			Card pekka = new Card("Pekka");
			MessageBox.Show($" {mago.Name} - {mago.HP} - {mago.Damage} - {mago.Shield} ");
			MessageBox.Show($" {pekka.Name} - {pekka.HP} - {pekka.Damage} - {mago.Shield}");

			pekka.ScaleLevel(pekka.Level +  1);
			MessageBox.Show($" {pekka.Name} - {pekka.HP} - {pekka.Damage} - {mago.Shield}");


			Controls  engine = new Controls();

			int golpeMago = engine.Attack(mago.Damage, pekka.Shield);
			pekka.HP -= golpeMago;

			MessageBox.Show("peka verguiado");

			//MessageBox.Show($" {mago.Name} - {mago.HP} - {mago.Damage} - {mago.Shield} ");
			MessageBox.Show($" {pekka.Name} - {pekka.HP} - {pekka.Damage} - {mago.Shield}");

			MessageBox.Show("mago verguiado");

			int golepPekka = engine.Attack(pekka.Damage, mago.Shield);
			mago.HP -= golepPekka;
			MessageBox.Show($" {mago.Name} - {mago.HP} - {mago.Damage} - {mago.Shield} ");


		}
	}
}
