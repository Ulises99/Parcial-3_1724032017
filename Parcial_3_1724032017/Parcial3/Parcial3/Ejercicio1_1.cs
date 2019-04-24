using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class Ejercicio1_1 : Form
    {
        public Ejercicio1_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, password;
            usuario = txtLogin.Text.TrimEnd();
            password = txtPass.Text.TrimEnd();

            if((usuario=="ULISES")&&(password=="examen3"))
            {
                for(int i=0;i<=24;i++)
                {
                    progressBar1.PerformStep();
                }

                Ejercicio1_2 obj = new Ejercicio1_2();
                obj.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
