using System;
using BiomedSympCertificate.Application.ViewModels;

namespace BiomedSympCertificate.Presentation
{
    public interface IPrincipalForm
    {
        event EventHandler OnCreateReportClick;

        void Handles();
        void SetCursorToWait();
        void SetCursorToDefault();
        BiomedViewModel SelectSpreadsheetsFiles();

        void ShowSuccessMessage(
            string text);

        void ShowWarningMessage(
            string text);
    }
}
