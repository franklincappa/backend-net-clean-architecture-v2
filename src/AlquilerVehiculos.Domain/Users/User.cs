using AlquilerVehiculos.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos.Domain.Users
{
    public sealed class User: Entity
    {
        public User(Guid id, Nombre nombre, Apellido apellido, Email email): base(id) 
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
        }

        public Nombre? Nombre { get; private set; }
        public Apellido? Apellido { get; private set; }
        public Email? Email { get; private set; }

        public static User Create(
            Nombre nombre, 
            Apellido apellido,
            Email email) 
        {
            var user = new User(Guid.NewGuid() , nombre, apellido, email);
            return user;
        }
    }
}
