namespace Práctica_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sue, nsue, aum;                       //Se declaran las variables a usar.
            sue = double.Parse(textBox1.Text);           //Se declara que el sueldo será el que escribamos en la caja 1.
            if (sue < 400000.0)                          //Se aplica un condicional que activará una fórmula si se sumple, si no, no lo hará.
            {
                aum = sue * 0.15;
                nsue = sue + aum;
                textBox2.Text = nsue.ToString();         //Si se cumple el condicional aparecerá el resultado en la caja 2.
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";      //Se declara que al apretar el botón se elimine lo aparecido en caja 1 y 2.
            textBox2.Text = " ";
        }
    }
}