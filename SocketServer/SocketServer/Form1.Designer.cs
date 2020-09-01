namespace SocketServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.puerto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.encender = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.mensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // puerto
            // 
            this.puerto.Location = new System.Drawing.Point(59, 40);
            this.puerto.Name = "puerto";
            this.puerto.Size = new System.Drawing.Size(244, 20);
            this.puerto.TabIndex = 1;
            this.puerto.Text = "9000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puerto:";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(59, 12);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(244, 20);
            this.ip.TabIndex = 3;
            this.ip.Text = "127.0.0.1";
            // 
            // encender
            // 
            this.encender.Location = new System.Drawing.Point(13, 73);
            this.encender.Name = "encender";
            this.encender.Size = new System.Drawing.Size(118, 23);
            this.encender.TabIndex = 4;
            this.encender.Text = "Encender Server";
            this.encender.UseVisualStyleBackColor = true;
            this.encender.Click += new System.EventHandler(this.encender_Click);
            // 
            // apagar
            // 
            this.apagar.Enabled = false;
            this.apagar.Location = new System.Drawing.Point(198, 73);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(105, 23);
            this.apagar.TabIndex = 5;
            this.apagar.Text = "Apagar Server";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // mensaje
            // 
            this.mensaje.Location = new System.Drawing.Point(12, 113);
            this.mensaje.Multiline = true;
            this.mensaje.Name = "mensaje";
            this.mensaje.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mensaje.Size = new System.Drawing.Size(291, 136);
            this.mensaje.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 261);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.encender);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.puerto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SERVER SOCKET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox puerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Button encender;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.TextBox mensaje;
    }
}

