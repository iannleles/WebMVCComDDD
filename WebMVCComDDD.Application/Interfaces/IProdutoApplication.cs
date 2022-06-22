using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVCComDDD.Application.ViewModels;

namespace WebMVCComDDD.Application.Interfaces
{
    public interface IProdutoApplication
    {
        IEnumerable<ProdutoViewModel> GetAll();
        public void Insert(ProdutoViewModel produto);
        ProdutoViewModel GetById(int id);
        void Update(ProdutoViewModel produtoViewModel);
        void Delete(int id);
    }
}
