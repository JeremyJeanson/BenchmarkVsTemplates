﻿using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace $safeprojectname$
{
    public class Benchmarks
    {
        [Benchmark(Baseline = true)]
        public void Scenario1()
        {
            // Implement your benchmark here
        }

        [Benchmark]
        public void Scenario2()
        {
            // Implement your benchmark here
        }
    }
}
