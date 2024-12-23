using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 1.Entity.DDD.Entity.Domain
{
    public class Customer
    {
        public Customer(string name, string email, string address)
        {
            CustomerId = Guid.NewGuid();  // Benzersiz kimlik oluşturuluyor
            Name = name;
            Email = email;
            Address = address;
        }

        // Entity'nin kimliği, benzersizdir ve değişmez
        public Guid CustomerId { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }


        // Davranışlar: Müşteri adresini güncellemek için bir metod
        public void UpdateAddress(string newAddress)
        {
            Address = newAddress;
        }

        // Davranışlar: Müşteri e-posta adresini güncellemek için bir metod
        public void UpdateEmail(string newEmail)
        {
            Email = newEmail;
        }

        // Entity'yi karşılaştırmak için Equals metodunu override ediyoruz
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var other = (Customer)obj;
            return CustomerId == other.CustomerId;  // Kimlik üzerinden karşılaştırma
        }
    }
}