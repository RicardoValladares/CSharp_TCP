﻿namespace SocketCliente
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.mensaje = new System.Windows.Forms.TextBox();
            this.enviar = new System.Windows.Forms.Button();
            this.ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.puerto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textocliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mensaje
            // 
            this.mensaje.Location = new System.Drawing.Point(10, 123);
            this.mensaje.Multiline = true;
            this.mensaje.Name = "mensaje";
            this.mensaje.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mensaje.Size = new System.Drawing.Size(291, 136);
            this.mensaje.TabIndex = 13;
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(11, 94);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(290, 23);
            this.enviar.TabIndex = 11;
            this.enviar.Text = "Enviar Data";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(68, 9);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(235, 20);
            this.ip.TabIndex = 10;
            this.ip.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Puerto:";
            // 
            // puerto
            // 
            this.puerto.Location = new System.Drawing.Point(68, 37);
            this.puerto.Name = "puerto";
            this.puerto.Size = new System.Drawing.Size(235, 20);
            this.puerto.TabIndex = 8;
            this.puerto.Text = "9000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP:";
            // 
            // textocliente
            // 
            this.textocliente.Location = new System.Drawing.Point(68, 68);
            this.textocliente.Name = "textocliente";
            this.textocliente.Size = new System.Drawing.Size(233, 20);
            this.textocliente.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mensaje:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 278);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textocliente);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.puerto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SOCKET CLIENTE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mensaje;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox puerto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textocliente;
        private System.Windows.Forms.Label label3;

    }
}

