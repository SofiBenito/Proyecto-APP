using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration;

namespace WindowsFormsArticulo
{
    public partial class FrmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;  
        public FrmAltaArticulo()
        {
            InitializeComponent();
            Text = "Agregar";
        }
        public FrmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;   
            Text = "Modificar";
        }


        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
           
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                CboCategoria.DataSource = categoriaNegocio.listar();
                CboCategoria.ValueMember = "Id";
                CboCategoria.DisplayMember = "Descripcion";
                CboMarca.DataSource = marcaNegocio.listar();
                CboMarca.ValueMember = "Id";
                CboMarca.DisplayMember = "Descripcion";
                
                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;   
                    TxtNombre.Text = articulo.Nombre;   
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagenUrl.Text = articulo.UrlImagen;
                    cargarImagen(articulo.UrlImagen);
                    CboMarca.SelectedValue = articulo.Marca.Id;
                    CboCategoria.SelectedValue = articulo.Categoria.Id;
                    txtPrecio.Text = articulo.Precio.ToString(); 
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();    
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio Negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();  

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre=TxtNombre.Text;
                articulo.Descripcion=txtDescripcion.Text;
                articulo.UrlImagen=txtImagenUrl.Text;
                articulo.Marca = (Marca)CboMarca.SelectedItem;
                articulo.Categoria = (Categoria)CboCategoria.SelectedItem;
                if (!(soloNumeros(txtPrecio.Text)))
                {

                    MessageBox.Show("Solo Numeros En El Campo Precio Por Favor");
                    return;

                }
                else
                {
                    articulo.Precio = Convert.ToDecimal(txtPrecio.Text);
                }
       

                if (articulo.ID != 0)
                {
                    Negocio.modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    Negocio.agregar(articulo);
                    MessageBox.Show("Agregado Exitosamente");
                }

                if (archivo != null && txtImagenUrl.Text.ToUpper().Contains("HTTP")) 
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["ArticulosApp"] + archivo.FileName);
                }
                


                Close();    

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pcbImagen.Load(imagen);
            }
            catch (Exception ex)
            {

                pcbImagen.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void BtnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

            }

        }
    }
}
