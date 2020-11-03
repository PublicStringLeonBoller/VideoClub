using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClubSegundaVez
{
    public partial class Form1 : Form
    {
        double contTerror, contFiccion, contComedia, contTot, AcuTot;
        double contTotPersonas, contVarones, contMujeresTerrorificas;
        Cliente mayor;
        public Form1()
        {
            InitializeComponent();
            contComedia = contFiccion = contTerror = contTot = AcuTot = 0;
            contTotPersonas = contVarones = contMujeresTerrorificas = 0;
            mayor = null;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente Leon = new Cliente();
            Leon.Dni = Convert.ToInt32(txtDni.Text);
            Leon.Nombre = txtNombre.Text;
            if (rbtMasculino.Checked) Leon.Sexo = 1;
            if (rbtFemenino.Checked) Leon.Sexo = 2;
            if (rbtOtro.Checked) Leon.Sexo = 3;
            Leon.CodigoSocio = Convert.ToInt32(txtCodigoSocio.Text);

            Pelicula Rambo = new Pelicula();
            Rambo.Codigo = Convert.ToInt32(txtCodigoPeli.Text);
            Rambo.Titulo = txtTituloPeli.Text;
            Rambo.Genero = Convert.ToInt32(cboGenero.SelectedIndex + 1);

            Alquiler Temporal = new Alquiler();
            Temporal.Numero = Convert.ToInt32(txtNumeroAlquiler.Text);
            Temporal.Fecha = Convert.ToDateTime(dtpFechaAlq.Value);
            Temporal.Monto = Convert.ToDouble(txtMontoAlq.Text);

            Leon.Pelicula = Rambo;
            Leon.Alquiler = Temporal;
            MessageBox.Show($"{Leon.ShowInfoCLiente()}\n" +
                $"{Leon.Alquiler.ShowInfoAquiler()}\n" +
                $"{Leon.Pelicula.ShowInfoPelicula()}");

            // Cantidad de películas de cada género
            if (Leon.Pelicula.Genero == 1)
            {
                contTerror++;
            }
            lblTerror.Text = (contTerror).ToString();
            if (Leon.Pelicula.Genero == 2)
            {
                contFiccion++;
            }
            lblFiccion.Text = (contFiccion).ToString();
            if (Leon.Pelicula.Genero == 3)
            {
                contComedia++;
            }
            lblComedia.Text = (contComedia).ToString();

            //Recaudacion promedio
            contTot = contTerror + contFiccion + contComedia;
            AcuTot += Leon.Alquiler.Monto;
            lblRecaudacionPromedio.Text = (Math.Round(AcuTot / contTot, 2)).ToString();

            //Porcentaje de socios varones
            if (Leon.Sexo == 1)
            {
                contVarones++;
            }
            contTotPersonas++;
            lblPorcVarones.Text = (Math.Round((contVarones * 100) / contTotPersonas, 2)).ToString();

            //Cantidad de mujeres que alquilaron genero de terror
            if (Leon.Sexo == 2 && Leon.Pelicula.Genero == 1)
            {
                contMujeresTerrorificas++;
            }
            lblMujeresTerrorificas.Text = contMujeresTerrorificas.ToString();

            //Cliente y pelicula del alquiler mas caro
            if (mayor == null)
                mayor = Leon;
            else if (Leon.Alquiler.Monto > mayor.Alquiler.Monto)
                mayor = Leon;
            lblAlquilerCaro.Text = (mayor.ShowClienteYPeliCara());

        }
    }
}
