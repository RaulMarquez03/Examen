namespace Examen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxDepartmane = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxAge = new System.Windows.Forms.MaskedTextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(249, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 5;
            // 
            // comboBoxDepartmane
            // 
            this.comboBoxDepartmane.FormattingEnabled = true;
            this.comboBoxDepartmane.Items.AddRange(new object[] {
            "Informatica",
            "Mantenimiento",
            "Limpieza"});
            this.comboBoxDepartmane.Location = new System.Drawing.Point(242, 95);
            this.comboBoxDepartmane.Name = "comboBoxDepartmane";
            this.comboBoxDepartmane.Size = new System.Drawing.Size(151, 28);
            this.comboBoxDepartmane.TabIndex = 6;
            // 
            // maskedTextBoxAge
            // 
            this.maskedTextBoxAge.Location = new System.Drawing.Point(249, 135);
            this.maskedTextBoxAge.Mask = "99";
            this.maskedTextBoxAge.MaximumSize = new System.Drawing.Size(200, 0);
            this.maskedTextBoxAge.Name = "maskedTextBoxAge";
            this.maskedTextBoxAge.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBoxAge.TabIndex = 7;
            this.maskedTextBoxAge.ValidatingType = typeof(int);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(84, 306);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(231, 77);
            this.buttonSend.TabIndex = 18;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 78);
            this.button1.TabIndex = 19;
            this.button1.Text = "Ver lista empleados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.maskedTextBoxAge);
            this.Controls.Add(this.comboBoxDepartmane);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSend;
        private Button button1;
        private ListBox listBox1;
        public TextBox textBoxName;
        public ComboBox comboBoxDepartmane;
        public MaskedTextBox maskedTextBoxAge;
    }
}