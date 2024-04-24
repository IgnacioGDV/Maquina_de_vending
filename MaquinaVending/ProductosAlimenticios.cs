using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MáquinaDeVending
{
    public class ProductosAlimenticios : Producto
    {
        public string InfoNutricional { get; set; }
        public ProductosAlimenticios() { }
        public ProductosAlimenticios(int Id, string Nombre, int Unidades, double PrecioUnitario, string Descripción, string InfoNutricional) : base(Id, Nombre, Unidades, PrecioUnitario, Descripción)
        {
            this.InfoNutricional = InfoNutricional;
        }
        public ProductosAlimenticios(int Id) : base(Id) { }
        public override void MostrarInfoCompleta()
        {
            base.MostrarInfoCompleta();
            Console.WriteLine("\n\tTipo de producto: Producto Alimenticio" + "\n\tInformación Nutricional: " + this.InfoNutricional);
        }
        public override void SolicitarInfo()
        {
            Console.Clear();
            Console.WriteLine("  ------------------------------ ");
            Console.WriteLine(" |   AÑADIENDO NUEVO PRODUCTO   | ");
            Console.WriteLine("  ------------------------------ ");
            Console.WriteLine(" --- NUEVO PRODUCTO ALIMENTICIO  --- ");
            base.SolicitarInfo();
            Console.WriteLine("Información nutricional: ");
            this.InfoNutricional = Console.ReadLine();
        }
    }
}
