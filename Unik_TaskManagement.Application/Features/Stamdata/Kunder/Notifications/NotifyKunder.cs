using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unik_TaskManagement.Application.Features.Stamdata.Kunder.Notifications
{
    public class NotifyKunder:INotification
    {
        public string Message { get; set; }
    }
}
