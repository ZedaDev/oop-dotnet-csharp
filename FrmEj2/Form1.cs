using Exceptions;

namespace FrmEj2
{
    public partial class FrmEjercicio2 : Form
    {


        public FrmEjercicio2()
        {
            InitializeComponent();
        }

        private void VerifyAndViewRichTBox(string txt1, string txt2)
        {
            try
            {
               // rtcMostrar.Clear();
                ValidateTexts(txt1, txt2);


                int number = int.Parse(txt1);
                int number1 = int.Parse(txt2);
                
                rtcMostrar.Text = $"CONSUMO : {Calculador.Calcular(number, number1)}";
                
            }
            catch (ParametrosVaciosException ex)
            {

                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message, "Format Exeption", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                txtKms.Clear();
                txtLiters.Clear();
                txtKms.Focus();
                
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            VerifyAndViewRichTBox(txtKms.Text, txtLiters.Text);
        }

        private void ValidateTexts(string txt1, string txt2)
        {
            if(txt1 is not null && txt2 is not null)
            {
                if (string.IsNullOrEmpty(txt1.Trim()) && string.IsNullOrEmpty(txt2.Trim()))
                    throw new ParametrosVaciosException("Kms or Liters is empty");
            }
        }
    }
}
