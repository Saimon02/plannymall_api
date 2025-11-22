using plannymall_api.Models;

namespace plannymall_api.Data.PostgreSql.PasswordResetTokenData.Interface
{
    public interface IPasswordResetTokenData
    {
        Task<IEnumerable<PasswordResetToken>?> GetAllPasswordResetTokensAsync();

        Task<IEnumerable<PasswordResetToken>?> GetAllPasswordResetTokensByUserIdAsync(int userId);

        Task<PasswordResetToken?> GetPasswordResetTokenByIdAsync(int id);

        Task<bool> InsertPasswordResetTokenAsync(PasswordResetToken cmd);

        Task<bool> UpdatePasswordResetTokenAsync(PasswordResetToken cmd);
    }
}
