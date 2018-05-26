using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modele;
using Modele.Entities.Entity;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Context c = new Context();
        Client client;

        [TestInitialize]
        public void createClient()
        {
            client = new Client();
            client.ClientLastname = "Damiens";
            client.ClientName = "Florent";
            client.ClientActive = false;
        }

        [TestMethod]
        public void AddClient()
        {
            c.Clients.Add(client);
            bool has = c.Clients.Any(c => c != null);
            c.SaveChanges();
            Assert.AreEqual(has, true);
        }

        [TestMethod]
        public void getClient()
        {
            List<Client> listClient = c.Clients.ToList();
            Assert.IsNotNull(listClient);
            Assert.AreEqual(listClient[0].ClientName,"Florent");
        }

        [TestMethod]
        public void deleteClient()
        {
            
        }
    }
}
