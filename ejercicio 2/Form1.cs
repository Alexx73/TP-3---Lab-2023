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

                        competidores[i] = new Competidor(nombre, edad, club);
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

                    MessageBox.Show($"la cantidad de menores es {menores}.",
                        $"la cantidad de mayores { mayores } ");
                vcargar.Dispose();

            
                                        
        }

        

        private void bTorneo_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show($"NO hay competidores cargados !.");
            }
            else
            {
                rondas = new Random().Next(int.MinValue, int.MaxValue);
                fTorneo vTorneo = new fTorneo();

                for (int k = 0; k < i; k++)
                    vTorneo.lbTorneo.Items.Add($"0{k + 1} - {competidores[k].Nombre}.");
                vTorneo.ShowDialog();
            }
           


        }
    }
}
