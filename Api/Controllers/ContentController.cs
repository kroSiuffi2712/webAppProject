using Api.Repository;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    public class ContentController : ApiController
    {
        private readonly IContentManagerRepository _contentManagerRepository;

        public ContentController()
            : this(null)
        {
        }


        public ContentController(IContentManagerRepository contentManagerRepository)
        {
            _contentManagerRepository = contentManagerRepository ?? new ContentManagerRepository();
        }



        // GET: Content
        [HttpGet]
        public async Task<IHttpActionResult> GetContentList()
        {
            var response = await _contentManagerRepository.GetContentList();

            if (response != null)
                return Ok(response);
            return BadRequest("Error to get Content List");
            //return View();
        }
    }
}