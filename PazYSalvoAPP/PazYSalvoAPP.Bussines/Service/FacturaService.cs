using PazYSalvoAPP.Data.Context;
using PazYSalvoAPP.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PazYSalvoAPP.Bussines.Service
{
    internal class FacturaService : IFacturaService
    {
        private readonly IGenericRepository<Factura> _modelRepository;
        public Task<bool> Actualizar(Factura model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insertar(Factura model)
        {
            throw new NotImplementedException();
        }

        public Task<Factura> Leer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Factura>> LeerTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Factura> ObtenerFacturasPorServicio(int servicioId)
        {
            throw new NotImplementedException();
        }
    }
}
