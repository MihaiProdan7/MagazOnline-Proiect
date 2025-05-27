using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MagazOnline.Models;

namespace MagazOnline
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string caleFisier = @"Data\\utilizatori.json";
            var utilizatori = Utilizator.IncarcaUtilizatoriDinFisier(caleFisier);

            foreach (var u in utilizatori)
            {
                listBox1.Items.Add($"[{u.Tip}] {u.Nume} - {u.Username}");
            }
        }
    }
}
