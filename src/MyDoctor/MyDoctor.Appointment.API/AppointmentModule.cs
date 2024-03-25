using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace MyDoctor.Appointment.API
{
    public static class AppointmentModule
    {
        public static IServiceCollection AddAppointmentModule(this IServiceCollection services)
        {
            //services.InjectService();

            return services;
        }

        public static IApplicationBuilder UseAppointmentModule(this IApplicationBuilder app)
        {
            return app;
        }
    }

}
