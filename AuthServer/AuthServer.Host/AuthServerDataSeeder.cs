﻿using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Account;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;
using Volo.Abp.Identity;
using Volo.Abp.IdentityServer.ApiResources;
using Volo.Abp.IdentityServer.Clients;
using Volo.Abp.IdentityServer.IdentityResources;
using Volo.Abp.PermissionManagement;
using Volo.Abp.Uow;
using ApiResource = Volo.Abp.IdentityServer.ApiResources.ApiResource;
using Client = Volo.Abp.IdentityServer.Clients.Client;

namespace AuthServer.Host
{
    public class AuthServerDataSeeder : IDataSeedContributor, ITransientDependency
    {
        private readonly IApiResourceRepository _apiResourceRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IIdentityResourceDataSeeder _identityResourceDataSeeder;
        private readonly IGuidGenerator _guidGenerator;
        private readonly IPermissionDataSeeder _permissionDataSeeder;

        private readonly AccountAppService accountAppService;

        public AuthServerDataSeeder(
            IClientRepository clientRepository,
            IApiResourceRepository apiResourceRepository,
            IIdentityResourceDataSeeder identityResourceDataSeeder,
            IGuidGenerator guidGenerator,
            IPermissionDataSeeder permissionDataSeeder,
             AccountAppService _accountAppService)
        {
            _clientRepository = clientRepository;
            _apiResourceRepository = apiResourceRepository;
            _identityResourceDataSeeder = identityResourceDataSeeder;
            _guidGenerator = guidGenerator;
            _permissionDataSeeder = permissionDataSeeder;

            //accountAppService = _accountAppService;
            
        }

        [UnitOfWork]
        public virtual async Task SeedAsync(DataSeedContext context)
        {
            //var input = new ResetPasswordDto();
            //input.UserId = Guid.Parse("A6C9CFD5-833B-13EF-C78A-39F866BCE0EC");
            //input.Password = "1q2w3E*";
            //input.ResetToken
            //await accountAppService.ResetPasswordAsync(input);

            await _identityResourceDataSeeder.CreateStandardResourcesAsync();
            await CreateApiResourcesAsync();
            await CreateClientsAsync();
            await CreateProductClientsAsync();
        }

        private async Task CreateApiResourcesAsync()
        {
            var commonApiUserClaims = new[]
            {
                "email",
                "email_verified",
                "name",
                "phone_number",
                "phone_number_verified",
                "role"
            };

            await CreateApiResourceAsync("IdentityService", commonApiUserClaims);
            await CreateApiResourceAsync("InternalGateway", commonApiUserClaims);
            await CreateApiResourceAsync("WebAppGateway", commonApiUserClaims);
            await CreateApiResourceAsync("TenantService", commonApiUserClaims);
            await CreateApiResourceAsync("BusinessService", commonApiUserClaims);
            await CreateApiResourceAsync("ResourceService", commonApiUserClaims);

            await CreateApiResourceAsync("Product", commonApiUserClaims);
            await CreateApiResourceAsync("BoxAp", commonApiUserClaims);
            await CreateApiResourceAsync("ProductApService", commonApiUserClaims);
            //await CreateApiResourceAsync("PosAppService", commonApiUserClaims);
        }

        private async Task<ApiResource> CreateApiResourceAsync(string name, IEnumerable<string> claims)
        {
            var apiResource = await _apiResourceRepository.FindByNameAsync(name);
            if (apiResource == null)
            {
                apiResource = await _apiResourceRepository.InsertAsync(
                    new ApiResource(
                        _guidGenerator.Create(),
                        name,
                        name + " API"
                    ),
                    autoSave: true
                );
            }

            foreach (var claim in claims)
            {
                if (apiResource.FindClaim(claim) == null)
                {
                    apiResource.AddUserClaim(claim);
                }
            }

            return await _apiResourceRepository.UpdateAsync(apiResource);
        }

