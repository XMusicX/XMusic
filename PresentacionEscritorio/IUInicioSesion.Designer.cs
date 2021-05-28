
namespace PresentacionEscritorio
{
    partial class IUInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IUInicioSesion));
            this.pnInicio = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRecuperarContraseña = new System.Windows.Forms.Label();
            this.lblCrearCuenta = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInicioSesion = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnInicio
            // 
            this.pnInicio.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pnInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnInicio.Controls.Add(this.label3);
            this.pnInicio.Controls.Add(this.btnSalir);
            this.pnInicio.Controls.Add(this.lblRecuperarContraseña);
            this.pnInicio.Controls.Add(this.lblCrearCuenta);
            this.pnInicio.Controls.Add(this.btnIngresar);
            this.pnInicio.Controls.Add(this.txtContraseña);
            this.pnInicio.Controls.Add(this.label2);
            this.pnInicio.Controls.Add(this.txtCorreoElectronico);
            this.pnInicio.Controls.Add(this.label1);
            this.pnInicio.Controls.Add(this.lblInicioSesion);
            this.pnInicio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pnInicio.Location = new System.Drawing.Point(402, 71);
            this.pnInicio.Name = "pnInicio";
            this.pnInicio.Size = new System.Drawing.Size(494, 545);
            this.pnInicio.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(47, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Music";
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSalir.Image = global::PresentacionEscritorio.Properties.Resources.X2__1_;
            this.btnSalir.Location = new System.Drawing.Point(3, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(38, 40);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblRecuperarContraseña
            // 
            this.lblRecuperarContraseña.AutoSize = true;
            this.lblRecuperarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRecuperarContraseña.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperarContraseña.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblRecuperarContraseña.Location = new System.Drawing.Point(133, 474);
            this.lblRecuperarContraseña.Name = "lblRecuperarContraseña";
            this.lblRecuperarContraseña.Size = new System.Drawing.Size(220, 25);
            this.lblRecuperarContraseña.TabIndex = 7;
            this.lblRecuperarContraseña.Text = "Recuperar contraseña";
            this.lblRecuperarContraseña.Click += new System.EventHandler(this.lblRecuperarContraseña_Click);
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCrearCuenta.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCuenta.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblCrearCuenta.Location = new System.Drawing.Point(97, 423);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(298, 25);
            this.lblCrearCuenta.TabIndex = 6;
            this.lblCrearCuenta.Text = "¿No tienes cuenta? Crea una";
            this.lblCrearCuenta.Click += new System.EventHandler(this.lblCrearCuenta_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.MintCream;
            this.btnIngresar.Location = new System.Drawing.Point(161, 331);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(165, 68);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(44, 266);
            this.txtContraseña.MaxLength = 5;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(407, 32);
            this.txtContraseña.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(182, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(44, 161);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(407, 32);
            this.txtCorreoElectronico.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(156, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo electrónico";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.AutoSize = true;
            this.lblInicioSesion.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioSesion.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblInicioSesion.Location = new System.Drawing.Point(155, 50);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(198, 31);
            this.lblInicioSesion.TabIndex = 0;
            this.lblInicioSesion.Text = "Inicio de sesión";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::PresentacionEscritorio.Properties.Resources.logoXmusic;
            this.imgLogo.Location = new System.Drawing.Point(1052, 469);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(200, 200);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // IUInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.pnInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IUInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.pnInicio.ResumeLayout(false);
            this.pnInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInicioSesion;
        private System.Windows.Forms.Label lblRecuperarContraseña;
        private System.Windows.Forms.Label lblCrearCuenta;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
    }
}