using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CasaReparadora
{
    public partial class Login : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool IsNotEmpty(List<TextBox> args){
            foreach (TextBox txt in args) {
                if (txt.Text == "" || txt.Text.Length == 0)
                    return false;
            }
            return true;        
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            List<TextBox> login = new List<TextBox>();
            login.Add(txtUsuario);
            login.Add(txtContra);
            if (IsNotEmpty(login))
            {
                Admin admin = new Admin();
                admin.Show();
                
            }
            else {
                MessageBox.Show("Complete los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}