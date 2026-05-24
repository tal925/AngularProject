using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdeasController : ControllerBase
    {
        private static readonly List<Idea> _ideas = new List<Idea>
        {
            new Idea { Id = 1, Title = "סדנת שוקולד", ActivityType = "סדנה", TargetAudience = "ילדים", DurationMinutes = 60, Status = "בתכנון" },
            new Idea { Id = 2, Title = "הרצאת העשרה", ActivityType = "הרצאה", TargetAudience = "מבוגרים", DurationMinutes = 90, Status = "מאושר" }
        };

        // 1. GET: קבלת כל הרעיונות
        [HttpGet]
        public ActionResult<IEnumerable<Idea>> GetAll()
        {
            return Ok(_ideas);
        }

        // 2. GET: שליפת רעיון לפי מזהה
        [HttpGet("{id}")]
        public ActionResult<Idea> GetById(int id)
        {
            var idea = _ideas.FirstOrDefault(x => x.Id == id);
            if (idea == null) return NotFound();
            return Ok(idea);
        }

        // 3. POST: הוספת רעיון חדש
        [HttpPost]
        public ActionResult<Idea> Create(Idea newIdea)
        {
            // הגרלת מזהה חדש
            newIdea.Id = _ideas.Count > 0 ? _ideas.Max(x => x.Id) + 1 : 1;
            _ideas.Add(newIdea);
            return CreatedAtAction(nameof(GetById), new { id = newIdea.Id }, newIdea);
        }

        // 4. PUT:  עדכון רעיון קיים
        [HttpPut("{id}")]
        public IActionResult Update(int id, Idea updatedIdea)
        {
            var existingIdea = _ideas.FirstOrDefault(x => x.Id == id);
            if (existingIdea == null) return NotFound();

            existingIdea.Title = updatedIdea.Title;
            existingIdea.ActivityType = updatedIdea.ActivityType;
            existingIdea.TargetAudience = updatedIdea.TargetAudience;
            existingIdea.DurationMinutes = updatedIdea.DurationMinutes;
            existingIdea.Status = updatedIdea.Status;

            return NoContent();
        }

        //  DELETE: מחיקת רעיון
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var idea = _ideas.FirstOrDefault(x => x.Id == id);
            if (idea == null) return NotFound();

            _ideas.Remove(idea);
            return NoContent();
        }
    }
}
