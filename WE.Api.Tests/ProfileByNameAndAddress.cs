﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WE.Api.Tests
{

    [TestFixture]
    public class ProfileByNameAndAddress
    {

        private readonly string _apiKey;

        public ProfileByNameAndAddress()
        {
            _apiKey = ConfigurationManager.AppSettings["WEAPiKey"].ToString();
        }

        [Test]
        public void ShouldNotThrowAnError()
        {

            var api = new WealthEngineApi(_apiKey, "SANDBOX");
            var response = api.GetProfileByEmailAsync("john@doe.com", "John", "Doe").Result;

        }

    }

}