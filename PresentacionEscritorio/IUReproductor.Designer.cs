
namespace PresentacionEscritorio
{
    partial class IUReproductor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IUReproductor));
            this.macCancion = new XComponent.SliderBar.MACTrackBar();
            this.macVolumen = new XComponent.SliderBar.MACTrackBar();
            this.lblNombreCancion = new System.Windows.Forms.Label();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.btnSubirCancion = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAleatorio = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnVolumen = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCancionSiguiente = new System.Windows.Forms.PictureBox();
            this.btnReproducir = new System.Windows.Forms.PictureBox();
            this.btnCancionAnterior = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListaCanciones = new System.Windows.Forms.Label();
            this.btnTodasCanciones = new System.Windows.Forms.Button();
            this.btnEliminarCancion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAleatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancionSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReproducir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancionAnterior)).BeginInit();
            this.SuspendLayout();
            // 
            // macCancion
            // 
            this.macCancion.BackColor = System.Drawing.Color.Transparent;
            this.macCancion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macCancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.macCancion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macCancion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macCancion.IndentHeight = 6;
            this.macCancion.Location = new System.Drawing.Point(12, 535);
            this.macCancion.Maximum = 100;
            this.macCancion.Minimum = 0;
            this.macCancion.Name = "macCancion";
            this.macCancion.Size = new System.Drawing.Size(1240, 32);
            this.macCancion.TabIndex = 0;
            this.macCancion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macCancion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macCancion.TickHeight = 4;
            this.macCancion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macCancion.TrackerColor = System.Drawing.Color.MediumBlue;
            this.macCancion.TrackerSize = new System.Drawing.Size(20, 20);
            this.macCancion.TrackLineColor = System.Drawing.Color.SlateGray;
            this.macCancion.TrackLineHeight = 10;
            this.macCancion.TrackLineSelectedColor = System.Drawing.Color.MediumBlue;
            this.macCancion.Value = 0;
            this.macCancion.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar1_ValueChanged);
            // 
            // macVolumen
            // 
            this.macVolumen.BackColor = System.Drawing.Color.Transparent;
            this.macVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.macVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macVolumen.IndentHeight = 6;
            this.macVolumen.Location = new System.Drawing.Point(977, 607);
            this.macVolumen.Maximum = 100;
            this.macVolumen.Minimum = 0;
            this.macVolumen.Name = "macVolumen";
            this.macVolumen.Size = new System.Drawing.Size(146, 28);
            this.macVolumen.TabIndex = 1;
            this.macVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macVolumen.TickHeight = 4;
            this.macVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macVolumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.macVolumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.macVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macVolumen.TrackLineHeight = 5;
            this.macVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macVolumen.Value = 0;
            this.macVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macVolumen_ValueChanged);
            // 
            // lblNombreCancion
            // 
            this.lblNombreCancion.AutoSize = true;
            this.lblNombreCancion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreCancion.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCancion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreCancion.Location = new System.Drawing.Point(358, 607);
            this.lblNombreCancion.MaximumSize = new System.Drawing.Size(1000, 25);
            this.lblNombreCancion.Name = "lblNombreCancion";
            this.lblNombreCancion.Size = new System.Drawing.Size(30, 25);
            this.lblNombreCancion.TabIndex = 8;
            this.lblNombreCancion.Text = "--";
            this.lblNombreCancion.Click += new System.EventHandler(this.lblNombreCancion_Click);
            // 
            // lstCanciones
            // 
            this.lstCanciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstCanciones.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCanciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.ItemHeight = 28;
            this.lstCanciones.Location = new System.Drawing.Point(23, 74);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(1032, 424);
            this.lstCanciones.TabIndex = 11;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged);
            // 
            // btnSubirCancion
            // 
            this.btnSubirCancion.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSubirCancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirCancion.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirCancion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubirCancion.Location = new System.Drawing.Point(1090, 113);
            this.btnSubirCancion.Name = "btnSubirCancion";
            this.btnSubirCancion.Size = new System.Drawing.Size(151, 46);
            this.btnSubirCancion.TabIndex = 12;
            this.btnSubirCancion.Text = "Añadir Canción";
            this.btnSubirCancion.UseVisualStyleBackColor = false;
            this.btnSubirCancion.Click += new System.EventHandler(this.btnSubirCancion_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.MediumBlue;
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Location = new System.Drawing.Point(1090, 277);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(151, 46);
            this.btnPerfil.TabIndex = 13;
            this.btnPerfil.Text = "Mi Perfil";
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.MediumBlue;
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlaylist.Location = new System.Drawing.Point(1090, 194);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(151, 46);
            this.btnPlaylist.TabIndex = 14;
            this.btnPlaylist.Text = "Mis Playlist";
            this.btnPlaylist.UseVisualStyleBackColor = false;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(1061, 432);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(195, 96);
            this.Reproductor.TabIndex = 16;
            this.Reproductor.Visible = false;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            this.Reproductor.Enter += new System.EventHandler(this.Reproductor_Enter);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAleatorio.Image = global::PresentacionEscritorio.Properties.Resources.btnNoAleatorio;
            this.btnAleatorio.Location = new System.Drawing.Point(268, 587);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(70, 70);
            this.btnAleatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAleatorio.TabIndex = 17;
            this.btnAleatorio.TabStop = false;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::PresentacionEscritorio.Properties.Resources.X2__1_;
            this.btnCerrar.Location = new System.Drawing.Point(1201, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnVolumen
            // 
            this.btnVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolumen.Image = global::PresentacionEscritorio.Properties.Resources.Volumen;
            this.btnVolumen.Location = new System.Drawing.Point(901, 587);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(70, 70);
            this.btnVolumen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolumen.TabIndex = 10;
            this.btnVolumen.TabStop = false;
            this.btnVolumen.Click += new System.EventHandler(this.btnVolumen_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PresentacionEscritorio.Properties.Resources.logoXmusic;
            this.pictureBox2.Location = new System.Drawing.Point(1129, 569);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnCancionSiguiente
            // 
            this.btnCancionSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancionSiguiente.Image = global::PresentacionEscritorio.Properties.Resources.btnSiguiente;
            this.btnCancionSiguiente.Location = new System.Drawing.Point(183, 587);
            this.btnCancionSiguiente.Name = "btnCancionSiguiente";
            this.btnCancionSiguiente.Size = new System.Drawing.Size(70, 70);
            this.btnCancionSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancionSiguiente.TabIndex = 4;
            this.btnCancionSiguiente.TabStop = false;
            this.btnCancionSiguiente.Click += new System.EventHandler(this.btnCancionSiguiente_Click);
            // 
            // btnReproducir
            // 
            this.btnReproducir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReproducir.Image = global::PresentacionEscritorio.Properties.Resources.btnPlay;
            this.btnReproducir.Location = new System.Drawing.Point(97, 587);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(70, 70);
            this.btnReproducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReproducir.TabIndex = 3;
            this.btnReproducir.TabStop = false;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnCancionAnterior
            // 
            this.btnCancionAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancionAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnCancionAnterior.Image")));
            this.btnCancionAnterior.Location = new System.Drawing.Point(12, 587);
            this.btnCancionAnterior.Name = "btnCancionAnterior";
            this.btnCancionAnterior.Size = new System.Drawing.Size(70, 70);
            this.btnCancionAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancionAnterior.TabIndex = 2;
            this.btnCancionAnterior.TabStop = false;
            this.btnCancionAnterior.Click += new System.EventHandler(this.btnCancionAnterior_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // lblListaCanciones
            // 
            this.lblListaCanciones.AutoSize = true;
            this.lblListaCanciones.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCanciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblListaCanciones.Location = new System.Drawing.Point(26, 23);
            this.lblListaCanciones.Name = "lblListaCanciones";
            this.lblListaCanciones.Size = new System.Drawing.Size(36, 31);
            this.lblListaCanciones.TabIndex = 19;
            this.lblListaCanciones.Text = "--";
            // 
            // btnTodasCanciones
            // 
            this.btnTodasCanciones.BackColor = System.Drawing.Color.MediumBlue;
            this.btnTodasCanciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodasCanciones.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodasCanciones.ForeColor = System.Drawing.Color.White;
            this.btnTodasCanciones.Location = new System.Drawing.Point(1090, 358);
            this.btnTodasCanciones.Name = "btnTodasCanciones";
            this.btnTodasCanciones.Size = new System.Drawing.Size(151, 46);
            this.btnTodasCanciones.TabIndex = 20;
            this.btnTodasCanciones.Text = "Todas las canciones";
            this.btnTodasCanciones.UseVisualStyleBackColor = false;
            this.btnTodasCanciones.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarCancion
            // 
            this.btnEliminarCancion.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEliminarCancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCancion.Enabled = false;
            this.btnEliminarCancion.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCancion.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCancion.Location = new System.Drawing.Point(1090, 432);
            this.btnEliminarCancion.Name = "btnEliminarCancion";
            this.btnEliminarCancion.Size = new System.Drawing.Size(151, 46);
            this.btnEliminarCancion.TabIndex = 21;
            this.btnEliminarCancion.Text = "Eliminar canción";
            this.btnEliminarCancion.UseVisualStyleBackColor = false;
            this.btnEliminarCancion.Click += new System.EventHandler(this.btnEliminarCancion_Click);
            // 
            // IUReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnEliminarCancion);
            this.Controls.Add(this.btnTodasCanciones);
            this.Controls.Add(this.lblListaCanciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.Reproductor);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnPlaylist);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnSubirCancion);
            this.Controls.Add(this.lstCanciones);
            this.Controls.Add(this.btnVolumen);
            this.Controls.Add(this.lblNombreCancion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCancionSiguiente);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.btnCancionAnterior);
            this.Controls.Add(this.macVolumen);
            this.Controls.Add(this.macCancion);
            this.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "IUReproductor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IUReproductor";
            this.Activated += new System.EventHandler(this.IUReproductor_Activated);
            this.Load += new System.EventHandler(this.IUReproductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAleatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancionSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReproducir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancionAnterior)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XComponent.SliderBar.MACTrackBar macCancion;
        private XComponent.SliderBar.MACTrackBar macVolumen;
        private System.Windows.Forms.PictureBox btnCancionAnterior;
        private System.Windows.Forms.PictureBox btnReproducir;
        private System.Windows.Forms.PictureBox btnCancionSiguiente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNombreCancion;
        private System.Windows.Forms.PictureBox btnVolumen;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.Button btnSubirCancion;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.PictureBox btnCerrar;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btnAleatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblListaCanciones;
        private System.Windows.Forms.Button btnTodasCanciones;
        private System.Windows.Forms.Button btnEliminarCancion;
    }
}