namespace OpenTracing.Contrib.Instrumentation.AspNetCore
{
    public class AspNetCoreDiagnosticOptions
    {
        public HostingOptions Hosting { get; } = new HostingOptions();
    }
}
