using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PrimeiroEF.Models;

namespace PrimeiroEF.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController:Controller
    {
        Cliente cliente = new Cliente();
        readonly ClienteContexto contexto; //não quero que contexto tenha nenhum valor associado, por isso o readonly

        public ClienteController(ClienteContexto contexto){
            this.contexto = contexto;
        }

        [HttpGet]
        public IEnumerable<Cliente> Listar(){
            return contexto.ClienteBase.ToList();
            //Esse DbSet é Banco de dados virtual tipado com Cliente
            //Esse é o Get.
            //ToList: listando todo mundo
        }
        [HttpGet("{id}")]
        public Cliente Listar(int id){
            return contexto.ClienteBase.Where(x=>x.Id==id).FirstOrDefault();
            //Buscando um cliente específico
        }
        [HttpPost]
        public void Cadastrar([FromBody] Cliente cli){
            //Usando Entity Framework, só adiciona e salva.
            //Não precisa daquele INSERT INTO... etc
            contexto.ClienteBase.Add(cli);
            contexto.SaveChanges();
        }
    } 
}