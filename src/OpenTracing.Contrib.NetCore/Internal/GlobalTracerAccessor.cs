using OpenTracing.Contrib.Instrumentation.Contracts;
using OpenTracing.Util;

namespace OpenTracing.Contrib.Instrumentation.Utils
{
    public class GlobalTracerAccessor : IGlobalTracerAccessor
    {
        public ITracer GetGlobalTracer()
        {
            return GlobalTracer.Instance;
        }
    }
}
