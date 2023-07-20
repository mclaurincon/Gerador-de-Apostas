namespace Gerador_de_Apostas
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			int inicial = Convert.ToInt32(textBox1.Text);
			int final = Convert.ToInt32(textBox2.Text);
			int limite = Convert.ToInt32(textBox3.Text);
		

			int Sorteado;
			int[] verificador = new int[limite];


			var resultado = "";

			for (int i = 0; i <= limite - 1; i++)
			{
				Inicio: 
				Sorteado = r.Next(inicial, final);
				for (int j = 0; j <= limite - 1; j++)
				{
					if (Sorteado == verificador[j])
					{
						goto Inicio;
					}
				}
				resultado = resultado +" "+ Sorteado;
				label3.Text = resultado;
				verificador[i] = Sorteado;
			}
		}
	}
}