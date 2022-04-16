using Customer.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Persistence.Database.Configuration
{
    public class ClientConfiguration
    {
        public ClientConfiguration(EntityTypeBuilder<Client> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.ClientId);
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(100);

            var clients = new List<Client>();
            var random = new Random();

            for (var i = 1; i <= 100; i++)
            {
                clients.Add(new Client
                {
                    ClientId = i,
                    Name = $"Client {i}"
                });
            }
            entityBuilder.HasData(clients);
        }
    }
}
