using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Receitas;
using System.Web.Security;
using System.Globalization;

namespace Projeto_Site_Receitas.Forms
{
    public partial class ReceitasPendentes : Form
    {
        public ReceitasPendentes()
        {
            InitializeComponent();
        }

        Receita receita = new Receita();

        private void ReceitasPendentes_Load(object sender, EventArgs e)
        {
            comboBox_ID.DataSource = DAL_Receitas.Receita.ReceitasPendentes();
            comboBox_ID.DisplayMember = "Nome";
            comboBox_ID.ValueMember = "IdReceita";
            comboBox_ID.SelectedItem = null;
            comboBox_ID.Text = "--- Seleccione uma receita ---";

            comboBox_Categoria.DataSource = Categorias.TodasCategorias();
            comboBox_Categoria.DisplayMember = "Nome";
            comboBox_Categoria.ValueMember = "CategoriaID";
            comboBox_Categoria.SelectedItem = null;

            comboBox_Dificuldade.DataSource = Dificuldade.TodasDificuldades();
            comboBox_Dificuldade.DisplayMember = "Nivel";
            comboBox_Dificuldade.ValueMember = "DificuldadeID";
            comboBox_Dificuldade.SelectedItem = null;


            comboBox_Duracao.DataSource = Duracao.ListarDuracao();
            comboBox_Duracao.DisplayMember = "Tempo";
            comboBox_Duracao.ValueMember = "DuracaoID";
            comboBox_Duracao.SelectedItem = null;


            comboBox_Porcao.DataSource = Porcao.ListarPorcao();
            comboBox_Porcao.DisplayMember = "Valor";
            comboBox_Porcao.ValueMember = "ID";
            comboBox_Porcao.SelectedItem = null;
        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            if (comboBox_ID.SelectedItem == null)
            {
                MessageBox.Show("Por favor escolha uma receita!", "Alerta");
            }
            else
            {
                Ingredientes_Editar formEditarIngredientes = new Ingredientes_Editar((int)comboBox_ID.SelectedValue);
                formEditarIngredientes.Show();
                formEditarIngredientes.BringToFront();
            }
        }

        private void button_Pesquisar_Click(object sender, EventArgs e)
        {
            if (comboBox_ID.SelectedItem != null)
            {
                Receita receita = new Receita((int)comboBox_ID.SelectedValue);

                textBox_Nome.Text = receita.Nome;
                textBox_Prep.Text = receita.Preparacao;
                textBox_Data.Text = receita.DataCriacao.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);

                if (receita.Validacao == false)
                {
                    textBox_Estado.Text = "Não Aprovado";
                }
                else
                {
                    textBox_Estado.Text = "Aprovado";
                }

                comboBox_Porcao.SelectedValue = receita.Porcao.ID;
                comboBox_Categoria.SelectedValue = receita.Categoria.CategoriaID;
                comboBox_Dificuldade.SelectedValue = receita.Dificuldade.DificuldadeID;
                comboBox_Duracao.SelectedValue = receita.Duracao.DuracaoID;

                AtualizarListarIngredientes();
            }
            else
            {
                MessageBox.Show("Por favor escolha uma receita", "Aviso");
            }
        }

        private void button_Aprovar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogo = MessageBox.Show("Tem a certeza que quer aprovar esta receita?", "Novo Registo", MessageBoxButtons.YesNo);

                if (dialogo == DialogResult.Yes)
                {
                    if (listBox_listaIngredientes.Items.Count > 0)
                    {
                        int id = (int)comboBox_ID.SelectedValue;
                        string nome = textBox_Nome.Text;
                        int dificuldade = (int)comboBox_Dificuldade.SelectedValue;
                        int categoria = (int)comboBox_Categoria.SelectedValue;
                        int duracao = (int)comboBox_Duracao.SelectedValue;
                        string preparacao = textBox_Prep.Text;
                        int porcao = (int)comboBox_Porcao.SelectedValue;

                        if (receita.Aprovar(id, nome, dificuldade, categoria, duracao, preparacao, porcao))
                        {
                            MessageBox.Show("Receita aprovada com sucesso!", "Sucesso");
                        }
                        
                        Atualizar();
                        listBox_listaIngredientes.Items.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Qualquer receita precisa de ingredientes!", "Alerta");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Receita não foi aprovada! " + ex.Message, "Alerta");
            }
        }

        private void button_Rejeitar_Click(object sender, EventArgs e)
        {
            if (comboBox_ID.SelectedIndex != -1)
            {
                DialogResult dialogo = MessageBox.Show("Tem a certeza que quer eliminar esta receita?", "Apagar Registo", MessageBoxButtons.YesNo);

                if (dialogo == DialogResult.Yes)
                {
                    int id = (int)comboBox_ID.SelectedValue;
                    receita.Eliminar(id);
                    Atualizar();
                }
            }
            else
            {
                MessageBox.Show("Por favor escolha uma receita", "Alerta");
            }
        }

        private void button_Atualizar_Click(object sender, EventArgs e)
        {
            AtualizarListarIngredientes();
        }

        private void Atualizar()
        {
            comboBox_ID.SelectedItem = null;
            comboBox_ID.DataSource = Receita.ReceitasPendentes();
            comboBox_Categoria.SelectedItem = null;
            comboBox_Dificuldade.SelectedItem = null;
            comboBox_Duracao.SelectedItem = null;
            comboBox_Porcao.SelectedItem = null;
            textBox_Nome.Text = String.Empty;
            textBox_Prep.Text = String.Empty;
            textBox_Data.Text = String.Empty;
            textBox_Estado.Text = String.Empty;
            listBox_listaIngredientes.DataSource = null;
            listBox_listaIngredientes.Items.Clear();
        }

        private void AtualizarListarIngredientes()
        {
            Receita receita = new Receita((int)comboBox_ID.SelectedValue);
            List<string> novaLista = new List<string>();
            List<Ingredientes_Receita> listaIng = Ingredientes_Receita.ListarIngredientesReceita((int)comboBox_ID.SelectedValue);

            foreach (Ingredientes_Receita ing in listaIng)
            {
                novaLista.Add(ing.ToString());
            }
            listBox_listaIngredientes.DataSource = novaLista;
        }

        private void button_Comentarios_Click(object sender, EventArgs e)
        {
            if (comboBox_ID.SelectedItem == null)
            {
                MessageBox.Show("Por favor escolha uma receita!", "Alerta");
            }
            else
            {
                Comentarios_Receita formComentarios = new Comentarios_Receita((int)comboBox_ID.SelectedValue);
                formComentarios.Show();
                formComentarios.BringToFront();
            }
        }

    }
}
