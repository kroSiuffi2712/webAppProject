using System;
using System.Collections.Generic;
using Dto = Data.Dto;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Api.Models;

namespace Api.Repository
{
    public interface IContentManagerRepository
    {
        Task<List<ContentViewModel>> GetContentList();
    }
}