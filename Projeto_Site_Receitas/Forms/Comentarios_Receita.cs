using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Site_Receitas.Properties;
using DAL_Receitas;

namespace Projeto_Site_Receitas.Forms
{
    public partial class Comentarios_Receita : Form
    {
        public int ReceitaID { get; set; }
        public Comentarios_Receita()
        {
            InitializeComponent();
        }
        public Comentarios_Receita(int idReceita)
        {
            InitializeComponent();

            ReceitaID = idReceita;
        }

        private void Comentarios_Receita_Load(object sender, EventArgs e)
        {
            Receita receita = new Receita(ReceitaID);
            label_Receita.Text = receita.Nome;
            comboBox_listaComentario.DataSource = Comentario.ComentariosPorRceita(ReceitaID);
            comboBox_listaComentario.DisplayMember = "Texto";
            comboBox_listaComentario.ValueMember = "ID";
        }

        private void button_abrir_Click(object sender, EventArgs e)
        {
            Comentario comentario = new Comentario((int)comboBox_listaComentario.SelectedValue);
            textBox_textoComentario.Text = comentario.Texto;
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Tem a certeza que quer eliminar este comentário?", "Eliminar", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                Comentario comentario = new Comentario((int)comboBox_listaComentario.SelectedValue);
                comentario.Eliminar((int)comboBox_listaComentario.SelectedValue);
            }           
            Atualizar();
        }

        private void Atualizar()
        {
            comboBox_listaComentario.DataSource = Comentario.ComentariosPorRceita(ReceitaID);
            textBox_textoComentario.Text = String.Empty;
        }

    }
}
