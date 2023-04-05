using IdentityModel.OidcClient.Browser;
using System.Threading.Tasks;

namespace auth0
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAuthenticationService
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        AuthenticationResult AuthenticationResult { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Authenticate a user against the Auth0 system, obtaining all new tokens
        /// </summary>
        /// <returns>
        /// Result containing new access, id, and refresh tokens
        /// </returns>
        Task<AuthenticationResult> Authenticate();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// Result of the logout
        /// </returns>
        Task<BrowserResultType> Logout();

        /// <summary>
        /// Authenticate a user against the Auth0 system, refereshing current tokens
        /// </summary>
        /// <returns>
        /// Result containing new access, id, and refresh tokens. Note that user
        /// claims are not returned from this method; they are only returned through
        /// the initial Authenticate call
        /// </returns>
        Task<AuthenticationResult> RefreshToken(string refreshToken);

        #endregion
    }
}
