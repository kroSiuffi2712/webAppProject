using Manager.Content;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dto = Data.Dto;
using Api.Models;
using System;
using Api.App_Start;

namespace Api.Repository
{
    public class ContentManagerRepository : IContentManagerRepository
    {
        private readonly IContentRepository _contentRepository;

        public ContentManagerRepository()
            : this(null)
        { }
        public ContentManagerRepository(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository ?? new ContentRepository();
        }

        /// <summary>
        /// Get a content List.  
        /// </summary>
        /// <returns></returns>
        public async Task<List<ContentViewModel>> GetContentList()
        {
            try
            {

                var contentList = await _contentRepository.GetContentList();
                var contentViewModelList = MappingConfig.Mapper.Map<List<Dto.Content>, List<ContentViewModel>>(contentList);
                return contentViewModelList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}