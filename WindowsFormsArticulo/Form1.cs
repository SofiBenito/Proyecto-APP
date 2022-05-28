using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WindowsFormsArticulo
{
    public partial class LblAviso : Form
    {
        private List<Articulo> articuloList;    
        public LblAviso()
        {
            InitializeComponent();
            Text = "Listado Articulos";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");
            LblAvisos.Visible = false;


        }

        private void DgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if(DgvArticulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)DgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void ocultarColumnas ()
        {
            DgvArticulo.Columns["UrlImagen"].Visible = false;
            DgvArticulo.Columns["Id"].Visible = false;      
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio ();
            try
            {
                articuloList = negocio.listar();
                DgvArticulo.DataSource = articuloList;
                ocultarColumnas();
                cargarImagen(articuloList[0].UrlImagen);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo agregar = new FrmAltaArticulo ();   
            agregar.ShowDialog();
            cargar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)DgvArticulo.CurrentRow.DataBoundItem;

            FrmAltaArticulo modificar = new FrmAltaArticulo (seleccionado);     
            modificar.ShowDialog(); 
            cargar ();
        }

        private void BtnEliminarFisico_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio ();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta= MessageBox.Show ("¿Seguro Que Quiere Eliminarlo?","Eliminado",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)DgvArticulo.CurrentRow.DataBoundItem;
                    negocio.eliminarFisico(seleccionado.ID);
                    cargar();
                }
                else
                {

                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por Favor, Seleccione Campo para filtrar");
                return true;
            }
            if (CboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por Favor, Seleccione Criterio para filtrar");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes Cargar el filtro para precio");
                    return true;
                        
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo Numeros Para Filtrar, Campo Numerico");
                    return true; 
                }
            }
            return false;

        }
        private bool soloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;    
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio Negocio = new ArticuloNegocio ();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = CboCriterio.SelectedItem.ToString();
                string filtroAvanzado = txtFiltroAvanzado.Text;

                DgvArticulo.DataSource = Negocio.filtrar(campo, criterio, filtroAvanzado);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltroRapido.Text;
            if (filtro.Length >= 3)
            {
                listaFiltrada = articuloList.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = articuloList;
            }
            DgvArticulo.DataSource = null;
            DgvArticulo.DataSource = listaFiltrada;
            ocultarColumnas();
        }
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion =cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                CboCriterio.Items.Clear();
                CboCriterio.Items.Add("Mayor A");
                CboCriterio.Items.Add("Menor A");
                CboCriterio.Items.Add("Igual A");
            }
            else
            {
                CboCriterio.Items.Clear();
                CboCriterio.Items.Add("Comienza Con");
                CboCriterio.Items.Add("Termina Con");
                CboCriterio.Items.Add("Contiene");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro Que Quiere abandonar la aplicación ?",
                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                Close();
        }

        private void txtFiltroRapido_Click(object sender, EventArgs e)
        {
            LblAvisos.Visible = true;
        }
    }
}
