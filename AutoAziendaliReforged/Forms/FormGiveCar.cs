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
        public List<Auto> Macchine { get; set; }
        public List<Dipendente> Dipendenti { get; set; }
        public FormGiveCar(BindingList<Auto> auto)
        {
            InitializeComponent();

            Macchine = auto.Where(x => x.Disponibilita == Stato.DISPONIBILE).ToList();
            cmbx_autoDisponibili.DataSource = Macchine.Select(x => $"{x.Marca} {x.Modello} {x.Targa}").ToList();

            Dipendenti = GestioneFiles.GetDipendenti();
            cmbx_dipendenti.DataSource = Dipendenti;
        }

        private void btn_giveCar_Click(object sender, EventArgs e)
        {
            var selectedItem = Macchine.FirstOrDefault(x => $"{x.Marca} {x.Modello} {x.Targa}" == cmbx_autoDisponibili.SelectedItem.ToString());
            selectedItem.Owner = cmbx_dipendenti.SelectedItem as Dipendente;
            selectedItem.Disponibilita = Stato.PRESA;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
