﻿using CQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQ.AuthProvider.SDK.IntegrationTests
{
    [TestClass]
    public class AuthServiceTest : BaseIntegrationTest
    {

        #region Create
        [TestMethod]
        public async Task WhenCredentialsValid_ThenReturnNewAuth()
        {
            var auth = await base.authService.CreateAsync(new("email@gmail.com", "!12345678", "role")).ConfigureAwait(false);

            Assert.IsNotNull(auth);
            Assert.AreEqual("email@gmail.com", auth.Email);
            CollectionAssert.Contains(auth.Roles.ToList(), new Roles("role"));
        }
        #endregion
    }
}
