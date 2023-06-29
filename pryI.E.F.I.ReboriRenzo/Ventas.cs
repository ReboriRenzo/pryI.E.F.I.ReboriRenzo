using System;

namespace pryI.E.F.I.ReboriRenzo
{
    internal class Ventas
    {
        public DateTime FechaVenta { get; internal set; }
        public int ID { get; internal set; }
        public string Producto { get; internal set; }
        public int Cantidad { get; internal set; }
    }
}