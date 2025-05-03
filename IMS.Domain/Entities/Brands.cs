using IMS.Domain.Common;

namespace IMS.Domain.Entities
{
    public class Brands : BaseEntity
    {
        public string BrandName { get; set; }
        public string Country { get; set; }
    }
}
