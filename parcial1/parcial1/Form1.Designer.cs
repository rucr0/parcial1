namespace parcial1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.doctorList = new System.Windows.Forms.ComboBox();
            this.pacientesList = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.horaCita = new System.Windows.Forms.ComboBox();
            this.mostrar = new System.Windows.Forms.ListBox();
            this.Itemas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doctorList
            // 
            this.doctorList.FormattingEnabled = true;
            this.doctorList.Location = new System.Drawing.Point(171, 146);
            this.doctorList.Name = "doctorList";
            this.doctorList.Size = new System.Drawing.Size(121, 21);
            this.doctorList.TabIndex = 0;
            this.doctorList.Text = "Doctor";
            this.doctorList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pacientesList
            // 
            this.pacientesList.FormattingEnabled = true;
            this.pacientesList.Location = new System.Drawing.Point(24, 146);
            this.pacientesList.Name = "pacientesList";
            this.pacientesList.Size = new System.Drawing.Size(121, 21);
            this.pacientesList.TabIndex = 1;
            this.pacientesList.Text = "Paciente";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 198);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "GuardarCita";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // horaCita
            // 
            this.horaCita.FormattingEnabled = true;
            this.horaCita.Items.AddRange(new object[] {
            "11:00 hrs",
            "13:00 hrs",
            "15:00 hrs",
            "17:00 hrs"});
            this.horaCita.Location = new System.Drawing.Point(97, 247);
            this.horaCita.Name = "horaCita";
            this.horaCita.Size = new System.Drawing.Size(121, 21);
            this.horaCita.TabIndex = 4;
            this.horaCita.Text = "Hora";
            // 
            // mostrar
            // 
            this.mostrar.FormattingEnabled = true;
            this.mostrar.Location = new System.Drawing.Point(310, 59);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(478, 277);
            this.mostrar.TabIndex = 5;
            // 
            // Itemas
            // 
            this.Itemas.FormattingEnabled = true;
            this.Itemas.Location = new System.Drawing.Point(60, 379);
            this.Itemas.Name = "Itemas";
            this.Itemas.Size = new System.Drawing.Size(121, 21);
            this.Itemas.TabIndex = 6;
            this.Itemas.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad de Citas: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "Mostrar Citas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 53);
            this.button3.TabIndex = 9;
            this.button3.Text = "Ordenar por fecha";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(643, 368);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 53);
            this.button4.TabIndex = 10;
            this.button4.Text = "Ordenado pr Doctor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Itemas);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.horaCita);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pacientesList);
            this.Controls.Add(this.doctorList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox doctorList;
        private System.Windows.Forms.ComboBox pacientesList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox horaCita;
        private System.Windows.Forms.ListBox mostrar;
        private System.Windows.Forms.ComboBox Itemas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

