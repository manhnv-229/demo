using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MISA.BL;
using MISA.Entity;

namespace MISA.Demo2.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private readonly PositionBL _positionBL;

        public PositionsController()
        {
            _positionBL = new PositionBL();
        }

        // GET: api/Positions
        [HttpGet]
        public ActionResult<IEnumerable<Position>> GetPosition()
        {
            var positions = _positionBL.GetPositions();
            return Ok(positions);
            //return await _context.Position.ToListAsync();
        }

        // GET: api/Positions/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Position>> GetPosition(Guid id)
        //{
        //    var position = await _context.Position.FindAsync(id);

        //    if (position == null)
        //    {
        //        return NotFound();
        //    }

        //    return position;
        //}

        //// PUT: api/Positions/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPosition(Guid id, Position position)
        //{
        //    if (id != position.PositionId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(position).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PositionExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Positions
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<Position>> PostPosition(Position position)
        //{
        //    _context.Position.Add(position);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetPosition", new { id = position.PositionId }, position);
        //}

        //// DELETE: api/Positions/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Position>> DeletePosition(Guid id)
        //{
        //    var position = await _context.Position.FindAsync(id);
        //    if (position == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Position.Remove(position);
        //    await _context.SaveChangesAsync();

        //    return position;
        //}

        //private bool PositionExists(Guid id)
        //{
        //    return _context.Position.Any(e => e.PositionId == id);
        //}
    }
}
