using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
namespace SecureDevelopment_1
{
    public class UserHandlerAuthentication: AuthorizationHandler<UserAuthentication>
    {
        protected override Task HandleRequirementAsync( AuthorizationHandlerContext context, UserAuthentication requirement)
        {




            var claim = context.User.FindFirst("UserAuthentication");
            if (claim.Value == requirement.Password|| claim.Value == requirement.Login)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;




        }



    }
}
