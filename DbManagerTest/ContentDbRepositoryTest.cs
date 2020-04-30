using DbManager.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace DbManagerTest
{
    [TestClass]
    public class ContentDbRepositoryTest
    {
        IContentDbRepository _contentRepository;
        public ContentDbRepositoryTest()
        {
            // TODO: Add constructor logic here
            _contentRepository = new ContentDbRepository();

        }

        [TestMethod]
        public async Task GetContentListAsync()
        {
            var result = await _contentRepository.GetContentList();
            Assert.AreEqual(result.Count > 0, true);
        }
    }
}
