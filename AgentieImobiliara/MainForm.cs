using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AgentieImobiliara
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void adaugaAngajatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAngajatForm form = new AddAngajatForm();
            form.ShowDialog();
        }

        private void listeazaAngajatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAngajatiForm form = new ListAngajatiForm();
            form.ShowDialog();
        }

        private void adaugaClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClientForm form = new AddClientForm();
            form.ShowDialog();
        }

        private void listeazaClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListClientiForm form = new ListClientiForm();
            form.ShowDialog();
        }

        private void adaugaImobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddImobilForm form = new AddImobilForm();
            form.ShowDialog();
        }

        private void listeazaImobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListImobileForm form = new ListImobileForm();
            form.ShowDialog();
        }

        private void adaugaOfertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOfertaForm form = new AddOfertaForm();
            form.ShowDialog();
        }

        private void cautaOferteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchOferteForm form = new SearchOferteForm();
            form.ShowDialog();
        }

        private void genereazaContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateContractForm form = new GenerateContractForm();
            form.ShowDialog();
        }

        private void listeazăContracteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListContracteForm form = new ListContracteForm();
            form.ShowDialog();
        }

        private void încasăriLunareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncasariLunareForm form = new IncasariLunareForm();
            form.ShowDialog();
        }

        private void tranzactiiPeAgentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TranzactiiPeAgentiForm form = new TranzactiiPeAgentiForm();
            form.ShowDialog();
        }

        private void calculeazaSalariiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateSalariiForm form = new CalculateSalariiForm();
            form.ShowDialog();
        }

        private void imprimăFluturașiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintFluturasForm form = new PrintFluturasForm();
            form.ShowDialog();
        }
    }
}
