using AutoAziendaliReforged.Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoAziendaliReforged.Forms
{
    public partial class FormGetCar : Form
    {
        public Auto Macchina { get; set; }
        public FormGetCar()
        {
            InitializeComponent();
        }

        private void btn_inserisci_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto(tbx_marca.Text, tbx_modello.Text, tbx_targa.Text, tbx_cilindrata.Text, dtp_scadenzAssicurazione.Value);
            Macchina = auto;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
