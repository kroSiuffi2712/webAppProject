using System.Collections.Generic;
using System.Threading.Tasks;
using Dto = Data.Dto;

namespace Manager.Content
{
    public interface IContentRepository
    {
        Task<List<Dto.Content>> GetContentList();
    }
}
