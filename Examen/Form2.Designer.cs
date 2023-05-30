namespace Examen
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEnterData = new System.Windows.Forms.Button();
            this.buttonSpecificDetails = new System.Windows.Forms.Button();
            this.listBoxEmpleados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonEnterData
            // 
            this.buttonEnterData.Location = new System.Drawing.Point(123, 320);
            this.buttonEnterData.Name = "buttonEnterData";
            this.buttonEnterData.Size = new System.Drawing.Size(153, 68);
            this.buttonEnterData.TabIndex = 1;
            this.buttonEnterData.Text = "Ingresar datos";
            this.buttonEnterData.UseVisualStyleBackColor = true;
            this.buttonEnterData.Click += new System.EventHandler(this.buttonEnterData_Click);
            // 
            // buttonSpecificDetails
            // 
            this.buttonSpecificDetails.Location = new System.Drawing.Point(479, 320);
            this.buttonSpecificDetails.Name = "buttonSpecificDetails";
            this.buttonSpecificDetails.Size = new System.Drawing.Size(165, 68);
            this.buttonSpecificDetails.TabIndex = 2;
            this.buttonSpecificDetails.Text = "Detalles especificos";
            this.buttonSpecificDetails.UseVisualStyleBackColor = true;
            this.buttonSpecificDetails.Click += new System.EventHandler(this.buttonSpecificDetails_Click);
            // 
            // listBoxEmpleados
            // 
            this.listBoxEmpleados.FormattingEnabled = true;
            this.listBoxEmpleados.ItemHeight = 20;
            this.listBoxEmpleados.Location = new System.Drawing.Point(131, 50);
            this.listBoxEmpleados.Name = "listBoxEmpleados";
            this.listBoxEmpleados.Size = new System.Drawing.Size(513, 224);
            this.listBoxEmpleados.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxEmpleados);
            this.Controls.Add(this.buttonSpecificDetails);
            this.Controls.Add(this.buttonEnterData);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonEnterData;
        private Button buttonSpecificDetails;
        private ListBox listBoxEmpleados;
    }
}