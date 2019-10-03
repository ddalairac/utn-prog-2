using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobantesLogic
{
    public class Factura : Comprobante
    {
        int diasParaElVencimiento;
        TipoFactura tipoFactura;
        public Factura(Venta venta, int diasParaElVencimiento, TipoFactura tipoFactura) : base(venta)
        {
            this.diasParaElVencimiento = diasParaElVencimiento;
            this.tipoFactura = tipoFactura;
        }
        public Factura(Venta venta, TipoFactura tipoFactura) : this(venta, 15, tipoFactura) { }

        public override bool Equals(Object obj)
        {
            bool aux = false;
            if (base.Equals(obj) == true)
            {
                Factura fac = (Factura)obj;
                if (fac.fechaEmision == this.fechaEmision)
                {
                    aux = true;
                }
            }
            return aux;
        }
        public string GenerarComprobante()
        {
            
            Producto prod = (Producto)this.Venta;
            int Iva = (int) prod.Precio - (int) Venta.CalcularPrecioFinal(prod.Precio,1);
            StringBuilder str = new StringBuilder();
            str.Append($"{this.Venta.ObtenerDescripcionBreve()} || ");
            str.Append($"FACTURA {this.tipoFactura}\n");
            str.Append($"Fecha Emisión: {this.fechaEmision} \n");
            str.Append($"Fecha Vencimiento: {this.diasParaElVencimiento} \n");
            str.Append($"Producto: {prod.ToString()} \n");
            str.Append($"Cantidad: {this.Venta.Cantidad} \n");
            str.Append($"Precio Unitario: ${prod.Precio:#.00} \n");
            str.Append($"Subtotal: ${prod.Precio * this.Venta.Cantidad} \n");
            str.Append($"Importe IVA: ${Iva} \n");
            str.Append($"Importe Total: ${Venta.CalcularPrecioFinal(prod.Precio,this.Venta.Cantidad)} * Precio final con IVA * \n");
            return str.ToString();
        }
        public enum TipoFactura { A, B, C, E }
    }
}
