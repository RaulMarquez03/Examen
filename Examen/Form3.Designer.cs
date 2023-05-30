namespace Examen
{
    partial class Form3
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
            this.buttonEnterData2 = new System.Windows.Forms.Button();
            this.buttonEmployeList = new System.Windows.Forms.Button();
            this.checkBoxOrden = new System.Windows.Forms.CheckBox();
            this.checkBoxTeamWork = new System.Windows.Forms.CheckBox();
            this.checkBoxPuntuality = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.radioButtonMarried = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSave2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonEnterData2
            // 
            this.buttonEnterData2.Location = new System.Drawing.Point(135, 316);
            this.buttonEnterData2.Name = "buttonEnterData2";
            this.buttonEnterData2.Size = new System.Drawing.Size(137, 61);
            this.buttonEnterData2.TabIndex = 0;
            this.buttonEnterData2.Text = "Ingresar datos";
            this.buttonEnterData2.UseVisualStyleBackColor = true;
            this.buttonEnterData2.Click += new System.EventHandler(this.buttonEnterData2_Click);
            // 
            // buttonEmployeList
            // 
            this.buttonEmployeList.Location = new System.Drawing.Point(498, 316);
            this.buttonEmployeList.Name = "buttonEmployeList";
            this.buttonEmployeList.Size = new System.Drawing.Size(143, 61);
            this.buttonEmployeList.TabIndex = 1;
            this.buttonEmployeList.Text = "Ver lista empleados";
            this.buttonEmployeList.UseVisualStyleBackColor = true;
            this.buttonEmployeList.Click += new System.EventHandler(this.buttonEmployeList_Click);
            // 
            // checkBoxOrden
            // 
            this.checkBoxOrden.AutoSize = true;
            this.checkBoxOrden.Location = new System.Drawing.Point(106, 179);
            this.checkBoxOrden.Name = "checkBoxOrden";
            this.checkBoxOrden.Size = new System.Drawing.Size(72, 24);
            this.checkBoxOrden.TabIndex = 21;
            this.checkBoxOrden.Text = "Orden";
            this.checkBoxOrden.UseVisualStyleBackColor = true;
            // 
            // checkBoxTeamWork
            // 
            this.checkBoxTeamWork.AutoSize = true;
            this.checkBoxTeamWork.Location = new System.Drawing.Point(106, 134);
            this.checkBoxTeamWork.Name = "checkBoxTeamWork";
            this.checkBoxTeamWork.Size = new System.Drawing.Size(150, 24);
            this.checkBoxTeamWork.TabIndex = 20;
            this.checkBoxTeamWork.Text = "trabajo en equipo";
            this.checkBoxTeamWork.UseVisualStyleBackColor = true;
            // 
            // checkBoxPuntuality
            // 
            this.checkBoxPuntuality.AutoSize = true;
            this.checkBoxPuntuality.Location = new System.Drawing.Point(106, 91);
            this.checkBoxPuntuality.Name = "checkBoxPuntuality";
            this.checkBoxPuntuality.Size = new System.Drawing.Size(96, 24);
            this.checkBoxPuntuality.TabIndex = 19;
            this.checkBoxPuntuality.Text = "Puntuality";
            this.checkBoxPuntuality.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Habilidades ";
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Location = new System.Drawing.Point(338, 100);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(78, 24);
            this.radioButtonSingle.TabIndex = 24;
            this.radioButtonSingle.TabStop = true;
            this.radioButtonSingle.Text = "Soltero";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            // 
            // radioButtonMarried
            // 
            this.radioButtonMarried.AutoSize = true;
            this.radioButtonMarried.Location = new System.Drawing.Point(337, 145);
            this.radioButtonMarried.Name = "radioButtonMarried";
            this.radioButtonMarried.Size = new System.Drawing.Size(79, 24);
            this.radioButtonMarried.TabIndex = 23;
            this.radioButtonMarried.TabStop = true;
            this.radioButtonMarried.Text = "Casado";
            this.radioButtonMarried.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Estado civil";
            // 
            // buttonSave2
            // 
            this.buttonSave2.Location = new System.Drawing.Point(328, 234);
            this.buttonSave2.Name = "buttonSave2";
            this.buttonSave2.Size = new System.Drawing.Size(94, 29);
            this.buttonSave2.TabIndex = 25;
            this.buttonSave2.Text = "Save";
            this.buttonSave2.UseVisualStyleBackColor = true;
            this.buttonSave2.Click += new System.EventHandler(this.buttonSave2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Html",
            "mysql",
            "java",
            "c#"});
            this.listBox1.Location = new System.Drawing.Point(554, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 104);
            this.listBox1.TabIndex = 26;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonSave2);
            this.Controls.Add(this.radioButtonSingle);
            this.Controls.Add(this.radioButtonMarried);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxOrden);
            this.Controls.Add(this.checkBoxTeamWork);
            this.Controls.Add(this.checkBoxPuntuality);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonEmployeList);
            this.Controls.Add(this.buttonEnterData2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEnterData2;
        private Button buttonEmployeList;
        private CheckBox checkBoxOrden;
        private CheckBox checkBoxTeamWork;
        private CheckBox checkBoxPuntuality;
        private Label label5;
        private RadioButton radioButtonSingle;
        private RadioButton radioButtonMarried;
        private Label label4;
        private Button buttonSave2;
        private ListBox listBox1;
    }
}