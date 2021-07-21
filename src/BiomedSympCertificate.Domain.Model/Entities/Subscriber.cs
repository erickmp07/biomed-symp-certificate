using System;

namespace BiomedSympCertificate.Domain.Model.Entities
{
    public class Subscriber : IComparable<Subscriber>
    {
        public DateTime SignDateTime { get; }
        public string Name { get; }
        public string Email { get; }
        public string Registration { get; }

        public Subscriber(
            DateTime signDateTime, 
            string name, 
            string email, 
            string registration)
        {
            SignDateTime = signDateTime;
            Name = name;
            Email = email;
            Registration = registration;
        }

        public int CompareTo(Subscriber other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }
    }
}
