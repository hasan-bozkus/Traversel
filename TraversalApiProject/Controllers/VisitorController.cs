using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TraversalApiProject.DAL.Context;
using TraversalApiProject.DAL.Entities;

namespace TraversalApiProject.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (var context = new VisitorContext())
            {
                var values = context.Visitors.ToList();
                return Ok(values);
            }

        }

        [HttpPost]
        public IActionResult VisitorAdd(Visitor visitor)
        {
            using (var context = new VisitorContext())
            {
                context.Add(visitor);
                context.SaveChanges();
                return Ok("Ziyaretçi Eklendi.");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetVisitor(int id)
        {
            using (var context = new VisitorContext())
            {
                var values = context.Visitors.Find(id);
                if (values == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(values);
                }
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVisitor(int id)
        {
            using (var context = new VisitorContext())
            {
                var result = context.Visitors.Find(id);
                if (result == null)
                {
                    return NotFound();
                }
                else
                {
                    context.Remove(result);
                    context.SaveChanges();
                    return Ok("Ziyaretçi silindi.");
                }
            }
        }

        [HttpPut]
        public IActionResult UpdateVisitor(Visitor visitor)
        {
            using (var context = new VisitorContext())
            {
                var values = context.Visitors.Find(visitor.VisitorID);
                if(values == null)
                {
                    return NotFound();
                }
                else
                {
                    values.City = visitor.City;
                    values.Country = visitor.Country;
                    values.Name = visitor.Name;
                    values.Surname = visitor.Surname;
                    values.VisitorID = visitor.VisitorID;
                    values.Mail = visitor.Mail;
                    context.Update(values);
                    context.SaveChanges();
                    return Ok("Ziyaretçi güncellendi.");
                }
            }
        }
    }
}
