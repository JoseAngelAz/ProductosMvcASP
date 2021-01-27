using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ProductosApp.Models
{
    public class Productos
    {
        public void GuardarProducto(string id, string n_producto, string descripcion, double precio)
        {
            StreamWriter producto = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/producto.txt", true);
            producto.WriteLine(
                "<b style='color:blue'>Id:</b>" + id +"<br>" +
                "<b style='color:blue'>Producto:</b>" + n_producto + "<hr>"+
                "<b>Precio: </b>" + precio+
                "<b>Descripcion:</b>"+ descripcion 
                );
            producto.Close();
        }

        //mostrar el producto
        public string MostrarProducto()
        {
            StreamReader archivo = new StreamReader(HostingEnvironment.MapPath("~")+"/App_Data/producto.txt", true);
            string producto = archivo.ReadToEnd();
            archivo.Close();
            return producto;
        }
    }
}