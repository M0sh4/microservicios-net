using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Service.EventHandlers.Commands
{
    public class ClientCreateCommand : INotification
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
    }
}
