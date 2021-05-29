
namespace PresentacionEscritorio
{
    partial class IUListasReproduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IUListasReproduccion));
            this.lslListasReproduccion = new System.Windows.Forms.ListBox();
            this.btnCrearPlayList = new System.Windows.Forms.Button();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.btnModificarPlayList = new System.Windows.Forms.Button();
            this.txtNombrePlayList = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.pnlIngresarNombre = new System.Windows.Forms.Panel();
            this.pnlMenuBotones = new System.Windows.Forms.Panel();
            this.btnEliminarPlayList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            this.pnlIngresarNombre.SuspendLayout();
            this.pnlMenuBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lslListasReproduccion
            // 
            this.lslListasReproduccion.BackColor = System.Drawing.SystemColors.InfoText;
            this.lslListasReproduccion.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lslListasReproduccion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lslListasReproduccion.FormattingEnabled = true;
            this.lslListasReproduccion.ItemHeight = 31;
            this.lslListasReproduccion.Location = new System.Drawing.Point(12, 85);
            this.lslListasReproduccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lslListasReproduccion.Name = "lslListasReproduccion";
            this.lslListasReproduccion.Size = new System.Drawing.Size(515, 376);
            this.lslListasReproduccion.TabIndex = 0;
            this.lslListasReproduccion.SelectedIndexChanged += new System.EventHandler(this.lslListasReproduccion_SelectedIndexChanged);
            // 
            // btnCrearPlayList
            // 
            this.btnCrearPlayList.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCrearPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPlayList.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPlayList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearPlayList.Location = new System.Drawing.Point(30, 13);
            this.btnCrearPlayList.Name = "btnCrearPlayList";
            this.btnCrearPlayList.Size = new System.Drawing.Size(143, 49);
            this.btnCrearPlayList.TabIndex = 1;
            this.btnCrearPlayList.Text = "Crear playlist";
            this.btnCrearPlayList.UseVisualStyleBackColor = false;
            this.btnCrearPlayList.Click += new System.EventHandler(this.btnCrearPlayList_Click);
            // 
            // btnReproducir
            // 
            this.btnReproducir.BackColor = System.Drawing.Color.MediumBlue;
            this.btnReproducir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReproducir.Enabled = false;
            this.btnReproducir.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReproducir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReproducir.Location = new System.Drawing.Point(30, 167);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(143, 49);
            this.btnReproducir.TabIndex = 2;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = false;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::PresentacionEscritorio.Properties.Resources.Atras;
            this.btnAtras.Location = new System.Drawing.Point(13, 13);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(45, 45);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAtras.TabIndex = 3;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnModificarPlayList
            // 
            this.btnModificarPlayList.BackColor = System.Drawing.Color.MediumBlue;
            this.btnModificarPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarPlayList.Enabled = false;
            this.btnModificarPlayList.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPlayList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarPlayList.Location = new System.Drawing.Point(30, 228);
            this.btnModificarPlayList.Name = "btnModificarPlayList";
            this.btnModificarPlayList.Size = new System.Drawing.Size(143, 49);
            this.btnModificarPlayList.TabIndex = 4;
            this.btnModificarPlayList.Text = "Modificar";
            this.btnModificarPlayList.UseVisualStyleBackColor = false;
            this.btnModificarPlayList.Click += new System.EventHandler(this.btnModificarPlayList_Click);
            // 
            // txtNombrePlayList
            // 
            this.txtNombrePlayList.Location = new System.Drawing.Point(37, 61);
            this.txtNombrePlayList.Name = "txtNombrePlayList";
            this.txtNombrePlayList.Size = new System.Drawing.Size(143, 27);
            this.txtNombrePlayList.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(73, 107);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(143, 49);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = global::PresentacionEscritorio.Properties.Resources.Atras;
            this.btnCancelar.Location = new System.Drawing.Point(6, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(49, 49);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.Location = new System.Drawing.Point(31, 19);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(151, 21);
            this.lblInstruccion.TabIndex = 8;
            this.lblInstruccion.Text = "Ingrese un nombre";
            // 
            // pnlIngresarNombre
            // 
            this.pnlIngresarNombre.Controls.Add(this.lblInstruccion);
            this.pnlIngresarNombre.Controls.Add(this.btnCancelar);
            this.pnlIngresarNombre.Controls.Add(this.txtNombrePlayList);
            this.pnlIngresarNombre.Controls.Add(this.btnAceptar);
            this.pnlIngresarNombre.Location = new System.Drawing.Point(533, 157);
            this.pnlIngresarNombre.Name = "pnlIngresarNombre";
            this.pnlIngresarNombre.Size = new System.Drawing.Size(225, 169);
            this.pnlIngresarNombre.TabIndex = 9;
            this.pnlIngresarNombre.Visible = false;
            this.pnlIngresarNombre.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlMenuBotones
            // 
            this.pnlMenuBotones.Controls.Add(this.btnEliminarPlayList);
            this.pnlMenuBotones.Controls.Add(this.btnCrearPlayList);
            this.pnlMenuBotones.Controls.Add(this.btnReproducir);
            this.pnlMenuBotones.Controls.Add(this.btnModificarPlayList);
            this.pnlMenuBotones.Location = new System.Drawing.Point(544, 107);
            this.pnlMenuBotones.Name = "pnlMenuBotones";
            this.pnlMenuBotones.Size = new System.Drawing.Size(200, 354);
            this.pnlMenuBotones.TabIndex = 10;
            // 
            // btnEliminarPlayList
            // 
            this.btnEliminarPlayList.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEliminarPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPlayList.Enabled = false;
            this.btnEliminarPlayList.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPlayList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPlayList.Location = new System.Drawing.Point(30, 287);
            this.btnEliminarPlayList.Name = "btnEliminarPlayList";
            this.btnEliminarPlayList.Size = new System.Drawing.Size(143, 49);
            this.btnEliminarPlayList.TabIndex = 5;
            this.btnEliminarPlayList.Text = "Eliminar";
            this.btnEliminarPlayList.UseVisualStyleBackColor = false;
            this.btnEliminarPlayList.Click += new System.EventHandler(this.btnEliminarPlayList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tus Play List";
            // 
            // IUListasReproduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(771, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlMenuBotones);
            this.Controls.Add(this.pnlIngresarNombre);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lslListasReproduccion);
            this.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "IUListasReproduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IUListasReproduccion";
            this.Load += new System.EventHandler(this.IUListasReproduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            this.pnlIngresarNombre.ResumeLayout(false);
            this.pnlIngresarNombre.PerformLayout();
            this.pnlMenuBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lslListasReproduccion;
        private System.Windows.Forms.Button btnCrearPlayList;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.PictureBox btnAtras;
        private System.Windows.Forms.Button btnModificarPlayList;
        private System.Windows.Forms.TextBox txtNombrePlayList;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Panel pnlIngresarNombre;
        private System.Windows.Forms.Panel pnlMenuBotones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarPlayList;
    }
}