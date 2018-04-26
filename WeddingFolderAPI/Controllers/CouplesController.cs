using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingFolderAPI.Data;
using WeddingFolderAPI.Models;

namespace WeddingFolderAPI.Controllers
{

   // [Authorize(Policy = "ApiUser")]
    [Produces("application/json")]
    [Route("api/Couples")]
    public class CouplesController : Controller
    {
        private readonly ApplicationDbContext _context;
            


        public CouplesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Couples
        [HttpGet]
        public IEnumerable<Couple> GetCouples()
        {
            //var couples = _context.Couple.Where(x => x.CoupleId < 4019);

            //foreach (var couple in couples)
            //{
            //    _context.Couple.Remove(couple);
            //}
            //_context.SaveChangesAsync();

            return _context.Couple.Include(m => m.PlanningFolders)
                .ThenInclude(w => w.WishList)
                .ThenInclude(wi => wi.Wishes)
                .Include(x => x.PlanningFolders)
                .ThenInclude(b => b.Budget)
                .ThenInclude(i => i.Items)
                .Include(g => g.PlanningFolders)
                .ThenInclude(gu => gu.GuestList)
                .ThenInclude(guel => guel.Guests)
                .Include(l => l.PlanningFolders)
                .ThenInclude(lo => lo.Location)
                .Include(s => s.PlanningFolders)
                .ThenInclude(sea => sea.SeatingPlan)
                .Include(t => t.PlanningFolders)
                .ThenInclude(to => to.ToDoList)
                .ThenInclude(todo => todo.Items)
                .Include(v => v.PlanningFolders)
                .ThenInclude(ve => ve.Vendors);
        }

        // GET: api/Couples/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCouple([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           
            var couple = await _context.Couple
                .Include(m => m.PlanningFolders)
                .ThenInclude(w => w.WishList)
                .ThenInclude(wi => wi.Wishes)
                .Include(x => x.PlanningFolders)
                .ThenInclude(b => b.Budget)
                .ThenInclude(i => i.Items)
                .Include(g => g.PlanningFolders)
                .ThenInclude(gu => gu.GuestList)
                .ThenInclude(guel => guel.Guests)
                .Include(l => l.PlanningFolders)
                .ThenInclude(lo => lo.Location)
                .Include(s => s.PlanningFolders)
                .ThenInclude(sea => sea.SeatingPlan)
                .Include(t => t.PlanningFolders)
                .ThenInclude(to => to.ToDoList)
                .ThenInclude(todo => todo.Items)
                .Include(v => v.PlanningFolders)
                .ThenInclude(ve => ve.Vendors)
                .SingleOrDefaultAsync(m => m.CoupleId == id);

            if (couple == null)
            {
                return NotFound();
            }

            return Ok(couple);
        }

        // PUT: api/Couples/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCouple([FromRoute] int id, [FromBody] Couple couple)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != couple.CoupleId)
            {
                return BadRequest();
            }

            _context.Entry(couple).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoupleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Couples
        [HttpPost]
        public async Task<IActionResult> PostCouple([FromBody] Couple couple)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Couple.Add(couple);
            
            await _context.SaveChangesAsync();
            var ish = _context.Couple.First(obj => obj.CoupleId == couple.CoupleId);
            return CreatedAtAction(nameof(GetCouple), new { id = ish.CoupleId }, ish);
          
        }

        // DELETE: api/Couples/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCouple([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var couple = await _context.Couple.SingleOrDefaultAsync(m => m.CoupleId == id);
            if (couple == null)
            {
                return NotFound();
            }

            _context.Couple.Remove(couple);
            await _context.SaveChangesAsync();

            return Ok(couple);
        }

        private bool CoupleExists(int id)
        {
            return _context.Couple.Any(e => e.CoupleId == id);
        }
    }
}