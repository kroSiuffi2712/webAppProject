using System.Collections.Generic;
using System.Threading.Tasks;
using Dto = Data.Dto;

namespace DbManager.Content
{
    public interface IContentDbRepository
    {
        Task<List<Dto.Content>> GetContentList();
    }
}
