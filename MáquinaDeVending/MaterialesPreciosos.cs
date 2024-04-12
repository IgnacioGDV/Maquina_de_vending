using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MáquinaDeVending
{
    public class MaterialesPreciosos : Producto
    {
        public string TipoMaterial {  get; set; }
        public double Peso {  get; set; }
        public MaterialesPreciosos()
        {
            
        }
        public MaterialesPreciosos(int Id, string Nombre, int Unidades, double PrecioUnitario, string Descripción, string TipoMaterial, double Peso) : base(Id, Nombre, Unidades, PrecioUnitario, Descripción)
        {
            this.TipoMaterial = TipoMaterial;
            this.Peso = Peso;
        }
        public MaterialesPreciosos(int Id) : base(Id) { }

        public override void MostrarInfoCompleta()
        {
            base.MostrarInfoCompleta();
            Console.WriteLine("\n\tTipo de producto: Material precioso" + "\n\tTipo de material: " + this.TipoMaterial + "\n\tPeso: " + this.Peso + "gramos");
        }
        public override void SolicitarInfo()
        {
            Console.Clear();
            Console.WriteLine("  ------------------------------ ");
            Console.WriteLine(" |   AÑADIENDO NUEVO PRODUCTO   | ");
            Console.WriteLine("  ------------------------------ ");
            Console.WriteLine(" --- NUEVO MATERIAL PRECIOSO --- ");
            base.SolicitarInfo();
            Console.WriteLine("Tipo de material: ");
            this.TipoMaterial = Console.ReadLine();
            Console.WriteLine("Peso(gramos): ");
            this.Peso = int.Parse(Console.ReadLine());
        }

    }
}
