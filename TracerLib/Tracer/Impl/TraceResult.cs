using System.Collections.Concurrent;

namespace TracerLib.Tracer.Impl
{
    public class TraceResult
    {
        private ConcurrentDictionary<int, TraceThread> BenchmarkThreads { get; }

        public TraceResult(ConcurrentDictionary<int, TraceThread> benchmarkThreads)
        {
            BenchmarkThreads = benchmarkThreads;
        }
        
        public ConcurrentDictionary<int, TraceThread> GetBenchmarkThreads()
        {
            return BenchmarkThreads;
        }

        public TraceThread GetBenchmarkThreadById(int id)
        {
            return  BenchmarkThreads.GetOrAdd(id, new TraceThread(id));
        }
    }
}