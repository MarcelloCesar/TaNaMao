using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TanaMao.Domain.Gerencia.Entidades;
using TanaMao.Domain.Gerencia.Repositories;
using TaNaMao.Infra.Transacao;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaNaMao.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _repository;
        private readonly IUow _uow;

        public ClienteController(IClienteRepository repository, IUow uow)
        {
            _repository = repository;
            _uow = uow;
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _repository.GetClientes();
        }

        
        [HttpGet("{id}")]
        public Cliente Get(Guid id)
        {
            return _repository.GetById(id);
        }

        
        [HttpPost]
        public void Post([FromBody]Cliente cliente)
        {
            try
            {
                _repository.Save(cliente);
                _uow.Commit();
             
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _uow.Rollback();
                
            }
        }

        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        
        [HttpDelete("{id}")]
        public void Delete(Cliente cliente)
        {
            try
            {
                _repository.Save(cliente);
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
