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
    public partial class FormGiveCar : Form
    {
        public List<Dipendente> Dipendenti { get; set; }
        public FormGiveCar(List<Auto> auto)
        {
            InitializeComponent();
            cmbx_autoDisponibili.DataSource = auto.Where(x => x.Disponibilita == Stato.DISPONIBILE).ToList();
            Dipendenti = GestioneFiles.GetDipendenti();
            cmbx_dipendenti.DataSource = Dipendenti;
        }

        private void btn_giveCar_Click(object sender, EventArgs e)
        {
            var selectedItem = cmbx_autoDisponibili.SelectedItem as Auto;
            selectedItem.Owner = cmbx_dipendenti.SelectedItem as Dipendente;
            selectedItem.Disponibilita = Stato.PRESA;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
