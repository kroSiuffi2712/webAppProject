using DbManager.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Dto = Data.Dto;
namespace DbManager.Content
{
    public class ContentDbRepository : IContentDbRepository
    {
        public async Task<List<Dto.Content>> GetContentList()
        {
            try
            {
                using (var ctx = DBFactory.Context)
                {
                    var contentList = await (from cont in ctx.Contents
                                             join sec in ctx.Sections on cont.IdSection equals sec.Id
                                             select new Dto.Content
                                             {
                                                 Id = cont.Id,
                                                 Order = cont.Order,
                                                 Description = cont.Description,
                                                 Image = cont.Image,
                                                 Title = cont.Title,
                                                 Section = new Dto.Section { Id = sec.Id, Description = sec.Description, Title = sec.Title }
                                             }
                                       ).ToListAsync();

                    if (contentList != null)
                        return contentList;
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
