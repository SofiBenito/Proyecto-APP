using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        private int _id;
        private string _codigo;
        private string _nombre;
        private string _descripcion;
        private Marca _marca;
        private Categoria _categoria;
        private string _urlImagen;
        private decimal _precio;

        public int ID
        {
            get { return _id; }     
            set { _id = value; }            
        }
        public string Codigo
        {
            get { return _codigo; }     
            set { _codigo = value; }            
        }
        public Marca Marca
        {
            get { return _marca; }      
            set { _marca = value; }         
        }
        public Categoria Categoria
        {
            get { return _categoria; }      
            set { _categoria = value; }     
        }
        public decimal Precio
        {
            get { return _precio; } 
            set { _precio = value; }        
        }
        public string Descripcion
        {
            get { return _descripcion; }        
            set { _descripcion = value; }   
        }
        public string UrlImagen
        {
            get { return _urlImagen; }          
            set { _urlImagen = value; }         
        }
        public string Nombre
        {
            get { return _nombre; }     
            set { _nombre = value; }        
        }
    }
}
