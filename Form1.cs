using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            if (txt_age.Text == "" || txt_kg.Text == "" || txt_m.Text == "" || txt_name.Text == "")
            {
                MessageBox.Show("FAVOR PREENCHER TODOS OS CAMPOS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                decimal kilo = Convert.ToDecimal(txt_kg.Text);
                decimal altura = Convert.ToDecimal(txt_m.Text);
                int idade = Convert.ToInt32(txt_age.Text);
                string nome = txt_age.Text;
                decimal imc;
                imc = kilo / (altura * altura);


                lb_imc.Text = imc.ToString("n1");


                if (imc < 18)
                {


                    lb_result.Text =" ABAIXO DO PESO";
                 
                }
                else if (imc == 19 || imc <= 24)
                {

                    lb_result.Text = "PESO IDEAL";


                }
                else if (imc == 25 || imc <= 29)
                {

                    lb_result.Text = "LEVEMENTE ACIMA DO PESO";
                }
                else if (imc == 30 || imc <= 34)
                {

                    lb_result.Text = "OBESIDADE GRAU I";


                }
                else if (imc == 35 || imc <= 39)
                {

                    lb_result.Text = "OBESIDADE GRAU II";
                }
                else
                {

                    lb_result.Text = "OBESIDADE GRAU III";


                }



            }
            


        }
    }
}
