
namespace PresentacionEscritorio
{
    partial class IUMenuListasReproduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IUMenuListasReproduccion));
            this.btnAñadirCancion = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.lblNombrePlayList = new System.Windows.Forms.Label();
            this.btnAgregarCancion = new System.Windows.Forms.Button();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.btnEliminarCancion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAñadirCancion
            // 
            this.btnAñadirCancion.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAñadirCancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirCancion.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirCancion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAñadirCancion.Location = new System.Drawing.Point(566, 194);
            this.btnAñadirCancion.Name = "btnAñadirCancion";
            this.btnAñadirCancion.Size = new System.Drawing.Size(140, 44);
            this.btnAñadirCancion.TabIndex = 1;
            this.btnAñadirCancion.Text = "Añadir canción";
            this.btnAñadirCancion.UseVisualStyleBackColor = false;
            this.btnAñadirCancion.Click += new System.EventHandler(this.btnAñadirCancion_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Image = global::PresentacionEscritorio.Properties.Resources.Atras;
            this.btnAtras.Location = new System.Drawing.Point(12, 10);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(54, 50);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAtras.TabIndex = 2;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblNombrePlayList
            // 
            this.lblNombrePlayList.AutoSize = true;
            this.lblNombrePlayList.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlayList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombrePlayList.Location = new System.Drawing.Point(81, 18);
            this.lblNombrePlayList.Name = "lblNombrePlayList";
            this.lblNombrePlayList.Size = new System.Drawing.Size(39, 34);
            this.lblNombrePlayList.TabIndex = 3;
            this.lblNombrePlayList.Text = "--";
            // 
            // btnAgregarCancion
            // 
            this.btnAgregarCancion.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAgregarCancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCancion.Enabled = false;
            this.btnAgregarCancion.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCancion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarCancion.Location = new System.Drawing.Point(566, 259);
            this.btnAgregarCancion.Name = "btnAgregarCancion";
            this.btnAgregarCancion.Size = new System.Drawing.Size(140, 44);
            this.btnAgregarCancion.TabIndex = 4;
            this.btnAgregarCancion.Text = "Agregar";
            this.btnAgregarCancion.UseVisualStyleBackColor = false;
            this.btnAgregarCancion.Click += new System.EventHandler(this.btnAgregarCancion_Click);
            // 
            // lstCanciones
            // 
            this.lstCanciones.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstCanciones.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCanciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.ItemHeight = 21;
            this.lstCanciones.Location = new System.Drawing.Point(13, 72);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(524, 445);
            this.lstCanciones.TabIndex = 5;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged);
            // 
            // btnEliminarCancion
            // 
            this.btnEliminarCancion.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEliminarCancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCancion.Enabled = false;
            this.btnEliminarCancion.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCancion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarCancion.Location = new System.Drawing.Point(566, 320);
            this.btnEliminarCancion.Name = "btnEliminarCancion";
            this.btnEliminarCancion.Size = new System.Drawing.Size(140, 44);
            this.btnEliminarCancion.TabIndex = 6;
            this.btnEliminarCancion.Text = "Eliminar canción";
            this.btnEliminarCancion.UseVisualStyleBackColor = false;
            this.btnEliminarCancion.Click += new System.EventHandler(this.btnEliminarCancion_Click);
            // 
            // IUMenuListasReproduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(726, 543);
            this.Controls.Add(this.btnEliminarCancion);
            this.Controls.Add(this.lstCanciones);
            this.Controls.Add(this.btnAgregarCancion);
            this.Controls.Add(this.lblNombrePlayList);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAñadirCancion);
            this.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "IUMenuListasReproduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Listas Reproduccion";
            this.Load += new System.EventHandler(this.IUMenuListasReproduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAñadirCancion;
        private System.Windows.Forms.PictureBox btnAtras;
        private System.Windows.Forms.Label lblNombrePlayList;
        private System.Windows.Forms.Button btnAgregarCancion;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.Button btnEliminarCancion;
    }
}