using System.Drawing.Text;

namespace GeneradorDeContraseñas
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        static string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string lowerCase = "abcdefghijklmnopqrstuvwxyz";
        static string Numbers = "0123456789";
        static string Caracter = "?¿=.,+*-!";

        string ListAll = string.Empty;

        public Form1()
        {
            InitializeComponent();



        }


        //Metodo para la eleccion de los caracteres de la contraseña
        private void CreateList()

        {
            //Cada vez que comience al pulsar el boton se reseteará el contenido
            ListAll = string.Empty;


            if (chkLower.Checked) //si las minusculas tienen check 
                ListAll = ListAll + lowerCase;  //Se añaden  la lista total

            // se repite lo mismo para el resto de variables creadas
            if (chkUper.Checked)
                ListAll = ListAll + upperCase;

            if (chkNum.Checked)
                ListAll = ListAll + Numbers;

            if (chkSpecial.Checked)
                ListAll = ListAll + Caracter;

            //Si no se elige ninguno,se usa todo por defecto

            if (string.IsNullOrEmpty(ListAll))
                ListAll = lowerCase + upperCase + Numbers + Caracter;
        }

        //Metodo para generar la Contraseña
        private string GeneratePass(int lenght)
        {

            string newPass = string.Empty;

            //si tiene menos de 6 caracteres lanza una exception
            if (lenght < 6)
                throw new Exception("El numero de caracteres debe ser mayor de 6");

            for (int i = 0; i < lenght; i++)
            {
                newPass = newPass + GetRandom();
            }

            return newPass;

        }
        private string GetRandom()
        {
            //genera el cada caracter aleatorio para la contraseña
            return ListAll.ToCharArray()[(int)Math.Floor(random.NextDouble() * ListAll.Length)].ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            try
            {

             //cuando se pulse el boton, se crea la cadena de caracteres
            CreateList();
            txtGenerate.Text = GeneratePass(int.Parse(txtLongitud.Text));


            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void txtLongitud_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Verifica que solo se introduczcan numeros para la longitud

            if (!char.IsControl(e.KeyChar) &&!char.IsDigit(e.KeyChar) && (e.KeyChar !='.'))
            {
                e.Handled = true;
            }
        }
    }
}
