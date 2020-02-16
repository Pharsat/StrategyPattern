using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternAbstractImplementation
{
    interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
