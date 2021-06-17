using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Topshelf;

namespace NotifyMeService
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {
                x.Service<NotifyMe>(s =>
                {
                    s.ConstructUsing(notifyme => new NotifyMe());
                    s.WhenStarted(notifyme => notifyme.Start());
                    s.WhenStopped(notifyme => notifyme.Stop());

                });
                x.RunAsLocalSystem();
                x.SetServiceName("NotifyMeService");
                x.SetDisplayName("Notify Me Service");
                x.SetDescription("This service notifies you when users send questions.");

            });
            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
        }
    }
}
