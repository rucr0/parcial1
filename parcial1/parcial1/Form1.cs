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

        private void leerCitas()
        {
            string nombreArchivo = @"C:\Users\diegoruiz\source\repos\parcial1\parcial1\bin\Debug\Citas.txt";
            FileStream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                string linea = reader.ReadLine();
                mostrar.Items.Add(linea);
                Itemas.Items.Add(linea);

                int cant = Itemas.Items.Count;
                label1.Text = "Cantidad de Citas:  " + cant;
            }

    
            reader.Close();
        }

        private void GuardarCita(string nombreArchivo)
        {
            FileStream stream = new FileStream(nombreArchivo, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            // foreach (var nombre in leerAlumnos)
            {
                String paciente = pacientesList.SelectedItem.ToString();
                String nombrePaciente = paciente.Substring(14, 9);

                String doctor = doctorList.SelectedItem.ToString();
                String nombreDoctor = doctor.Substring(5, 13);
                String especialidad = doctor.Substring(19);

                String fecha = dateTimePicker1.Value.ToShortDateString();
                String hora = horaCita.SelectedItem.ToString();



                writer.Write(nombrePaciente);
                writer.Write(" tiene cita con el doctor ");
                writer.Write(nombreDoctor);
                writer.Write(" el ");
                writer.Write(fecha);
                writer.Write(" a las ");
                writer.WriteLine(hora);

              
                // cont2++;

                


            }

            writer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarCita(@"C:\Users\diegoruiz\source\repos\parcial1\parcial1\bin\Debug\Citas.txt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            leerCitas();
        }
        private void leerCitasOrdenadas()
        {
            string nombreArchivo = @"C:\Users\diegoruiz\source\repos\parcial1\parcial1\bin\Debug\Citas.txt";
            FileStream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            List<string> citas = new List<string>();

            while (reader.Peek() > -1)
            {
                string linea = reader.ReadLine();
                citas.Add(linea);
            }
            reader.Close();

            // Ordenar las citas por fecha más reciente
            citas = citas.OrderByDescending(cita =>
            {
                string[] partes = cita.Split(' ');
                string fecha = partes[5]; // Asumiendo que la fecha está en la posición 5
                DateTime fechaCita;
                DateTime.TryParse(fecha, out fechaCita);
                return fechaCita;
            }).ToList();

            mostrar.Items.Clear();
            Itemas.Items.Clear();

            foreach (string cita in citas)
            {
                mostrar.Items.Add(cita);
                Itemas.Items.Add(cita);
            }

            label1.Text = "Cantidad de Citas: " + citas.Count;
        }

        private void leerCitasOrdenadasPorDoctor()
        {
            string nombreArchivo = @"C:\Users\diegoruiz\source\repos\parcial1\parcial1\bin\Debug\Citas.txt";
            FileStream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            List<string> citas = new List<string>();

            while (reader.Peek() > -1)
            {
                string linea = reader.ReadLine();
                citas.Add(linea);
            }
            reader.Close();

            // Ordenar las citas por el nombre del doctor  
            citas = citas.OrderBy(cita =>
            {
                string[] partes = cita.Split(' ');
                string nombreDoctor = partes[4]; // Asumiendo que el nombre del doctor está en la posición 4  
                return nombreDoctor;
            }).ToList();

            mostrar.Items.Clear();
            Itemas.Items.Clear();

            foreach (string cita in citas)
            {
                mostrar.Items.Add(cita);
                Itemas.Items.Add(cita);
            }

            label1.Text = "Cantidad de Citas: " + citas.Count;
        }
          
        private void button3_Click(object sender, EventArgs e)
        {
            leerCitasOrdenadas();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
  leerCitasOrdenadasPorDoctor();
        }
    }
}
