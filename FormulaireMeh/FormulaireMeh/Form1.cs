using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulaireMeh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void ckcTout_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckcTout.CheckState == CheckState.Checked)
            {
                this.ckcAnglais.CheckState = CheckState.Checked;
                this.ckcEco.CheckState = CheckState.Checked;
                this.ckcMaths.CheckState = CheckState.Checked;
                this.ckcSlam.CheckState = CheckState.Checked;
                this.ckcFrancais.CheckState = CheckState.Checked;
                this.ckcTout.Text = "Tout Decocher";
            }
            else if (this.ckcTout.CheckState == CheckState.Unchecked)
            {
                this.ckcTout.Text = "Tout Cocher";

                this.ckcAnglais.CheckState = CheckState.Unchecked;
                this.ckcEco.CheckState = CheckState.Unchecked;
                this.ckcMaths.CheckState = CheckState.Unchecked;
                this.ckcSlam.CheckState = CheckState.Unchecked;
                this.ckcFrancais.CheckState = CheckState.Unchecked;
            }

        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            string meh = "vos préférences : ";
            foreach (Control ckc in groupBox1.Controls)
            {
                if (((CheckBox)ckc).Checked == true)
                {
                    meh += ckc.Text + " " ;
                }

    
        }
            MessageBox.Show(meh);

        }
    }
}