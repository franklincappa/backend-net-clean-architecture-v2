using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos.Domain.Vehiculos
{
    public record TipoMoneda
    {
        public static readonly TipoMoneda None = new(""); 
        public static readonly TipoMoneda Eur = new("EUR"); 
        public static readonly TipoMoneda Usd = new("USD");
        private TipoMoneda(string code) => Codigo = Codigo;
        public string? Codigo { get; init; }

        public static readonly IReadOnlyCollection<TipoMoneda> All = new[]
        {
            Usd,
            Eur
        };

        public static TipoMoneda FromCodigo(string codigo) 
        {
            return All.FirstOrDefault(c => c.Codigo == codigo) ??
                throw new ApplicationException("El tipo de moneda es invalido");
        }

         
    }
}
