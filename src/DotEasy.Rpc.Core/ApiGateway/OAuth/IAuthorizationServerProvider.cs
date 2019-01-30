namespace DotEasy.Rpc.Core.ApiGateway.OAuth
{
    /// <summary>
    /// 身份验证服务提供者
    /// </summary>
    public interface IAuthorizationServerProvider
    {
        
        /// <summary>
        /// 验证客户端
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        bool ValidateClientAuthentication(string token);

        /// <summary>
        /// 获取载荷
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        string GetPayloadString(string token);
    }
}