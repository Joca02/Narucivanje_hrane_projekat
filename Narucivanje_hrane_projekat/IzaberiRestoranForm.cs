using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narucivanje_hrane_projekat
{
    public partial class IzaberiRestoranForm : Form
    {
        TextBox restoran;
        public IzaberiRestoranForm(TextBox txt)
        {
            InitializeComponent();
            lbRestorani.DataSource=LoginForm.restorani;
            restoran=txt;

        }

        private void lbRestorani_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbRestorani.SelectedIndex;
            if(index!=-1)
            {
                restoran.Text=LoginForm.restorani[index].id.ToString();
                MessageBox.Show(LoginForm.restorani[index].ToString());
                this.Close();
            }
        }
    }
}
