
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
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
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
            // 
            // btnCrearPlayList
            // 
            this.btnCrearPlayList.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCrearPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPlayList.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPlayList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearPlayList.Location = new System.Drawing.Point(575, 136);
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
            this.btnReproducir.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReproducir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReproducir.Location = new System.Drawing.Point(575, 266);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(143, 49);
            this.btnReproducir.TabIndex = 2;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = false;
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
            this.btnModificarPlayList.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPlayList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarPlayList.Location = new System.Drawing.Point(575, 334);
            this.btnModificarPlayList.Name = "btnModificarPlayList";
            this.btnModificarPlayList.Size = new System.Drawing.Size(143, 49);
            this.btnModificarPlayList.TabIndex = 4;
            this.btnModificarPlayList.Text = "Modificar";
            this.btnModificarPlayList.UseVisualStyleBackColor = false;
            this.btnModificarPlayList.Click += new System.EventHandler(this.btnModificarPlayList_Click);
            // 
            // txtNombrePlayList
            // 
            this.txtNombrePlayList.Location = new System.Drawing.Point(575, 202);
            this.txtNombrePlayList.Name = "txtNombrePlayList";
            this.txtNombrePlayList.Size = new System.Drawing.Size(143, 27);
            this.txtNombrePlayList.TabIndex = 5;
            this.txtNombrePlayList.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(605, 266);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(143, 49);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = global::PresentacionEscritorio.Properties.Resources.Atras;
            this.btnCancelar.Location = new System.Drawing.Point(543, 266);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 45);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.Location = new System.Drawing.Point(571, 150);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(151, 21);
            this.lblInstruccion.TabIndex = 8;
            this.lblInstruccion.Text = "Ingrese un nombre";
            this.lblInstruccion.Visible = false;
            // 
            // IUListasReproduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(760, 497);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombrePlayList);
            this.Controls.Add(this.btnModificarPlayList);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.btnCrearPlayList);
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
    }
}