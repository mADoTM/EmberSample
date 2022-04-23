using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Text.Json.Nodes;
using System.Xml.Linq;

namespace EmberSampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class booksController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<Book>> Get()
        {
            WebClient client = new WebClient();
            string htmlCode = client.DownloadString("https://teststand.t-mobis.ru/Books");
            string jsonStringList = htmlCode.Substring(1, htmlCode.Length - 2).Replace("\\", "");

            List<Book> booksFromUrl = JsonConvert.DeserializeObject<List<Book>>(jsonStringList);

            var json = JsonConvert.SerializeObject(booksFromUrl, Formatting.Indented);
            return Ok(json);
        }

    }
}
