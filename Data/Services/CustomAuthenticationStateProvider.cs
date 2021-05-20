using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorServerTutorial.Data.Services
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {

        private ISessionStorageService Service;

        public CustomAuthenticationStateProvider(ISessionStorageService service)
        {
            this.Service = service;
        }
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var username =await Service.GetItemAsync<string>("username");
            ClaimsIdentity identity;
            
            if(username!=null)
            {
               identity = new ClaimsIdentity(new[] {
                        new Claim(ClaimTypes.Name,username),
                    }, "api_auth_type"); 
            }
            else
            {
                identity = new ClaimsIdentity();
            }

            var user = new ClaimsPrincipal(identity);

            return await Task.FromResult(new AuthenticationState(user));
        }

        public void MarkUserAuthenticated(string emailAddress)
        {
            var identity = new ClaimsIdentity(new[] {
               new Claim(ClaimTypes.Name,emailAddress),
            }, "api_auth_type") ;

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
        public void MarkUserUnAuthorized()
        {
            Service.ClearAsync();

            var identity = new ClaimsIdentity();

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
