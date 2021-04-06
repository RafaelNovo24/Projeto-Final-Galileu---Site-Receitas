using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Projeto_II.Entities;

namespace Projeto_II
{
    public partial class GestaoUtilizadores : Form
    {
        public GestaoUtilizadores()
        {
            InitializeComponent();
        }

        private void button_gestaoUtilizador_RemoverUtilizador_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem a certeza que quer eliminar este utilizador?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                Utilizadores eliminarUti = new Utilizadores((int)comboBox_dadosUtilizador.SelectedValue);
                eliminarUti.EliminarUtilizador((int)comboBox_dadosUtilizador.SelectedValue);
                AtualizarListaUtilizadores();
            }
            else
            {
                Environment.Exit(0);
            }

        }
        private void comboBox_dadosUtilizador_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox_dadosUtilizador.SelectedValue.GetType().Name == "Int32")
            {
                Utilizadores u = new Utilizadores((int)comboBox_dadosUtilizador.SelectedValue);

                textBox_info.Text = "ID: " + u.Id + Environment.NewLine +
                                    Environment.NewLine +
                                     "Nome: " + u.Nome + Environment.NewLine +
                                     Environment.NewLine +
                                     "Apelido: " + u.Apelido;
            }
        }

        private void GestaoUtilizadores_Load(object sender, EventArgs e)
        {
            AtualizarListaUtilizadores();
        }
        private void AtualizarListaUtilizadores()
        {
            comboBox_dadosUtilizador.DataSource = Utilizadores.ListaUtilizadores();
            comboBox_dadosUtilizador.DisplayMember = "Nome";
            comboBox_dadosUtilizador.ValueMember = "ID";
        }
    }
}
