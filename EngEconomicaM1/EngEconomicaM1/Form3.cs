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
    public partial class Form3 : Form
    {
        Thread nt;
        public Form3()
        {
            InitializeComponent();
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResult.Clear();

            double amortiz = 0;
            double valor = Convert.ToDouble(txtAmortiz.Text);
            double prazo = Convert.ToDouble(txtPrazo.Text);
            double taxa = Convert.ToDouble(txtTaxa.Text) / 100;
            double devendo = 0;
            double parcela = 0;
            double juros = 0;
            double t_juros = 0;
            double t_parcela = 0;
            double parcelaAtual = 1;

            if (radioSac.Checked)
            {
                while (prazo > 0)
                {
                    
                    amortiz = valor / prazo;
                    juros = valor * taxa;
                    devendo = valor - amortiz;
                    parcela = amortiz + juros;
                    t_juros = t_juros + juros;
                    t_parcela = t_parcela + parcela;
                    valor = devendo;

                   //MessageBox.Show(String.Format(valor.ToString("F2")) + "---" + String.Format(devendo.ToString("F2")) + "---" +
                   //     String.Format(parcela.ToString("F2")) + "---" + String.Format(parcelaAtual.ToString("F2")));

                    txtResult.Text = txtResult.Text + "Mês " + String.Format(parcelaAtual + "{0}" + "Parcela: R$ " +
                    parcela.ToString("F2") + "{0}" + "Juros: R$ " + juros.ToString("F2") + "{0}" +
                    "Saldo Devedor: R$ " + devendo.ToString("F2") + "{0}" + "-" + "{0}", Environment.NewLine);

                    parcelaAtual = parcelaAtual + 1;
                    prazo = prazo - 1;
                }
            }else if (radioPrice.Checked){
                while (prazo > 0)
                {
                    parcela = (Math.Pow(( 1 + taxa ), prazo) * (taxa)) / (Math.Pow((1 + taxa), prazo) - 1) * valor;
                    juros = valor * taxa;
                    amortiz = parcela - juros;
                    devendo = valor - amortiz;
                    t_juros = t_juros + juros;
                    t_parcela = t_parcela + parcela;
                    valor = devendo;

                    txtResult.Text = txtResult.Text + "Mês " + String.Format(parcelaAtual + "{0}" + "Parcela: R$ " +
                    parcela.ToString("F2") + "{0}" + "Juros: R$ " + juros.ToString("F2") + "{0}" +
                    "Saldo Devedor: R$ " + devendo.ToString("F2") + "{0}" + "-" + "{0}", Environment.NewLine);

                    parcelaAtual = parcelaAtual + 1;
                    prazo = prazo - 1;
                }
            }
        }

        private void btn_Trash_Click(object sender, EventArgs e)
        {
            txtAmortiz.Text = "0";
            txtPrazo.Text = "0";
            txtTaxa.Text = "0";
            txtResult.Clear();
        }
    }
}
