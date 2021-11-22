﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaaSDES.Sim.Tokens.Generation
{
    /// <summary>
    /// Settings for <see cref="ISimTokenGenerator"/>s.
    /// </summary>
    public class GenerationSettings
    {
        /// <summary>
        /// The probabilistic distribution that a generator should produce a
        /// token.
        /// </summary>
        public object ProbabilisticDistribution { get; set; }
    }
}