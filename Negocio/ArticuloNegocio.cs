using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo>listar()
        {
            List<Articulo> lista = new List<Articulo>();    
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.settearConsulta("select Codigo,Nombre,A.Descripcion,ImagenUrl,M.Descripcion Marca,C.Descripcion Categoria,A.IdMarca,A.IdCategoria,A.Id,Precio  from ARTICULOS A, MARCAS M,CATEGORIAS C where M.Id=A.IdMarca AND C.Id=A.IdCategoria");
                datos.ejecutarLectura();
                while(datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.ID = (int)datos.Lector["Id"];
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        articulo.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    }

                    articulo.Marca = new Marca();   
                    articulo.Marca.Id = (int)datos.Lector["IdMarca"];
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];
                    

                    articulo.Categoria=new Categoria();
                    articulo.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    articulo.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(articulo);        
                }
                datos.cerrarConexion();
                return lista;       

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.settearConsulta("insert into Articulos(Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio)");
                datos.settearParametro("@Codigo", nuevo.Codigo);
                datos.settearParametro("@Nombre", nuevo.Nombre);
                datos.settearParametro("@Descripcion",nuevo.Descripcion);
                datos.settearParametro("@IdMarca",nuevo.Marca.Id);
                datos.settearParametro("@IdCategoria",nuevo.Categoria.Id);
                datos.settearParametro("@ImagenUrl",nuevo.UrlImagen);
                datos.settearParametro("@Precio",nuevo.Precio);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo modificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.settearConsulta("update ARTICULOS set Codigo=@Codigo, Nombre=@Nombre, Descripcion=@Descripcion, IdMarca=@IdMarca, IdCategoria=@IdCategoria, ImagenUrl=@ImagenUrl, Precio=@Precio where Id=@Id");
                datos.settearParametro("@Codigo", modificado.Codigo);
                datos.settearParametro("@Nombre", modificado.Nombre);
                datos.settearParametro("@Descripcion", modificado.Descripcion);
                datos.settearParametro("@IdMarca", modificado.Marca.Id);
                datos.settearParametro("@IdCategoria", modificado.Categoria.Id);
                datos.settearParametro("@ImagenUrl", modificado.UrlImagen);
                datos.settearParametro("@Precio", modificado.Precio);
                datos.settearParametro("@Id", modificado.ID);

                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
        public void eliminarFisico(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.settearConsulta("delete from ARTICULOS where Id=@Id");
                datos.settearParametro("@Id", id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Articulo>filtrar(string campo,string criterio,string filtroAvanzado)
        {
            List<Articulo> lista = new List<Articulo>();    
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select Codigo,Nombre,A.Descripcion,ImagenUrl,M.Descripcion Marca,C.Descripcion Categoria,A.IdMarca,A.IdCategoria,A.Id,Precio  from ARTICULOS A, MARCAS M,CATEGORIAS C where M.Id=A.IdMarca AND C.Id=A.IdCategoria And ";
                if (campo =="Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor A":
                            consulta += "Precio > " + filtroAvanzado;
                            break;
                        case "Menor A":
                            consulta += "Precio < " + filtroAvanzado;
                            break;
                            default:
                            consulta += "Precio = " + filtroAvanzado;
                            break;
                            
                                
                    }
                }
                else if (campo =="Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza Con":
                            consulta += "Nombre like '" + filtroAvanzado + "%' ";
                            break;
                        case "Termina Con":
                            consulta += "Nombre Like '%" + filtroAvanzado + "' ";
                            break;
                            default :
                            consulta += "Nombre Like '%" + filtroAvanzado + "%'";
                            break;


                    }
                }
                else if (campo =="Marca")
                {
                    switch (criterio)
                    {
                        case "Comienza Con":
                            consulta += "M.Descripcion like '" + filtroAvanzado + "%' ";
                            break;
                        case "Termina Con":
                            consulta += "M.Descripcion Like '%" + filtroAvanzado + "' ";
                            break;
                        default:
                            consulta += "M.Descripcion Like '%" + filtroAvanzado + "%'";
                            break;


                    }
                }
                else if (campo =="Categoria")
                {
                    switch (criterio)
                    {
                        case "Comienza Con":
                            consulta += "C.Descripcion like '" + filtroAvanzado + "%' ";
                            break;
                        case "Termina Con":
                            consulta += "C.Descripcion  Like '%" + filtroAvanzado + "' ";
                            break;
                        default:
                            consulta += "C.Descripcion  Like '%" + filtroAvanzado + "%'";
                            break;


                    }
                }
                datos.settearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.ID = (int)datos.Lector["Id"];
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        articulo.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    }

                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)datos.Lector["IdMarca"];
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];


                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    articulo.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(articulo);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
