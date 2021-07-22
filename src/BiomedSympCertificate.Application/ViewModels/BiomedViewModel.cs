using System.Collections.Generic;

namespace BiomedSympCertificate.Application.ViewModels
{
    public class BiomedViewModel
    {
        public List<string> FilesPaths { get; }
        public string ResultPath { get; set; }
        public int MinimumCount { get; }

        public BiomedViewModel(
            List<string> filesPaths,
            string resultPath,
            int minimumCount)
        {
            FilesPaths = filesPaths;
            ResultPath = resultPath;
            MinimumCount = minimumCount;
        }
    }
}
