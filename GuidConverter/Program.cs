namespace Pihalve.GuidConverter;

internal static class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        bool launchedViaStartup = args != null && args.Any(arg => arg.Equals("startup", StringComparison.CurrentCultureIgnoreCase));

        ApplicationConfiguration.Initialize();
        var applicationContext = launchedViaStartup ? 
            new InitiallyHiddenApplicationContext<ConverterForm>(new ConverterForm()) : 
            new ApplicationContext(new ConverterForm());
        Application.Run(applicationContext);
    }
}