using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions
{
    public interface IResolvePossibleActions
    {
        IDictionary<string, Func<ActionResult>> Resolve(IDictionary<Func<ActionResult>, IAction> actions, int currentEnergy);
    }
}
