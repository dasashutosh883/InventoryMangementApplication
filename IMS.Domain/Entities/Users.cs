using IMS.Domain.Common;

namespace IMS.Domain.Entities
{
    public class Users : BaseEntity
    {
        public string? FullName { get; set; }
        public string? MobileNumber { get; set; }
        public string? Email { get; set; }
        public string? OTP { get; set; }
        public int RetryOtpCount { get; set; }
        public bool IsOtpEnabled { get; set; }
        public string? PasswordHash { get; set; }
        public bool IsPasswordEnabled { get; set; }
        public int UserTypeId { get; set; }
    }
}
