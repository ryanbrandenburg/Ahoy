using System.Collections.Generic;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Basic.Controllers
{
    [Produces("application/json")]
    public class DynamicTypesController : Controller
    {
        public class Kitten
        {
            public string Name { get; set; }
            public string Color { get; set; }
        }

        [HttpPost("kittens")]
        public Kitten CreateKitten([FromBody]Kitten kitten)
        {
            return new Kitten {
                Name="Steve",
                Color="Green"
            };
        }

        [HttpGet("unicorns")]
        public ExpandoObject GetUnicorns()
        {
            return new ExpandoObject(); 
        }

        [HttpPost("dragons")]
        public IActionResult CreateDragons([FromBody]object dragon)
        {
            return new ObjectResult(1);
        }

        [HttpGet("wizards")]
        public IEnumerable<JObject> GetWizards()
        {
            return new[]
            {
                new JObject(),
                new JObject()
            };
        }
    }
}