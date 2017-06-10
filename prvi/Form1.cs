using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;
using IronPython.Runtime;
using System.IO;

namespace prvi
{          
    

    public partial class Form1 : Form

        
    {      
        public double A = 0;       // postavljanje A varijable
        public double B = 0;       //postavljanje B varijable
       
        
        public ScriptEngine pyEngine = null;
        public ScriptScope pyScope = null;

        public Form1()
        {
            InitializeComponent();
             pyEngine = Python.CreateEngine();                 // inicijalizacija
             pyScope = pyEngine.CreateScope();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(textBox1.Text);               //pretvara vrijednost text boxa u double  i sprema u A
            B = Convert.ToDouble(textBox2.Text);               //također pretvara vrijednost text boxa u double i sprema u B
            textBox3.Text= Convert.ToString(A + B);            // zbraja A+B i pretvara u string koji ispisuje u texbox3

                                                               // isto vrijedi i za ostale funkcije samo se mijenja operator (-,* ...)
        }

        private void subToolStripMenuItem_Click(object sender, EventArgs e)
        {
             A = Convert.ToDouble(textBox1.Text);
            B = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(A - B);
        }

        private void mulToolStripMenuItem_Click(object sender, EventArgs e)
        {
             A = Convert.ToDouble(textBox1.Text);
            B = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(A * B);
        }

        private void divToolStripMenuItem_Click(object sender, EventArgs e)
        {
             A = Convert.ToDouble(textBox1.Text);
            B = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(A / B);
        }

        

        private void loadExtensionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)        //otvara se dijalog za odabir datoteke 
            {
                ScriptSource skripta = pyEngine.CreateScriptSourceFromFile(openFileDialog1.FileName);
                skripta.Execute(pyScope);
                string Name = pyScope.GetVariable<string>("name");
                dynamic LoadExtension = pyScope.GetVariable("Dodaj");
                LoadExtension(this);

            }

        }

        
    }
}
