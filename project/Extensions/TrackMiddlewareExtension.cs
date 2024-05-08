using Solid.API.Middlewares;

namespace Web.Net.API.Extensions
{
    public static class TrackMiddlewareExtension
    {
        public static IApplicationBuilder UseTrack(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TrackMiddleware>();
        }
    }
}
