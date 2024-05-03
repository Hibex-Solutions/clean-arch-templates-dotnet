using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;

namespace CleanArch.Templates.Solution.WebApi;

public class JwtBearerConfigureOptions(IConfiguration configuration)
    : IConfigureNamedOptions<JwtBearerOptions>
{
    public void Configure(string? name, JwtBearerOptions options)
    {
        Configure(options);
    }

    public void Configure(JwtBearerOptions options)
    {
        configuration.GetSection("JwtBearer").Bind(options);
    }
}