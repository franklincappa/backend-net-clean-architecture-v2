using AlquilerVehiculos.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos.Domain.Vehiculos
{
    public sealed class Vehiculo : Entity
    {
        public Vehiculo(
            Guid id,
            Modelo modelo, 
            Vin vin,
            Moneda precio,
            Moneda mantenimiento,
            DateTime? fechaUltimoAlquiler,
            List<Accesorio> accesorios,
            Direccion? direccion
            ) : base(id)
        {
            Modelo = modelo;
            Vin = vin;
            Precio = precio;
            Mantenimiento = mantenimiento;
            FechaUltimoAlquiler = fechaUltimoAlquiler;
            Accesorios = accesorios;            
        }

        public Modelo? Modelo { get; private set; }
        public Vin? Vin { get; private set; }
        public Direccion? Direccion { get; private set; }        
        public  Moneda? Precio { get; private set; }
        public Moneda? Mantenimiento { get; private set; }
        public DateTime? FechaUltimoAlquiler { get; private set; }
        public List<Accesorio> Accesorios { get; private set; } = new ();
    }
}
