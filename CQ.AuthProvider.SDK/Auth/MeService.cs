﻿using CQ.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQ.AuthProvider.SDK
{
    public sealed class MeService : IMeService
    {
        private readonly AuthProviderApi _cqAuthApi;

        public MeService(AuthProviderApi cqAuthApi)
        {
            _cqAuthApi = cqAuthApi;
        }

        public async Task<AuthResult> GetAsync(string token)
        {
            var successBody = await _cqAuthApi.GetAsync<AuthLogged>(
                "me",
                headers: new List<Header> { new("Authorization", token) })
                .ConfigureAwait(false);

            return new AuthResult(successBody.Id, successBody.Email, successBody.Roles);
        }

        public async Task<bool> HasPermissionAsync(string permission, string token)
        {
            var successBody = await _cqAuthApi.PostAsync<CheckPermissionResult>(
               "me/check-permission",
               new
               {
                   permission
               },
               headers: new List<Header> { new("Authorization", token) })
               .ConfigureAwait(false);

            return successBody.HasPermission;
        }
    }
}
