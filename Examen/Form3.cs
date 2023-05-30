using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form3 : Form
    {
        public Form3()


        {

            InitializeComponent();
        }
        private Form2 form2;
        


        

       
         
            

            



        private void buttonEnterData2_Click(object sender, EventArgs e)
        {
            if (form2 == null)
            {
                form2 = new Form2();
                form2.FormClosed += Form2_FormClosed; 
            }

            form2.Show();
            this.Hide();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2 = null;
        }

        private void buttonEmployeList_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        EmpleadoInformatico informatico = new EmpleadoInformatico();
        private void buttonSave2_Click(object sender, EventArgs e)
        {
            if (radioButtonSingle.Checked)
            {
                informatico.EstadoCivil = "soltero";
            }
            if (radioButtonMarried.Checked)
            {
                informatico.EstadoCivil = "casado";
            }
            if (checkBoxPuntuality.Checked)
            {
                
            }
            if (checkBoxTeamWork.Checked)
            {

            }
            if (checkBoxOrden.Checked)
            {

            }
        }
    }
}
