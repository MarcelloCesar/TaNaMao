using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TanaMao.Domain.Gerencia.Entidades;
using TanaMao.Domain.Gerencia.Repository;
using TaNaMao.Infra.Transacao;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaNaMao.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _repository;
        private readonly IUow _uow;

        public ProdutoController(IProdutoRepository repository, IUow uow)
        {
            _repository = repository;
            _uow = uow;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            //return new string[] { "value1", "value2" };
            return _repository.GetProdutos();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Produto Get(Guid id)
        {
            return _repository.GetById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Produto produto)
        {
            try
            {
                _repository.Save(produto);
                _uow.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _uow.Rollback();

            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(Produto produto)
        {
            try
            {
                _repository.Delete(produto);
                _uow.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _uow.Rollback();
            }
  
        }
    }
}
