using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTareaSemana2MiguelPisuna
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario, string contraseña)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado: " + usuario;

        }

        private void txtDatoUno_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double Nota1 = Convert.ToDouble(txtDatoUno.Text);
                if (txtDatoUno.Text.Length > 0)
                {


                    if (Nota1 >= 0 && Nota1 <= 10)
                    {

                    }
                    else
                    {

                        DisplayAlert("Error", "La nota debe ser entre 0 y 10", "Salir");
                    }
                }
            }
            catch (Exception)
            {

                DisplayAlert("Error", "Se debe ingresar solo números", "salir");
            }


        }

        private void txtDatoDos_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double Nota2 = Convert.ToDouble(txtDatoDos.Text);
                if (txtDatoDos.Text.Length > 0)
                {


                    if (Nota2 >= 0 && Nota2 <= 10)
                    {

                    }
                    else
                    {

                        DisplayAlert("Error", "La nota debe ser entre 0 y 10", "Salir");
                    }
                }
            }
            catch (Exception)
            {

                DisplayAlert("Error", "Se debe ingresar solo números", "salir");
            }

        }

        private void txtDatoTres_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double Nota3 = Convert.ToDouble(txtDatoTres.Text);
                if (txtDatoTres.Text.Length > 10)
                {


                    if (Nota3 >= 0 && Nota3 <= 0)
                    {

                    }
                    else
                    {

                        DisplayAlert("Error", "La nota debe ser entre 0 y 10", "Salir");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void txtDatoCuatro_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double Nota4 = Convert.ToDouble(txtDatoCuatro.Text);
                if (txtDatoCuatro.Text.Length > 10)
                {

                    if (Nota4 >= 0 && Nota4 <= 0)
                    {

                    }
                    else
                    {

                        DisplayAlert("Error", "La nota debe ser entre 0 y 10", "Salir");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnResultado_Clicked(object sender, EventArgs e)
        {
            try
            {
                double Nota1 = Convert.ToDouble(txtDatoUno.Text);
                double Nota2 = Convert.ToDouble(txtDatoDos.Text);
                double Nota3 = Convert.ToDouble(txtDatoTres.Text);
                double Nota4 = Convert.ToDouble(txtDatoCuatro.Text);

                double notaparcial1;
                double notaparcial2;
                double notatotal;

                Nota1 = Nota1 * 0.3;
                Nota2 = Nota2 * 0.2;
                Nota3 = Nota3 * 0.3;
                Nota4 = Nota4 * 0.2;

                notaparcial1 = Nota1 + Nota2;

                notaparcial2 = Nota3 + Nota4;


                notatotal = notaparcial1 + notaparcial2;

                txtParcial1.Text = notaparcial1.ToString();
                txtParcial2.Text = notaparcial2.ToString();
                txtFinal.Text = notatotal.ToString();

                if (notatotal >= 0 && notatotal < 5)
                {
                    DisplayAlert("Atención", "El estudiante esta REPROBADO ", "Salir");

                }
                if (notatotal >= 5 && notatotal <= 6.99)
                {
                    DisplayAlert("Atención", "El estudiante esta en COMPLEMENTARIO ", "Salir");

                }
                if (notatotal >= 7 && notatotal <= 10)
                {
                    DisplayAlert("Atención", "El estudiante esta APROBADO ", "Salir");

                }
            }
            catch (Exception)
            {

                DisplayAlert("Error", "Error", "salir");
            }



        }
    }
}