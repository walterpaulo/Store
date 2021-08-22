using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Store.Models;
using Store.Services;

namespace store.Repositorys
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApiContext _context;
        public ProductRepository(ApiContext ctx)
        {
            _context = ctx;
        }
        public Products Alterar(Products obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Excluir(int id)
        {
            var obj = this.Obter(id);
            if(obj == null)
                return false;

            _context.Remove(obj);
            _context.SaveChanges();
            throw new System.NotImplementedException();
        }

        public Products Incluir(Products obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
            _context.Dispose();
            throw new System.NotImplementedException();
            
        }

        public IEnumerable<Products> Lista()
        {
           
            return (IEnumerable<Products>)_context.Usuarios.ToListAsync();
            throw new System.NotImplementedException();
        }

        public IEnumerable<Products> ListarAsync()
        {
            throw new System.NotImplementedException();
        }

        public Products Obter(int id)
        {
            // return _context.Usuarios.FirstOrDefaultAsync(a => a.Id == id);
            throw new System.NotImplementedException();
        }
    }
}