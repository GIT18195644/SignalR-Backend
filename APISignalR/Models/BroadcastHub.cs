using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace APISignalR.Models
{
    public class BroadcastHub : Hub<IHubClient>
    {
    }
}
