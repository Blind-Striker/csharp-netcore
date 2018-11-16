namespace OpenTracing.Contrib.Instrumentation.Contracts
{
    /// <summary>
    /// Helper interface which allows unit tests to mock the <see cref="OpenTracing.Util.GlobalTracer"/>.
    /// </summary>
    public interface IGlobalTracerAccessor
    {
        ITracer GetGlobalTracer();
    }
}
