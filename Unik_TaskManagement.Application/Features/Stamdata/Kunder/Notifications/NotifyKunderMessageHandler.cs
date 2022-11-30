using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unik_TaskManagement.Application.Features.Stamdata.Kunder.Notifications
{
    public class NotifyKunderMessageHandler : INotificationHandler<NotifyKunder>
    {
        public  Task Handle ( NotifyKunder notification, CancellationToken cancellationToken )
        {
            Console.WriteLine("A message has been send");
            return  Task.CompletedTask;
        }
    }
}
