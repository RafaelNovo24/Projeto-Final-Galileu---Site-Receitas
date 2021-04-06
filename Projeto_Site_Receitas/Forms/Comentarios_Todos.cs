using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Site_Receitas.Forms;
using DAL_Receitas;

namespace Projeto_Site_Receitas.Forms
{
    public partial class Comentarios_Todos : Form
    {
        public Comentarios_Todos()
        {
            InitializeComponent();
        }

        private void Comentarios_Todos_Load(object sender, EventArgs e)
        {
            comboBox_ListarReceita.DataSource = Receita.TodasReceitas();
            comboBox_ListarReceita.DisplayMember = "Nome";
            comboBox_ListarReceita.ValueMember = "IdReceita";
            comboBox_ListarReceita.Text = "--- Escolha uma reita ---";
        }

        private void button_Receita_Click(object sender, EventArgs e)
        {
            if (comboBox_ListarReceita.SelectedItem != null)
            {
                AtualizarComentarios();
            }
        }

        private void button_abrir_Click(object sender, EventArgs e)
        {
            if (comboBox_listaComentario.SelectedItem != null)
            {
                Comentario com = new Comentario((int)comboBox_listaComentario.SelectedValue);
                //textBox_utilizador.Text = com.UtilizadorNome;
                textBox_textoComentario.Text = com.Texto;
            }
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Tem a certeza que quer eliminar este comentário?", "Eliminar", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                Comentario com = new Comentario();
                com.Eliminar((int)comboBox_listaComentario.SelectedValue);
            }
            textBox_textoComentario.Text = String.Empty;
            AtualizarComentarios();
        }

        private void AtualizarComentarios()
        {
            comboBox_listaComentario.DataSource = Comentario.ComentariosPorRceita((int)comboBox_ListarReceita.SelectedValue);
            comboBox_listaComentario.DisplayMember = "Texto";
            comboBox_listaComentario.ValueMember = "ID";
            comboBox_listaComentario.Text = "--- Seleccione comentário ---";
        }
    }
}
