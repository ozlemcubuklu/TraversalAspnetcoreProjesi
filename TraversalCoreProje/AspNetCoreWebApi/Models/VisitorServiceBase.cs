using AspNetCoreWebApi.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace AspNetCoreWebApi.Models
{
    public class VisitorServiceBase
    {
        private readonly IHubContext<VisitorHub> _hubContext;
    }
}