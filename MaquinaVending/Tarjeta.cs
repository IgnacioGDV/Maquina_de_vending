using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MáquinaDeVending
{
    internal class Tarjeta
    {
        public string Número { get; set; }
        public string FechaCaducidad { get; set; }
        public string CódigoSeguridad { get; set; }
        public bool ArgumentoNoValido { get; set; }
        public Tarjeta()
        {
            this.ArgumentoNoValido = false; // Para validar que todos los argumentos introducidos son válidos
        }
    }
}
