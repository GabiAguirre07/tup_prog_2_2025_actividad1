using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Cilindro objeto1 = new Cilindro(3, 3);
            Cubo objeto2= new Cubo(3);
            Ortoedro objeto3 = new Ortoedro(7, 7, 21);
            Cilindro objeto4 = new Cilindro(9, 13);
            Cubo objeto5 = new Cubo(7);
            Cilindro objeto6 = new Cilindro(13, 23);

            

            textBox1.Text += $@"[
 {objeto1.Describir()},             
 {objeto2.Describir()},
 {objeto3.Describir()},
 {objeto4.Describir()},
 {objeto5.Describir()},
 {objeto6.Describir()}
]";



        }

    }
}

