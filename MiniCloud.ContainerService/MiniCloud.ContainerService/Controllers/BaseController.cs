using System.Linq;
using System.Text.Json;
using JWT.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MiniCloud.ContainerService.Controllers
{
    public class BaseController: Controller
    {

        protected int AccountId { get; set; }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            var authHeader = context.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "Authorization").Value;
            if (!authHeader.Any())
            {
                return;
            }

            var json = new JwtBuilder().Decode(authHeader.FirstOrDefault());
            dynamic data = JsonSerializer.Deserialize<dynamic>(json);
            AccountId = data.accId;
        }
    }
}
