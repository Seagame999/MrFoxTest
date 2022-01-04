using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConcertTicketsApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ConcertTicketsApi.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Concert> Concert {get ; set ; }

        public DbSet<ConcertTickets> ConcertTickets {get ; set ; }

        public ApplicationDBContext() : base()
        {

        }
    }
}