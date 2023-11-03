namespace SqliteFallbackEF.Sample
{
    public static class ControllerRegistry
    {
        public static void RegisterControllers(this WebApplication application) =>
            application.Index();

        private static void Index(this WebApplication application) =>
            application.MapGet("/", () => Results.Ok());
    }
}
