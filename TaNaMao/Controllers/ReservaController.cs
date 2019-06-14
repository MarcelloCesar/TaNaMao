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
    public class ReservaController : Controller
    {
        private readonly IReservaRepository _repository;
        private readonly IUow _uow;

        public ReservaController(IReservaRepository repository, IUow uow)
        {
            _repository = repository;
            _uow = uow;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Reserva> Get()
        {
            return _repository.GetReservas();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Reserva Get(Guid id)
        {
            return _repository.GetById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Reserva reserva)
        {
            try
            {
                _repository.Save(reserva);
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
        public void Delete(Reserva reserva)
        {
            try
            {
                _repository.Save(reserva);
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
