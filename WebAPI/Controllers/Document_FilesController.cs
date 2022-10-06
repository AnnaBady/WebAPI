using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Document_FilesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public Document_FilesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Document_Files
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Document_Files>>> GetDocument_Files()
        {
            return await _context.Document_Files.ToListAsync();
        }

        // GET: api/Document_Files/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Document_Files>> GetDocument_Files(int id)
        {
            var document_Files = await _context.Document_Files.FindAsync(id);

            if (document_Files == null)
            {
                return NotFound();
            }

            return document_Files;
        }

        // PUT: api/Document_Files/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDocument_Files(int id, Document_Files document_Files)
        {
            if (id != document_Files.Id)
            {
                return BadRequest();
            }

            _context.Entry(document_Files).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Document_FilesExists(id))
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

        // POST: api/Document_Files
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Document_Files>> PostDocument_Files(Document_Files document_Files)
        {
            _context.Document_Files.Add(document_Files);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDocument_Files", new { id = document_Files.Id }, document_Files);
        }

        // DELETE: api/Document_Files/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDocument_Files(int id)
        {
            var document_Files = await _context.Document_Files.FindAsync(id);
            if (document_Files == null)
            {
                return NotFound();
            }

            _context.Document_Files.Remove(document_Files);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Document_FilesExists(int id)
        {
            return _context.Document_Files.Any(e => e.Id == id);
        }


        /*
        [Route("api/Document_Files/SaveFile")]
        public string SaveFile()
        {
            try
            {
                var httpRequest = HttpContext.Request;
                var postedFile = httpRequest..Files[0];
                string filename = postedFile.FileName;
                var physicalPath = HttpContext..Server.MapPath("~/Photos/" + filename);

                postedFile.SaveAs(physicalPath);

                return filename;
            }
            catch (Exception)
            {

                return "anonymous.png";
            }
        }*/
    }
}
