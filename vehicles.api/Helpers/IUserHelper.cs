using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vehicles.api.Data.Entities;

namespace vehicles.api.Helpers
{
    public interface IUserHelper
    {
        #region basic
        Task<User> GetUserAsync(string email);
        Task<IdentityResult> AddUserAsync(User user, string password);        
        Task CheckRoleAsync(string roleName);                      
        Task AddUserToRoleAsync(User user, string roleName);        
        Task<bool> IsUserInRoleAsync(User user, string roleName);
        #endregion

        //Task<User> GetUserAsync(Guid id);

        /*
        Task<IdentityResult> UpdateUserAsync(User user);
        Task<IdentityResult> DeleteUserAsync(User user);                
        //Task<SignInResult> LoginAsync(LoginViewModel model);
        //Task<User> AddUserAsync(AddUserViewModel model, Guid imageId, UserType userType);
        Task LogoutAsync();
        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);
        Task<string> GenerateEmailConfirmationTokenAsync(User user);
        Task<IdentityResult> ConfirmEmailAsync(User user, string token);
        Task<string> GeneratePasswordResetTokenAsync(User user);
        Task<IdentityResult> ResetPasswordAsync(User user, string token, string password);
        Task<SignInResult> ValidatePasswordAsync(User user, string password);*/
    }
}