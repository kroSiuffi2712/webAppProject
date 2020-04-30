using System;

namespace Data.Dto
{
    public class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public Nullable<int> Order { get; set; }
        public Section Section { get; set; }
    }
}
