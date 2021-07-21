using System;
using BiomedSympCertificate.Application.AppServices;

namespace BiomedSympCertificate.Presentation
{
    public class PrincipalPresenter : IPrincipalPresenter
    {
        public IPrincipalForm PrincipalForm { get; }
        private readonly IBiomedAppService _biomedAppService;

        public PrincipalPresenter(
            IPrincipalForm principalForm,
            IBiomedAppService biomedAppService)
        {
            PrincipalForm = principalForm;
            _biomedAppService = biomedAppService;

            Handles();
        }
        
        public void Handles()
        {
            PrincipalForm.OnCreateReportClick += OnCreateReportClick;

            PrincipalForm.Handles();
        }

        private void OnCreateReportClick(object sender, EventArgs e)
        {
            PrincipalForm.SetCursorToWait();

            try
            {
                var biomedViewModel = PrincipalForm.SelectSpreadsheetsFiles();
                if (Equals(biomedViewModel, null))
                {
                    return;
                }

                _biomedAppService.CreateDistinctSubscriberReport(biomedViewModel);

                PrincipalForm.ShowSuccessMessage("Tá no grau, mami!");
            }
            catch (FormatException)
            {
                PrincipalForm.ShowWarningMessage($@"O formato dos dados na planilha não é compatível com o esperado.{Environment.NewLine}Revise a planilha ou selecione outra planilha.");
            }
            catch (InvalidOperationException)
            {
                PrincipalForm.ShowWarningMessage($@"A planilha de resultado está aberta ou sendo usada por outro programa.{Environment.NewLine}Feche a planilha e tente novamente.");
            }
            finally
            {
                PrincipalForm.SetCursorToDefault();
            }
        }
    }
}
