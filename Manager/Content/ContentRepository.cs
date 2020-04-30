using DbManager.Content;
using System.Collections.Generic;
using Dto = Data.Dto;
using System.Threading.Tasks;

namespace Manager.Content
{
    public class ContentRepository : IContentRepository
    {
        private readonly IContentDbRepository _contentDbRepository;

        public ContentRepository()
            : this(null)
        { }
        public ContentRepository(IContentDbRepository contentDbRepository)
        {
            _contentDbRepository = contentDbRepository ?? new ContentDbRepository();
        }

        public async Task<List<Dto.Content>> GetContentList()
        {
            var contentList = await _contentDbRepository.GetContentList();
            return contentList;
        }
    }
}
