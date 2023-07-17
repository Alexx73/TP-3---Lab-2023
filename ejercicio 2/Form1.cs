using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_2
{
    public partial class Form1 : Form
    {
        private int cantidadCompetidores = 5;
        private int i = 0;
        private int j = 1;
        Competidor[] competidores;
        
        private int rondas;
        
        public Form1()
        {
            InitializeComponent();
            competidores = new Competidor[cantidadCompetidores];

            // clientes = new Cliente[cantidadClientes];
        }

        
        private void bCompetidores_Click(object sender, EventArgs e)
        {
            string nombre;
            int edad;
            int id;
            string club;
            int menores = 0;
            int mayores = 0;

            
                fCompetidor vcargar = new fCompetidor();
                while (vcargar.ShowDialog() == DialogResult.OK)
                    {
                        nombre = vcargar.tbNombre.Text;
                        edad = Convert.ToInt32(vcargar.tbEdad.Text);
                        if (edad < 18)
                        {
                            menores++;
                        }
                        else
                        {
                            mayores++;
                        }
                        club = vcargar.tbClub.Text;

                        competidores[i] = new Competidor(i, nombre, edad, club );
                        i++;
                        vcargar.la_NroCompetidor.Text = Convert.ToString(i + 1);

                        MessageBox.Show($"Competidor: {nombre} cargado !.");

                        // limpiar campos
                        vcargar.tbNombre.Text = "";
                        vcargar.tbEdad.Text = "";
                        vcargar.tbClub.Text = "";

                    }

                    //DialogResult res = unaVentana.ShowDialog();
                    //if (res == DialogResult.OK)
                    //{ }
                    //else
                    //{ }

                    MessageBox.Show($"la cantidad de menores es {menores}.\r\n la cantidad de mayores { mayores }");
                vcargar.Dispose();

            
                                        
        }

        

        private void bTorneo_Click(object sender, EventArgs e)
        {

            // Copia
            // string[,] copia = matriz.Clone() as string[,];
            //Competidor[] podio = new Competidor[cantidadCompetidores] ;
            // podio = competidores;

            int cant_competidores;
            int rondas2 = 3;
            int puntosAcumulados = 0;
            int cantidadX = 0;

            if (i == 0)
            {
                MessageBox.Show($"NO hay competidores cargados !.");
            }
            else
            {
                Torneo torneo = new Torneo(5, 10);            
                fTorneo vTorneo = new fTorneo();

                for (int k = 0; k < i; k++)
                {
                    vTorneo.lbTorneo.Items.Add($"0{competidores[k].Id + 1} - {competidores[k].Nombre} - P: {competidores[k].Puntos} - X: {competidores[k].Cantidad_X }  ");
                }                  
                vTorneo.lbTorneo.Items.Add($"cantidad de Rondas: { torneo.NroRondas } .");

                // Empezar ciclo de carga //
                cant_competidores = competidores.Length;

                for ( int k = 0; k < rondas2; k++ )
                {
                    if (vTorneo.ShowDialog() == DialogResult.OK)
                    {
                        puntosAcumulados = Convert.ToInt32(vTorneo.comboBox1.SelectedItem);
                        cantidadX = Convert.ToInt32(vTorneo.tbTotalX.Text);

                        vTorneo.lbPuntos.Items.Add(puntosAcumulados);
                        vTorneo.lbCantidadX.Items.Add(cantidadX);



                       

                        MessageBox.Show($"el total de puntos es:{ puntosAcumulados}.  el total de X es: { cantidadX} !.");

                        // limpiar campos

                        foreach (var c in this.Controls)
                        {
                            if ( c is TextBox )
                            {
                                ((TextBox)c).Clear();
                            }
                        }

                        //vTorneo.tbTiro1.Text = "";
                       

                    }

                }

                // ronda N - cargar datos de  de competidores en orden de Inscripcion

                // al final de cada ronda ordenar podio y mostrar primeros 3 lugares

                // Fin Ronda N, pasar a siguiente Ronda




                // Fin
                vTorneo.ShowDialog();
            }


           


        }
    }
}
