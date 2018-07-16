using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_BancoPessoa.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_BancoPessoa.Controllers
{
    [Produces("application/json")]
    [Route("api/Pessoa")]
    public class PessoaController : Controller
    {
        static readonly IPessoaRepositorio repositorio = new PessoaRepositorio();
        /*
        public IEnumerable<PessoaFisica> GetAllPessoasFisicas()
        {
            return repositorio.GetAllPessoaFisica();
        }

        public IEnumerable<PessoaJuridica> GetAllPessoasJuridicas()
        {
            return repositorio.GetAllPessoaJuridica();
        }
        */
        public IEnumerable<Pessoa> GetAll()
        {
            return repositorio.GetAll();
        }
    }
}