using EatAppBlazor.Common;
using EatAppBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatAppBlazor.Services
{
    public interface IRestApiService
    {
        Task<bool> IsAccessibleAsync();
        Task<UserAuthResponse> LoginAsync(string username, string password);
        Task<List<UserProfile>> ListAllUserAsync();
        Task<UserProfile> GetUserAsync(string username);
        Task<UserAuthResponse> ChangePasswordAsync(string username, string oldPassword, string newPassword);
        Task<string> AddUserAsync(string username, string password, string email, UserRole role);
        Task<UserAuthResponse> UpdateUserAsync(string username, string email, string fullname);
        Task<List<Fnb>> ListAllFnbAsync();
        Task<Fnb> GetFnbAsync(int fnbId);
        Task<string> AddFnbAsync(string fnbName, FnbType fnbType);
        Task<List<FnbComment>> ListAllFnbCommentAsync(int fnbId);
        Task<int> CountAllFnbCommentAsync(int fnbId);
        Task<string> AddFnbCommentAsync(int fnbId, string comment, int rating, int commenterId);

    }
}
