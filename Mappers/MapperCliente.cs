﻿using BE;
using DAL;

namespace Mappers
{
    public class MapperCliente
    {
        private DAL_Xml _dalXml;


        public MapperCliente()
        {
            _dalXml = new DAL_Xml();
        }

        public void Alta(BE_Cliente cliente)
        {
            List<BE_Cliente> clientes = _dalXml.LeerXml<BE_Cliente>();
            if(clientes.Any(clientes => clientes.DNI == cliente.DNI))
            {
                throw new Exception("Ya existe un cliente con ese DNI");
            }
            cliente.ID = clientes.Any() ? clientes.Max(x => x.ID) + 1 : 1;
            clientes.Add(cliente);
            _dalXml.GuardarXml(clientes);
        }

        public void ActualizarMembresia(int clienteId, BE_Membresia membresia) 
        {
            var clientes = _dalXml.LeerXml<BE_Cliente>();
            var clienteEncontrado = clientes.FirstOrDefault(x => x.ID == clienteId);
            if (clienteEncontrado != null)
            {
                clienteEncontrado.Membresia = membresia;
                _dalXml.GuardarXml(clientes);
            }
        }

        public void Baja(BE_Cliente cliente)
        {
            List<BE_Cliente> clientes = _dalXml.LeerXml<BE_Cliente>();
            var clienteEncontrado = clientes.Find(x => x.ID == cliente.ID);
            clientes.Remove(clienteEncontrado);
            _dalXml.GuardarXml(clientes);
        }

        public void Modificar(BE_Cliente cliente)
        {
            List<BE_Cliente> clientes = _dalXml.LeerXml<BE_Cliente>();
            var clienteEncontrado = clientes.Find(x => x.ID == cliente.ID);
            clienteEncontrado.Nombre = cliente.Nombre;
            clienteEncontrado.Apellido = cliente.Apellido;
            clienteEncontrado.DNI = cliente.DNI;
            clienteEncontrado.FechaNacimiento = cliente.FechaNacimiento;
            clienteEncontrado.Email = cliente.Email;
            clienteEncontrado.Telefono = cliente.Telefono;
            clienteEncontrado.Direccion = cliente.Direccion;
            clienteEncontrado.Membresia = cliente.Membresia;
            _dalXml.GuardarXml(clientes);
        }

        public List<BE_Cliente> Consultar()
        {
            return _dalXml.LeerXml<BE_Cliente>();
        }
    }
}
