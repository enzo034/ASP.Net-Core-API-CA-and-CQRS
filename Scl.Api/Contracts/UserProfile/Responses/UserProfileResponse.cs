using Domain.Aggregates.UserProfileAggregate;

namespace Scl.Api.Contracts.UserProfile.Responses
{
    public record UserProfileResponse
    {
        public Guid UserProfileId { get; set; }
        public BasicInformation BasicInfo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
    }
}
