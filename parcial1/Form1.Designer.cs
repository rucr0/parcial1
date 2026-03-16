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
            this.SuspendLayout();
            // 
            // doctorList
            // 
            this.doctorList.FormattingEnabled = true;
            this.doctorList.Location = new System.Drawing.Point(171, 146);
            this.doctorList.Name = "doctorList";
            this.doctorList.Size = new System.Drawing.Size(121, 21);
            this.doctorList.TabIndex = 0;
            this.doctorList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pacientesList
            // 
            this.pacientesList.FormattingEnabled = true;
            this.pacientesList.Location = new System.Drawing.Point(24, 146);
            this.pacientesList.Name = "pacientesList";
            this.pacientesList.Size = new System.Drawing.Size(121, 21);
            this.pacientesList.TabIndex = 1;
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
            this.button1.Location = new System.Drawing.Point(143, 298);
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
            this.horaCita.Location = new System.Drawing.Point(111, 247);
            this.horaCita.Name = "horaCita";
            this.horaCita.Size = new System.Drawing.Size(121, 21);
            this.horaCita.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.horaCita);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pacientesList);
            this.Controls.Add(this.doctorList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox doctorList;
        private System.Windows.Forms.ComboBox pacientesList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox horaCita;
    }
}

