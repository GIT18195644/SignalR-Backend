using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISignalR.Models
{
    public interface IHubClient
    {
        Task BroadcastMessage();
    }
}
