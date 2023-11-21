using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats2._0.PMetodoFabrica.Producto
{
    public abstract class Usuario : BaseEntity
    {
        public string nombre { set; get; }
        public string correo_electronico { set; get; }
        public string telefono { set; get; }
        public string tipo { set;  get; }
        public string contrasenna { set; get; }

        public Usuario()
        {
        }

        public Usuario(string nombre, string correo_electronico, string telefono, string tipo, string contrasenna)
        {
            this.nombre = nombre;
            this.correo_electronico = correo_electronico;
            this.telefono = telefono;
            this.tipo = tipo;
            this.contrasenna = contrasenna;

        }

        public Usuario(string nombre, string correo_electronico, string telefono, string contrasenna)
        {
            this.nombre = nombre;
            this.correo_electronico = correo_electronico;
            this.telefono = telefono;
            this.contrasenna= contrasenna;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, correo: {correo_electronico}, telefono: {telefono}, tipo: {tipo}, contraseña: {contrasenna}";
        }
    }


}
