using System;
using Microsoft.EntityFrameworkCore;

namespace PrimeiroEF.Models
{
    public class ClienteContexto:DbContext
    {
        public ClienteContexto(DbContextOptions<ClienteContexto> options):base(options){}

        public DbSet<Cliente> ClienteBase { get; set; }
    }
}