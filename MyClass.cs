using System;

class MyClass
{


    public class Clientes
    {
        public string? nombre { get; set }

    }

    public class Productos
    {
        public int id { get; set }
        public string? nombre { get; set }

    }

    public class Ventas
    {
        public int id { get; set; }
        public string? codigo { get; set; }
        public int Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal descuento { set; get; }
        public decimal total
        public Clientes? _cliente { set; get; }




}

    public class Ventas_productos
    {
        public int id { get; set; }
        public int id_venta { get; set; }
        public int id_producto { get; set; }
        public decimal cantidad { get; set; }
        public decimal valor { get; set; }
        public decimal subTotal { get; set; }
        public ventas? _venta { get; set; }
        public productos? _producto { get; set; }

    }
}