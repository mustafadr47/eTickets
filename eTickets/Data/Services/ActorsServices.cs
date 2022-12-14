using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsServices:EntityBaseRepository<Actor> ,IActorsService
    {
        public ActorsServices(AppDbContext context): base(context) { } 
    }
}
