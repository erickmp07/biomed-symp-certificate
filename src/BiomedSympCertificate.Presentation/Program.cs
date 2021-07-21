using BiomedSympCertificate.Infrastructure.IoC;
using System;
using System.Windows.Forms;

namespace BiomedSympCertificate.Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            ContentRootBootstrapper.RegisterServicesInNewContainer();

            var principalPresenter = IocResolver.Resolve<IPrincipalPresenter>();

            System.Windows.Forms.Application.Run((PrincipalForm)principalPresenter.PrincipalForm);
        }
    }
}
