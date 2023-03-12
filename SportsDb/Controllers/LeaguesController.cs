using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SportsDb.DbModels;

namespace SportsDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaguesController : ControllerBase
    {
        private SportInfoDbContext _context = new SportInfoDbContext

        // League Methods
        [HttpGet]
        public List<League> GetAll()
        {
            return _context.Leagues.ToList();
        }

        [HttpPost("add")]
        public League AddLeague(string LeagueName)
        {
            var l = new League();
            l.LeagueName = LeagueName;
            _context.Leagues.Add(l);
            _context.SaveChanges();

            return l;
        }

        [HttpPut("update/{id}")]
        public League UpdateLeague(int id, string newLeagueName)
        {
            var l = _context.Leagues.Single(league => league.Id == id);
            l.LeagueName = newLeagueName;
            _context.SaveChanges();

            return l;
        }

        [HttpGet("{id}")]
        public League GetById(int id)
        {
            return _context.Leagues.Single(League => League.Id == id);

        }

        [HttpDelete("delete/{id}")]
        public string DeleteById(int id)
        {
            var leagueToDelete = _context.Leagues.Find(id);
            _context.Leagues.Remove(leagueToDelete);
            _context.SaveChanges();

            return $"Sucessfully Deleted id: {id}";
        }
    }
}
