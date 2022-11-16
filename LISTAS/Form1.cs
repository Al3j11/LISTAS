namespace LISTAS
{
    public partial class Form1 : Form
    {
        //Mando a Llamar la clase nueva estadistica
        Nueva_Estadistica estad = new Nueva_Estadistica();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            double num = 0;
            //Valido los campos 
            if (validacion())
            {
                errorProvider1.Clear();
                // hago un recorrido para solicitar la cantidad de numeros a ingresar
                for (int i = 0; i < estad.Cantidad; i++)
                {
                    while (!double.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese los numeros", "Ingresar"), out num))
                    {
                        MessageBox.Show("Debe ser un numero", "Error");
                    }
                    while (num <= 0)
                    {
                        MessageBox.Show("Debe ser un numero menor a cero","Error") ;
                        while (!double.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese los numeros", "Ingresar"), out num))
                        {
                            MessageBox.Show("Debe ser un numero", "Error");
                        }

                    }
                    // agrego los numeros en la lista
                    listBoxNum.Items.Add(num);
                    estad.Numero= num;

                }
            }
                
        }

        public bool validacion()
        {
            bool noError = true;

            //validando input vacio
            if(textCantidad.Text == String.Empty)
            {
                errorProvider1.SetError(textCantidad,"No deje el Campo Vacio");
                MessageBox.Show("Por favor digite un numero","Error");
                noError = false;
            }
            else
            {
                try
                {
                    estad.Cantidad = Convert.ToInt32(textCantidad.Text);
                }
                catch
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textCantidad, "Ingrese un numero Valido");
                    MessageBox.Show("Tiene que ingresar un numero");
                    noError=false;
                }
            }

            return noError;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            textMedia.Text = estad.Media(estad.Numero, estad.Cantidad).ToString();
            double mediana = 0;

            listBoxNum.Sorted = true;
            int pos = estad.Cantidad / 2;
            if(estad.Cantidad % 2 == 0)
            {
                mediana = (((double)listBoxNum.Items[pos - 1] + (double)listBoxNum.Items[pos]) / 2.0);
            }
            else
            {
                mediana = (double)listBoxNum.Items[pos];
            }
            textMediana.Text=mediana.ToString();
            //sin vectores moda

            int conAnte = 0;
            int conDesp=0;

            for( int i=0; i< estad.Cantidad; i++)
            {
                double mPrimero = (double)listBoxNum.Items[i];
                conDesp = 0;
                for(int j=0; j< estad.Cantidad; j++)
                {
                    double mSegundo = (double)listBoxNum.Items[j];
                    if(mPrimero==mSegundo)
                    {
                        conDesp++;
                    }
                }
                if(conDesp != 1)
                {
                    if (conAnte < conDesp)
                        conAnte = conDesp;
                    textModa.Text = mPrimero.ToString();
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            textMedia.Clear();
            textMediana.Clear();
            textModa.Clear();
            listBoxNum.Items.Clear();
            textCantidad.Clear();
            textCantidad.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //utilizando vectores



    }








}