using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace EngEconomicaM1
{
    public partial class Form2 : Form
    {

        Thread nt;
        public Form2()
        {
            InitializeComponent();
            radioTotal.Checked = true;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(menuForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void menuForm()
        {
            Application.Run(new Form1());
        }

        private void btn_trash_Click(object sender, EventArgs e)
        {
            valorEmprest.Text = "0";
            valorMensal.Text = "0";
            valorPrazo.Text = "0";
            valorTaxa.Text = "0";
            txtResult.Clear();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            txtResult.Clear();

            double valorEmp = Convert.ToDouble(valorEmprest.Text);
            double valorPra = 0;
            double valorTax = 0;
            double juros = 0;

            double total = 0;
            double valorParcelas = 0;


            // TIPO DE PRAZO (ANOS OU MESES)
            if (radioPAnos.Checked)
            {
                valorPra = Convert.ToDouble(valorPrazo.Text) * 12;
            }
            else
            {
                valorPra = Convert.ToDouble(valorPrazo.Text);
            };


            // TIPO DE TAXA (ANUAL, SEMESTRAL OU MENSAL)
            if (radioJAnual.Checked)
            {
                valorTax = (Convert.ToDouble(valorTaxa.Text) / 100) / 12;
            }else if (radioJSemestral.Checked)
            {
                valorTax = (Convert.ToDouble(valorTaxa.Text) / 100) / 6;
            }
            else
            {
                valorTax = (Convert.ToDouble(valorTaxa.Text) / 100);
            }


            // TIPO DE JUROS (SIMPLES OU COMPOSTO)
            if (radioSimples.Checked && radioTotal.Checked)
            {
                juros = valorEmp * valorPra * valorTax;
            }
            else if (radioComposto.Checked && radioTotal.Checked)
            {
                juros = valorEmp * (Math.Pow((1 + valorTax), valorPra) - 1);

            }
            else if (radioSimples.Checked && radioMensal.Checked)
            {
                valorParcelas = Convert.ToDouble(valorMensal.Text);
                total = valorParcelas * valorPra;
                juros = total * valorPra * valorTax;
            }
            else if (radioComposto.Checked && radioMensal.Checked)
            {
                valorParcelas = Convert.ToDouble(valorMensal.Text);
                total = valorParcelas * valorPra;
                juros = total * (Math.Pow((1 + valorTax), valorPra) - 1);

            }


            if (radioTotal.Checked)
            {
                valorParcelas = (valorEmp + juros) / valorPra;
                txtResult.Text = "Juros: R$ " + String.Format(juros.ToString("F2") + "{0}" + "Parcelas: " + valorPra +
                " de R$ " + valorParcelas.ToString("F2"), Environment.NewLine);
            }
            else if (radioMensal.Checked)
            {

                valorParcelas = Convert.ToDouble(valorMensal.Text);
                total = (valorParcelas + juros) * valorPra;
                txtResult.Text = "Juros: R$ " + String.Format(juros.ToString("F2") + "{0}" + "Total: " +
                "R$ " + total.ToString("F2"), Environment.NewLine);
            }


        }

        // Only Numbers
        private void valorEmprest_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void valormensal_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void valorPrazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void valorTaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        // DESABILITAR TEXTBOX (MENSAL/TOTAL)
        private void radioTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMensal.Checked)
            {
                valorEmprest.Enabled = false;
                valorMensal.Enabled = true;
            }
            else
            {
                valorEmprest.Enabled = true;
                valorMensal.Enabled = false;
            }
        }
    }
}
