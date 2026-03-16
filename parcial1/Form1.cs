using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LeerDoctor();
            LeerPaciente();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LeerDoctor()
        {
            string nombreArchivo = @"C:\Users\diegoruiz\source\repos\parcial1\parcial1\bin\Debug\Doctores.txt";
            FileStream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                string linea = reader.ReadLine();
                doctorList.Items.Add(linea);
            }
            reader.Close();
        }

        private void LeerPaciente()
        {
            string nombreArchivo = @"C:\Users\diegoruiz\source\repos\parcial1\parcial1\bin\Debug\Pacientes.txt";
            FileStream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                string linea = reader.ReadLine();
                pacientesList.Items.Add(linea);
            }
            reader.Close();
        }

        private void GuardarCita(string nombreArchivo)
        {
            FileStream stream = new FileStream(nombreArchivo, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            // foreach (var nombre in leerAlumnos)
            {
                //String fechahora = dateTimePicker1.Select;
               // String dpi = alumno.Substring(0, 13);

                

                writer.Write(pacientesList.SelectedItem);
                writer.Write(" ");
                writer.Write(doctorList.SelectedItem);
                writer.Write(" ");
                writer.Write(dateTimePicker1.Value.ToShortDateString());
                writer.Write(" ");
                writer.WriteLine(horaCita.SelectedItem);

                // inscripciones.Items.Add("No." + cont2 + 1 + "Alumno: " + nombre + " Taller: " + nombreTaller);
                // cont2++;



            }

            writer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarCita(@"C:\Users\diegoruiz\source\repos\parcial1\parcial1\bin\Debug\Citas.txt");
        }
    }
}
