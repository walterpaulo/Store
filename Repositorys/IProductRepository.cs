using System.Collections.Generic;
using Store.Models;

namespace store.Repositorys
{
    public interface IProductRepository
    {
         public Products Incluir(Products obj);
         public Products Alterar(Products obj);
         public bool Excluir(int id);
         IEnumerable<Products> ListarAsync();
         public Products Obter(int id);

    }
}