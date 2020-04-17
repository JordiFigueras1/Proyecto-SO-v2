namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.Conectarbtn = new System.Windows.Forms.Button();
            this.Desconectarbtn = new System.Windows.Forms.Button();
            this.UsuarioRegText = new System.Windows.Forms.TextBox();
            this.UsuarioReg = new System.Windows.Forms.Label();
            this.ContraseñaReg = new System.Windows.Forms.Label();
            this.ContraseñaRegText = new System.Windows.Forms.TextBox();
            this.ContraseñaLogText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsuarioLog = new System.Windows.Forms.Label();
            this.UsuarioLogText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Regbtn = new System.Windows.Forms.Button();
            this.Logbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ConsultaRegbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(116, 31);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(164, 20);
            this.nombre.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(356, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 282);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(116, 91);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(166, 17);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Dime la longitud de mi nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(116, 68);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(156, 17);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Dime si mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // Conectarbtn
            // 
            this.Conectarbtn.Location = new System.Drawing.Point(12, 12);
            this.Conectarbtn.Name = "Conectarbtn";
            this.Conectarbtn.Size = new System.Drawing.Size(75, 23);
            this.Conectarbtn.TabIndex = 9;
            this.Conectarbtn.Text = "Conectar";
            this.Conectarbtn.UseVisualStyleBackColor = true;
            this.Conectarbtn.Click += new System.EventHandler(this.Conectarbtn_Click);
            // 
            // Desconectarbtn
            // 
            this.Desconectarbtn.Location = new System.Drawing.Point(108, 12);
            this.Desconectarbtn.Name = "Desconectarbtn";
            this.Desconectarbtn.Size = new System.Drawing.Size(81, 23);
            this.Desconectarbtn.TabIndex = 9;
            this.Desconectarbtn.Text = "Desconectar";
            this.Desconectarbtn.UseVisualStyleBackColor = true;
            this.Desconectarbtn.Click += new System.EventHandler(this.Desconectarbtn_Click);
            // 
            // UsuarioRegText
            // 
            this.UsuarioRegText.Location = new System.Drawing.Point(25, 105);
            this.UsuarioRegText.Name = "UsuarioRegText";
            this.UsuarioRegText.Size = new System.Drawing.Size(90, 20);
            this.UsuarioRegText.TabIndex = 9;
            // 
            // UsuarioReg
            // 
            this.UsuarioReg.AutoSize = true;
            this.UsuarioReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioReg.Location = new System.Drawing.Point(37, 85);
            this.UsuarioReg.Name = "UsuarioReg";
            this.UsuarioReg.Size = new System.Drawing.Size(57, 17);
            this.UsuarioReg.TabIndex = 9;
            this.UsuarioReg.Text = "Usuario";
            // 
            // ContraseñaReg
            // 
            this.ContraseñaReg.AutoSize = true;
            this.ContraseñaReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaReg.Location = new System.Drawing.Point(34, 137);
            this.ContraseñaReg.Name = "ContraseñaReg";
            this.ContraseñaReg.Size = new System.Drawing.Size(81, 17);
            this.ContraseñaReg.TabIndex = 11;
            this.ContraseñaReg.Text = "Contraseña";
            // 
            // ContraseñaRegText
            // 
            this.ContraseñaRegText.Location = new System.Drawing.Point(25, 157);
            this.ContraseñaRegText.Name = "ContraseñaRegText";
            this.ContraseñaRegText.Size = new System.Drawing.Size(90, 20);
            this.ContraseñaRegText.TabIndex = 12;
            // 
            // ContraseñaLogText
            // 
            this.ContraseñaLogText.Location = new System.Drawing.Point(186, 157);
            this.ContraseñaLogText.Name = "ContraseñaLogText";
            this.ContraseñaLogText.Size = new System.Drawing.Size(90, 20);
            this.ContraseñaLogText.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Contraseña";
            // 
            // UsuarioLog
            // 
            this.UsuarioLog.AutoSize = true;
            this.UsuarioLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLog.Location = new System.Drawing.Point(198, 85);
            this.UsuarioLog.Name = "UsuarioLog";
            this.UsuarioLog.Size = new System.Drawing.Size(57, 17);
            this.UsuarioLog.TabIndex = 13;
            this.UsuarioLog.Text = "Usuario";
            // 
            // UsuarioLogText
            // 
            this.UsuarioLogText.Location = new System.Drawing.Point(186, 105);
            this.UsuarioLogText.Name = "UsuarioLogText";
            this.UsuarioLogText.Size = new System.Drawing.Size(90, 20);
            this.UsuarioLogText.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Registro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Log-in";
            // 
            // Regbtn
            // 
            this.Regbtn.Location = new System.Drawing.Point(33, 190);
            this.Regbtn.Name = "Regbtn";
            this.Regbtn.Size = new System.Drawing.Size(75, 23);
            this.Regbtn.TabIndex = 19;
            this.Regbtn.Text = "Register";
            this.Regbtn.UseVisualStyleBackColor = true;
            this.Regbtn.Click += new System.EventHandler(this.Regbtn_Click);
            // 
            // Logbtn
            // 
            this.Logbtn.Location = new System.Drawing.Point(194, 193);
            this.Logbtn.Name = "Logbtn";
            this.Logbtn.Size = new System.Drawing.Size(75, 23);
            this.Logbtn.TabIndex = 20;
            this.Logbtn.Text = "Log-in";
            this.Logbtn.UseVisualStyleBackColor = true;
            this.Logbtn.Click += new System.EventHandler(this.Logbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Consulta Nº Registrados";
            // 
            // ConsultaRegbtn
            // 
            this.ConsultaRegbtn.Location = new System.Drawing.Point(506, 53);
            this.ConsultaRegbtn.Name = "ConsultaRegbtn";
            this.ConsultaRegbtn.Size = new System.Drawing.Size(75, 23);
            this.ConsultaRegbtn.TabIndex = 22;
            this.ConsultaRegbtn.Text = "Enviar";
            this.ConsultaRegbtn.UseVisualStyleBackColor = true;
            this.ConsultaRegbtn.Click += new System.EventHandler(this.ConsultaRegbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 562);
            this.Controls.Add(this.ConsultaRegbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Logbtn);
            this.Controls.Add(this.Regbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ContraseñaLogText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsuarioLog);
            this.Controls.Add(this.UsuarioLogText);
            this.Controls.Add(this.ContraseñaRegText);
            this.Controls.Add(this.ContraseñaReg);
            this.Controls.Add(this.UsuarioReg);
            this.Controls.Add(this.UsuarioRegText);
            this.Controls.Add(this.Desconectarbtn);
            this.Controls.Add(this.Conectarbtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.Button Conectarbtn;
        private System.Windows.Forms.Button Desconectarbtn;
        private System.Windows.Forms.TextBox UsuarioRegText;
        private System.Windows.Forms.Label UsuarioReg;
        private System.Windows.Forms.Label ContraseñaReg;
        private System.Windows.Forms.TextBox ContraseñaRegText;
        private System.Windows.Forms.TextBox ContraseñaLogText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UsuarioLog;
        private System.Windows.Forms.TextBox UsuarioLogText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Regbtn;
        private System.Windows.Forms.Button Logbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConsultaRegbtn;
    }
}

