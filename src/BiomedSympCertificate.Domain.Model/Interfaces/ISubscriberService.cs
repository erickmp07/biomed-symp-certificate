using System.Collections.Generic;
using System.Data;
using BiomedSympCertificate.Domain.Model.Entities;

namespace BiomedSympCertificate.Domain.Model.Interfaces
{
    public interface ISubscriberService
    {
        ICollection<Subscriber> CreateSubscribers(
            DataSet spreadsheet);

        IEnumerable<Subscriber> GetDistinctSubscribers(
            ICollection<Subscriber> subscribers,
            int minimumCount);
    }
}
