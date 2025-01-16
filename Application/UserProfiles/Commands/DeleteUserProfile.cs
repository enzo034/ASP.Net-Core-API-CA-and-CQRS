using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserProfiles.Commands
{
    public class DeleteUserProfile : IRequest<Unit>
    {
        public Guid UserProfileId { get; set; }
    }
}