        private async Task CreateClientsAsync()
        {
            var commonScopes = new[]
            {
                "email",
                "openid",
                "profile",
                "role",
                "phone",
                "address"
            };

            await CreateClientAsync(
                "basic-web",
                new[] { "IdentityService", "WebAppGateway", "BusinessService", "TenantService", "ProductAp", "Product", "BoxAp", "Box", "ProductApService" },
                new[] { "password" },
                "1q2w3e*".Sha256()
            );

            await CreateClientAsync(
                "business-app",
                new[] { "InternalGateway", "IdentityService" },
                new[] { "client_credentials" },
                "1q2w3e*".Sha256(),
                permissions: new[] { IdentityPermissions.Users.Default }
            );

            await CreateClientAsync(
                "resource-app",
                new[] { "ResourceService", "ResourceService" },
                new[] { "client_credentials" },
                "1q2w3e*".Sha256(),
                permissions: new[] { IdentityPermissions.Users.Default }
            );

           // await CreateClientAsync(
           //    "PosApp-app",
           //    new[] { "InternalGateway", "IdentityService", "basic-web", "WebAppGateway" },
           //    new[] { "client_credentials" },
           //    "1q2w3e*".Sha256(),
           //    permissions: new[] { IdentityPermissions.Users.Default }
           //);
        }

        private async Task CreateProductClientsAsync()
        {
            await CreateClientAsync(
                "order-app",
                new[] { "InternalGateway", "IdentityService" },
                new[] { "client_credentials" },
                "1q2w3e*".Sha256(),
                permissions: new[] { IdentityPermissions.Users.Default }
            );

            await CreateClientAsync(
                "product-app",
                new[] { "InternalGateway", "IdentityService" },
                new[] { "client_credentials" },
                "1q2w3e*".Sha256(),
                permissions: new[] { IdentityPermissions.Users.Default }
            );

            await CreateClientAsync(
                "ProductAp-app",
                new[] { "InternalGateway", "IdentityService" },
                new[] { "client_credentials" },
                "1q2w3e*".Sha256(),
                permissions: new[] { IdentityPermissions.Users.Default }
            );

            await CreateClientAsync(
                "BoxAp-app",
                new[] { "InternalGateway", "IdentityService" },
                new[] { "client_credentials" },
                "1q2w3e*".Sha256(),
                permissions: new[] { IdentityPermissions.Users.Default }
            );
        }

        private async Task<Client> CreateClientAsync(
            string name,
            IEnumerable<string> scopes,
            IEnumerable<string> grantTypes,
            string secret,
            string redirectUri = null,
            string postLogoutRedirectUri = null,
            IEnumerable<string> permissions = null)
        {
            var client = await _clientRepository.FindByCliendIdAsync(name);
            if (client == null)
            {
                client = await _clientRepository.InsertAsync(
                    new Client(
                        _guidGenerator.Create(),
                        name
                    )
                    {
                        ClientName = name,
                        ProtocolType = "oidc",
                        Description = name,
                        AlwaysIncludeUserClaimsInIdToken = true,
                        AllowOfflineAccess = true,
                        AbsoluteRefreshTokenLifetime = 31536000, //365 days
                        AccessTokenLifetime = 31536000, //365 days
                        AuthorizationCodeLifetime = 300,
                        IdentityTokenLifetime = 300,
                        RequireConsent = false
                    },
                    autoSave: true
                );
            }

            foreach (var scope in scopes)
            {
                if (client.FindScope(scope) == null)
                {
                    client.AddScope(scope);
                }
            }

            foreach (var grantType in grantTypes)
            {
                if (client.FindGrantType(grantType) == null)
                {
                    client.AddGrantType(grantType);
                }
            }

            if (client.FindSecret(secret) == null)
            {
                client.AddSecret(secret);
            }

            if (redirectUri != null)
            {
                if (client.FindRedirectUri(redirectUri) == null)
                {
                    client.AddRedirectUri(redirectUri);
                }
            }

            if (postLogoutRedirectUri != null)
            {
                if (client.FindPostLogoutRedirectUri(postLogoutRedirectUri) == null)
                {
                    client.AddPostLogoutRedirectUri(postLogoutRedirectUri);
                }
            }

            if (permissions != null)
            {
                await _permissionDataSeeder.SeedAsync(
                    ClientPermissionValueProvider.ProviderName,
                    name,
                    permissions
                );
            }

            return await _clientRepository.UpdateAsync(client);
        }
    }
}
