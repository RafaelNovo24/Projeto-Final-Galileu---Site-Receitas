using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Security;
using System.Web.Profile;

namespace Projeto_Site_Receitas.Forms
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            var users = Membership.GetAllUsers();
            foreach (MembershipUser item in Membership.GetAllUsers())
            {
                listBox1.Items.Add(item.UserName.ToString());
            }
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            BloquearUtilizador(true);
            MessageBox.Show("Utilizador Bloqueado com sucesso!", "Sucesso");

        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            BloquearUtilizador(false);
            MessageBox.Show("Utilizador Desbloqueado com sucesso!", "Sucesso");
        }

        private void BloquearUtilizador(bool paraBloquear)
        {
            MembershipUser user = Membership.GetUser(listBox1.SelectedItem.ToString());
            user.IsApproved =!paraBloquear;
            Membership.UpdateUser(user);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MembershipUser user = Membership.GetUser(listBox1.SelectedItem.ToString());

            if (user.IsApproved == true)
            {
                textBox1.Text = "Desbloqueado";
            }
            else
            {
                textBox1.Text = "Bloqueado";
            }
        }
    }
}
