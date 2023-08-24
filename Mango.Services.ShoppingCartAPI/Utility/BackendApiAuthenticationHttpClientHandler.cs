namespace Mango.Services.ShoppingCartAPI.Utility
{
    public class BackendApiAuthenticationHttpClientHandler : DelegatingHandler
    {
        private readonly IHttpContextAccessor _accessor;

        public BackendApiAuthenticationHttpClientHandler(IHttpContextAccessor accessor)
        {
          _accessor = accessor;
        }


    }
}
