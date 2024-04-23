using PazYSalvoAPP.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PazYSalvoAPP.Data.Repositories
{
    internal class IFacturasRepository : IGenericRepository<Factura>
    {
        private readonly PazSalvoContext pazSalvoContext;
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
    }
}
