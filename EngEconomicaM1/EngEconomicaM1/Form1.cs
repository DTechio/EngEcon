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
    public partial class Form1 : Form
    {
        Thread nt;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_juros_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(jurosForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void jurosForm()
        {
            Application.Run(new Form2());
        }

        private void btn_amort_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(amortForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void amortForm()
        {
            Application.Run(new Form3());
        }
    }
}
