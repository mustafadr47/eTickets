using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        //private readonly IActorsService _service;
        //public ActorsController(IActorsService service)
        //{
        //    _service = service;
        //}
        private readonly AppDbContext _service;
        public ActorsController(AppDbContext context)
        {
            _service = context;
        }
        public async Task<IActionResult> Index()
        {
            var data  =await _service.Actors.ToListAsync();
            return View(data);
        }
        //public void Add(Actor actor)
        //{
        //    _service.Add(actor);
        //    _service.SaveChanges();
        //}
        //Get Actors/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.Add(actor);
            _service.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
