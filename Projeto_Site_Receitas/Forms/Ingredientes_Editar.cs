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
    public partial class Ingredientes_Editar : Form
    {
        public int IdReceita { get; set; }

        public Ingredientes_Editar()
        {
            InitializeComponent();
        }

        public Ingredientes_Editar(int idReceita)
        {
            InitializeComponent();

            IdReceita = idReceita;
        }
        Ingredientes_Receita ingRec = new Ingredientes_Receita();

        private void Ingredientes_Editar_Load(object sender, EventArgs e)
        {
            AtualizarLista();

            Receita receita = new Receita(IdReceita);

            textBox_IngredientesReceita.Text = receita.Nome;
            
            comboBox_Nome.DataSource = Ingrediente.TodosIngredientes();
            comboBox_Nome.DisplayMember = "NomeIngrediente";
            comboBox_Nome.ValueMember = "IdIngrediente";
            comboBox_Nome.Text = " ";

            comboBox_UnidadeMedida.DataSource = UnidadeMedida.TodasUnidadesMedida();
            comboBox_UnidadeMedida.DisplayMember = "Medida";
            comboBox_UnidadeMedida.ValueMember = "ID";
            comboBox_UnidadeMedida.Text = " ";          
        }


        private void button_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Receita rec = new Receita(IdReceita);

                Ingrediente ingrediente = new Ingrediente((int)comboBox_Nome.SelectedValue);
                UnidadeMedida unMed = new UnidadeMedida((int)comboBox_UnidadeMedida.SelectedValue);
                int quantidade = int.Parse(textBox1_Quantidade.Text);

                Ingredientes_Receita linhaIngrediente = new Ingredientes_Receita();

                linhaIngrediente.Adicionar(ingrediente.IdIngrediente, unMed.ID, quantidade, IdReceita);

                MessageBox.Show("Ingrediente adicionado à lista com sucesso!", "Sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("| Erro ao adicionar Ingrediente | " + ex.Message, "Erro");                
            }
            AtualizarLista();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Tem a certeza que quer eliminar este ingrediente da lista?", "Eliminar", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                Receita r = new Receita();
                List<Ingredientes_Receita> listaIng = Ingredientes_Receita.ListarIngredientesReceita(IdReceita);
                Ingredientes_Receita ing = (Ingredientes_Receita)listBox_Ingredientes.SelectedItem;
                ing.Remover(ing.Ingrediente.IdIngrediente, IdReceita);
            }     
            AtualizarLista();
        }
        public void AtualizarLista()
        {
            listBox_Ingredientes.Items.Clear();
            Receita receita = new Receita(IdReceita);

            List<string> novaLista = new List<string>();
            List<Ingredientes_Receita> listaIng = Ingredientes_Receita.ListarIngredientesReceita(IdReceita);

            foreach (Ingredientes_Receita ing in listaIng)
            {
                listBox_Ingredientes.Items.Add(ing);
            }
        }
    }
}
