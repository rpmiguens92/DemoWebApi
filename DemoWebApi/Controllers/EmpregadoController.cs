using DemoWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
 

namespace DemoWebApi.Controllers
{
    public class EmpregadoController : ApiController
    {
       private List <Empregado> Funcionarios;
        // GET: api/Empregado

        public EmpregadoController()
        {
            Funcionarios = new List<Empregado>
            {
                new Empregado {Id = 1, Nome = "Joana", Apelido = "Matos"},
                 new Empregado {Id = 2, Nome = "Carlota", Apelido = "Morais"},
                  new Empregado {Id = 3, Nome = "Rui", Apelido = "Santos"},
            };
        }
        public List<Empregado> Get()
        {
            return Funcionarios;
        }

        // GET: api/Empregado/5
        public string Get(int id)
        {
            return Funcionarios.FirstOrDefault(x => x.Id == id).ToString();
        }
        // POST: api/Empregado
        public void Post([FromBody]Empregado value)
        {
            Funcionarios.Add(value); //recebe o empregado
        }

        // PUT: api/Empregado/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Empregado/5
        public void Delete(int id)
        {
        }
    }
}
