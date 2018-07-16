using BDOnline.Api;
using BDOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BDOnline.Controllers
{


    public class FileOneController : ApiController
    {
        private BDOnlineDB db = new BDOnlineDB();


        // GET: api/Resources
        [HttpGet, Route("api/Resources")]
        public IHttpActionResult GetResources()
        {

            var res = db.Resources
                .Select(r => new GetResources
                {
                    ID = r.ID,
                    Name = r.Name,

                })
                .OrderBy(r => r.Name)
                .ToList();

            if (res.Count == 0)
            {
                return NotFound();
            }
            return Ok(res);
        }


        // GET: api/Resources/id
        [HttpGet, Route("api/Resources/{id:int}")]
        public IHttpActionResult GetResources(int? id)
        {
            if (id == null)
            {

                return BadRequest();

            }

            var res = db.Resources
                .Where(r => r.ID == id)
                .Select(r => new GetResources
                {
                    ID = r.ID,
                    Name = r.Name,

                })
                .FirstOrDefault();

            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        // GET: api/Resources/id/classes
        [HttpGet, Route("api/Resources/{id:int}/classes")]
        public IHttpActionResult GetClass(int? id)
        {

            if (id == null)
            {
                return BadRequest();
            }

            var Class = db.Classess
                .Where(c => c.ResourceFK == id)
                .Select(c => new GetClass
                {
                    ID = c.ID,
                    Name = c.Name,
                    Ch_Symbol = c.Ch_Symbol,
                })
                .OrderBy(h => h.Name)
                .ToList();

            if (Class == null)
            {
                return NotFound();
            }

            return Ok(Class);
        }


        // GET: api/Classes
        [HttpGet, Route("api/Classes")]
        public IHttpActionResult GetClasses()
        {

            var Class = db.Classess
                .Select(c => new GetClass
                {
                    ID = c.ID,
                    Name = c.Name,
                    Ch_Symbol = c.Ch_Symbol,

                })
                .OrderBy(c => c.Name)
                .ToList();

            if (Class.Count == 0)
            {
                return NotFound();
            }
            return Ok(Class);
        }


        // GET: api/Classes
        [HttpGet, Route("api/Classes/{id:int}")]
        public IHttpActionResult GetClasses(int? id)
        {

            if (id == null)
            {
                return BadRequest();
            }

            var Class = db.Classess
                .Where(c => c.ID == id)
                .Select(c => new GetClass
                {
                    ID = c.ID,
                    Ch_image_fullBody = c.Ch_image_fullBody,
                    Ch_Symbol = c.Ch_Symbol,
                    Description = c.Description,
                    Name = c.Name,
                    resource_type = c.ResourceFK


                })
                .FirstOrDefault();

            if (Class == null)
            {
                return NotFound();
            }
            return Ok(Class);
        }

    }
}
