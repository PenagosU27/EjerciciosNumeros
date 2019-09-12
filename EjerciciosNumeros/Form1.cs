using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnaceptar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt1.Text);
            int num2 = int.Parse(txt2.Text);
            {
                if (num1 > num2)
                {
                    lblresultado.Text = ("El número " + num1 + " es mayor");
                    lblresultado.Visible = true;
                }

                if (num1 < num2)
                {
                    lblresultado.Text = ("El numero " + num1 + " es menor");
                    lblresultado.Visible = true;
                }

              




            }

        }
    }
}
        
            

         
    
       
    


    


 

            

