namespace ProjetoFinalParte1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblTemperaturaA.Visible = false;
            lblTemperaturaB.Visible = false;
            txtTemperaturaA.Visible = false;
            txtTemperaturaB.Visible = false;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double celsius;
            double farenheit;
            double kelvin;

            try
            {

                if (optCelsius.Checked)
                {

                    celsius = double.Parse(txtTemperatura.Text);
                    farenheit = celsius * 1.8 + 32;
                    kelvin = celsius + 273;

                    lblTemperaturaA.Text = "farenheit:";
                    lblTemperaturaB.Text = "Kelvin:";
                    txtTemperaturaA.Text = farenheit.ToString();
                    txtTemperaturaB.Text = kelvin.ToString();

                    lblTemperaturaA.Visible = true;
                    lblTemperaturaB.Visible = true;
                    txtTemperaturaA.Visible = true;
                    txtTemperaturaB.Visible = true;

                }

                else if (optFarenheit.Checked)
                {

                    farenheit = double.Parse(txtTemperatura.Text);
                    celsius = (farenheit - 32) / 1.8;
                    kelvin = (farenheit - 32) * 5 / 9 + 273.15;

                    lblTemperaturaA.Text = "Celsius:";
                    lblTemperaturaB.Text = "Kelvin:";
                    txtTemperaturaA.Text = celsius.ToString();
                    txtTemperaturaB.Text = kelvin.ToString();

                    lblTemperaturaA.Visible = true;
                    lblTemperaturaB.Visible = true;
                    txtTemperaturaA.Visible = true;
                    txtTemperaturaB.Visible = true;

                }

                else if (optKelvin.Checked)
                {

                    kelvin = double.Parse(txtTemperatura.Text);
                    celsius = kelvin - 273;
                    farenheit = (kelvin - 273) * 1.8 + 32;

                    lblTemperaturaA.Text = "Celsius:";
                    lblTemperaturaB.Text = "farenheit:";
                    txtTemperaturaA.Text = celsius.ToString();
                    txtTemperaturaB.Text = farenheit.ToString();

                    lblTemperaturaA.Visible = true;
                    lblTemperaturaB.Visible = true;
                    txtTemperaturaA.Visible = true;
                    txtTemperaturaB.Visible = true;

                }

                else
                {

                    MessageBox.Show("Selecione uma escala");
                    Focus();

                }
            }
            catch
            {

                MessageBox.Show("ERRO");
                Focus();

            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTemperatura.Text = null;
            txtTemperaturaA.Text = null;
            txtTemperaturaB.Text = null;
            optCelsius.Checked = false;
            optFarenheit.Checked = false;
            optKelvin.Checked = false;

            lblTemperaturaA.Visible = false;
            lblTemperaturaB.Visible = false;
            txtTemperaturaA.Visible = false;
            txtTemperaturaB.Visible = false;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void optFarenheit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
