using AutoAziendaliReforged.Classi;
using AutoAziendaliReforged.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoAziendaliReforged
{
    public partial class Form1 : Form
    {
        public List<Auto> Macchine { get; set; }
        public Form1()
        {
            InitializeComponent();
            Macchine = GestioneFiles.GetCars();
            RefreshGrid();
        }
        private void btn_addCar_Click(object sender, EventArgs e)
        {
            var formGetCar = new FormGetCar();
            var resForm = formGetCar.ShowDialog();
            if (resForm == DialogResult.OK)
            {
                Macchine.Add(formGetCar.Macchina);
                GestioneFiles.SaveCars(Macchine);
            }
            RefreshGrid();
        }
        private void btn_giveCar_Click(object sender, EventArgs e)
        {
            var formGiveCar = new FormGiveCar(Macchine);
            var resForm = formGiveCar.ShowDialog();
            if (resForm == DialogResult.OK)
            {
                GestioneFiles.SaveCars(Macchine);
            }
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            dgv_autoAziendali.DataSource = null;
            dgv_autoAziendali.DataSource = Macchine;
        }
    }
}