﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace Mappers
{
    public class MapperMembresia
    {
        private DAL_Xml _dalXml;
        private readonly MapperCliente _mapperCliente;

        public MapperMembresia()
        {
            _dalXml = new DAL_Xml();
            _mapperCliente = new MapperCliente();
        }

        public void Alta(BE_Membresia membresia)
        {
            List<BE_Membresia> membresias = _dalXml.LeerXml<BE_Membresia>();
            membresia.ID = membresias.Any() ? membresias.Max(x => x.ID) + 1 : 1;
            membresias.Add(membresia);
            _dalXml.GuardarXml(membresias);
        }

        public void Baja(BE_Membresia membresia)
        {
            List<BE_Membresia> membresias = _dalXml.LeerXml<BE_Membresia>();
            var membresiaEncontrada = membresias.Find(x => x.ID == membresia.ID);
            membresias.Remove(membresiaEncontrada);
            _dalXml.GuardarXml(membresias);
        }

        public List<BE_Membresia> Consultar()
        {
            var membresias = _dalXml.LeerXml<BE_Membresia>();
            var clientes = _mapperCliente.Consultar();

            foreach (var membresia in membresias)
            {
                BE_Cliente? clienteEncontrado;
                clienteEncontrado = clientes.Find(x => x.ID == membresia.Cliente.ID);
                if(clienteEncontrado == null)
                {
                    throw new Exception("No se encontro el cliente de la membresia" + membresia.ID);
                }
                membresia.Cliente = clienteEncontrado;
            }
            return membresias;
        }

        public void Modificar(BE_Membresia membresia)
        {
            List<BE_Membresia> membresias = _dalXml.LeerXml<BE_Membresia>();
            var membresiaExistente = membresias.Find(x => x.ID == membresia.ID);
            if(membresiaExistente != null)
            {
                membresiaExistente.FechaFin = membresia.FechaFin;
                membresiaExistente.EstaActiva = membresia.EstaActiva;
                membresiaExistente.Tipo = membresia.Tipo;
                _dalXml.GuardarXml(membresias);
            }
        }
    }
}
