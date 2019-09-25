using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abilymp2019
{
    public partial class ChangePassSpMen : Form
    {
        public ChangePassSpMen()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form sm = new SpecialistMenu();
            Hide();
            DialogResult res = sm.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                Show();
            }
            else Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Data.ChangePassSpMen = textBox2.Text;
            Form spm = new SpecialistMenu();
            Hide();
            DialogResult res = spm.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                Show();
            }
            else Close();
        }
    }
}
