using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODELO_PARCIAL_1
{
    public partial class Registro : Form
    {
        //NODOS
        Nodo PRIMERO_C = null;
        Nodo ULTIMO_C = null;

        Nodo PRIMERO_P = null;
        Nodo ULTIMO_P = null;

        Nodo PRIMERO_L = null;
        Nodo ULTIMO_L = null;

        public Registro()
        {
            InitializeComponent();
        }

        //COMANDO MOSTRAR
        private void Mostrar()
        {
            MostrarCola();
            MostrarPila();
            MostrarLista();
        }

        private void MostrarCola ()
        {
            listCOLA.Items.Clear();
            Nodo AUXILIAR = PRIMERO_C;

            if (AUXILIAR != null)
            {
                while(AUXILIAR != null)
                {
                    listCOLA.Items.Add(AUXILIAR.DNI + " - " + AUXILIAR.Nombre);
                    AUXILIAR = AUXILIAR.Siguiente;
                }
            }
        }
        private void MostrarPila()
        {
            listPILA.Items.Clear();
            Nodo AUXILIAR = ULTIMO_P;

            if (AUXILIAR != null)
            {
                while (AUXILIAR != null)
                {
                    listPILA.Items.Add(AUXILIAR.DNI + " - " + AUXILIAR.Nombre);
                    AUXILIAR = AUXILIAR.Siguiente;
                }
            }
        }

        private void MostrarLista()
        {
            listLISTA.Items.Clear();
            Nodo AUXILIAR = PRIMERO_L;

            if (AUXILIAR != null)
            {
                while (AUXILIAR != null)
                {
                    listLISTA.Items.Add(AUXILIAR.DNI + " - " + AUXILIAR.Nombre);
                    AUXILIAR = AUXILIAR.Siguiente;
                }
            }
        }

        // COMANDO INSERTAR
        private void btnINSERTAR_Click(object sender, EventArgs e)
        {
            InsertarCola();
            InsertarPila();
            InsertarLista();

            Mostrar();
            txtDNI.Text = "";
            txtNOMBRE.Text = "";
        }

        private void InsertarCola()
        {
            Nodo NUEVO = new Nodo();
            NUEVO.DNI = int.Parse(txtDNI.Text);
            NUEVO.Nombre = txtNOMBRE.Text;
            
            if (PRIMERO_C == null)
            {
                PRIMERO_C = NUEVO;
                ULTIMO_C = NUEVO;
            }
            else
            {
                ULTIMO_C.Siguiente = NUEVO;
                ULTIMO_C = NUEVO;
            }
        }

        private void InsertarPila()
        {
            Nodo NUEVO = new Nodo();
            NUEVO.DNI = int.Parse(txtDNI.Text);
            NUEVO.Nombre = txtNOMBRE.Text;

            if (PRIMERO_P == null)
            {
                PRIMERO_P = NUEVO;
                ULTIMO_P = NUEVO;
            }
            else
            {
                NUEVO.Siguiente = ULTIMO_P;
                ULTIMO_P = NUEVO;
            }
        }

        private void InsertarLista()
        {   
            Nodo NUEVO = new Nodo();
            NUEVO.DNI = int.Parse(txtDNI.Text);
            NUEVO.Nombre = txtNOMBRE.Text;

            if (PRIMERO_L == null)                            // Si la cola esta vacia
            {
                PRIMERO_L = NUEVO;
                ULTIMO_L = NUEVO;
            }
            else if (NUEVO.DNI < PRIMERO_L.DNI)               // Si el nuevo es menor a primero 
            {
                NUEVO.Siguiente = PRIMERO_L;
                PRIMERO_L = NUEVO;
            }
            else if (NUEVO.DNI > ULTIMO_L.DNI)               // Si el nuevo es mayor a ultimo
            {
                ULTIMO_L .Siguiente = NUEVO;
                ULTIMO_L = NUEVO;
            }
            else                                            // Si el nuevo estra entre el Primero y el Ultimo
            {
                Nodo AUXILIAR = PRIMERO_L;
                while(AUXILIAR != null)
                {
                    if(NUEVO.DNI > AUXILIAR.DNI && NUEVO.DNI < AUXILIAR.Siguiente.DNI)
                    {
                        NUEVO.Siguiente = AUXILIAR.Siguiente;
                        AUXILIAR .Siguiente = NUEVO;
                    }
                    AUXILIAR = AUXILIAR.Siguiente;          // Permite recorrer la lista.
                }
            }
        }

        //COMANDOS ELIMINAR
        private void btnEliminarCOLA_Click(object sender, EventArgs e)
        {
            if(PRIMERO_C != null)
            {
                PRIMERO_C = PRIMERO_C.Siguiente;
                Mostrar();
            }
            else { MessageBox.Show("Cola vacía");  }
        }

        private void btnEliminarPILA_Click(object sender, EventArgs e)
        {
            if(ULTIMO_P != null) 
            {
                ULTIMO_P = ULTIMO_P.Siguiente;
                Mostrar();
            }
            else { MessageBox.Show("Pila vacía");  }
        }

        private void btnEliminarLISTA_Click(object sender, EventArgs e)
        {
            if (PRIMERO_L.DNI == int.Parse(txtDNI.Text))
            {
                PRIMERO_L = PRIMERO_L.Siguiente;
                Mostrar();
            }
            if (PRIMERO_L.DNI != int.Parse(txtDNI.Text))
            {
                Nodo ANTERIOR = PRIMERO_L;
                Nodo AUXILIAR = ANTERIOR.Siguiente;
                while(AUXILIAR != null)
                {
                    if(AUXILIAR.DNI == int.Parse(txtDNI.Text))
                    {
                        ANTERIOR.Siguiente = AUXILIAR.Siguiente;break;
                    }
                    ANTERIOR = AUXILIAR;
                    AUXILIAR = AUXILIAR.Siguiente;
                }
                Mostrar() ;
            }         
        }
        // COMANDO BUSCAR
        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Nodo AUXILIAR = PRIMERO_L;
            while(AUXILIAR != null)
            {
                if(AUXILIAR.DNI == int.Parse(txtDNI.Text))
                {
                    txtNOMBRE.Text = AUXILIAR.Nombre;
                }
                AUXILIAR = AUXILIAR.Siguiente;
            }
        }
    }
}
