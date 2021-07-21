using BiomedSympCertificate.Domain.Model.Entities;
using BiomedSympCertificate.Domain.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BiomedSympCertificate.Domain.Service.Services
{
    public class SubscriberService : ISubscriberService
    {
        public ICollection<Subscriber> CreateSubscribers(
            DataSet spreadsheet)
        {
            var subscribers = new List<Subscriber>();

            foreach (DataRow row in spreadsheet.Tables[0].Rows)
            {
                var signDateTime = Convert.ToDateTime(row[0]);
                var name = row[1].ToString().Trim();
                var email = row[2].ToString().Trim();
                var registration = row[3].ToString().Trim();

                subscribers.Add(new Subscriber(signDateTime, name, email, registration));
            }

            return subscribers;
        }

        public IEnumerable<Subscriber> GetDistinctSubscribers(
            ICollection<Subscriber> subscribers,
            int minimumCount)
        {
            return subscribers
                .GroupBy(x => x.Email)
                .Where(x => x.ToList().Count >= minimumCount)
                .Select(x => x.ToList())
                .Select(x => x[0])
                .ToList();
        }
    }
}
