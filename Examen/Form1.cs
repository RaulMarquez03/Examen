using Microsoft.VisualBasic;

namespace Examen
{
    public partial class Form1 : Form
    {
        //private EmpleadoInformatico informatico;
        public Form1()
        {
            InitializeComponent();
            




        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            
            empleado.fullName = textBoxName.Text;
            empleado.department = comboBoxDepartmane.SelectedItem.ToString();
            empleado.age = maskedTextBoxAge.Text;
            
           
        }
    }
}