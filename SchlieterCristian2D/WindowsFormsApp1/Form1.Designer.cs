namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "&Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txt1
            // 
            this.txt1.AccessibleDescription = "";
            this.txt1.Location = new System.Drawing.Point(70, 37);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(177, 20);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(70, 76);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(177, 20);
            this.txt2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "&Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dir. correo electronico";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(70, 115);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(177, 20);
            this.txt3.TabIndex = 3;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Checked = true;
            this.chk1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chk1.Location = new System.Drawing.Point(70, 141);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(193, 17);
            this.chk1.TabIndex = 4;
            this.chk1.Text = "Quiero usar mi dir. actual de correo ";
            this.chk1.ThreeState = true;
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(70, 177);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(177, 20);
            this.txt4.TabIndex = 5;
            // 
            // cmb1
            // 
            this.cmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "011",
            "2625",
            "2450",
            "1220"});
            this.cmb1.Location = new System.Drawing.Point(55, 216);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(46, 21);
            this.cmb1.TabIndex = 6;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(117, 217);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(130, 20);
            this.txt5.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numero de celular";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(55, 299);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(34, 17);
            this.rdb1.TabIndex = 9;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "M";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(129, 299);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(31, 17);
            this.rdb2.TabIndex = 10;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "F";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(202, 299);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(45, 17);
            this.rdb3.TabIndex = 11;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "Otro";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sexo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 366);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Registrarse";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txt1;
    private System.Windows.Forms.TextBox txt2;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txt3;
    private System.Windows.Forms.CheckBox chk1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txt4;
    private System.Windows.Forms.ComboBox cmb1;
    private System.Windows.Forms.TextBox txt5;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.RadioButton rdb1;
    private System.Windows.Forms.RadioButton rdb2;
    private System.Windows.Forms.RadioButton rdb3;
    private System.Windows.Forms.Label label6;
  }
}

