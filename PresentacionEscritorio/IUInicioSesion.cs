﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReglasDeNegocio;

namespace PresentacionEscritorio
{
    public partial class IUInicioSesion : Form
    {
        GestorInicioUsuarios GInicio = new GestorInicioUsuarios();       
        public IUInicioSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCrearCuenta_Click(object sender, EventArgs e)
        {
            IURegistroUsuario IUCrearCuenta = new IURegistroUsuario();
            IUCrearCuenta.Visible = true;
            this.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (GInicio.BuscarCredencial(txtCorreoElectronico.Text, txtContraseña.Text))
            {
                MessageBox.Show("Inicio correcto");
            }
            else
            {
                MessageBox.Show("El correo o la contraseña son incorrectos");
            }
        }
    }
}
