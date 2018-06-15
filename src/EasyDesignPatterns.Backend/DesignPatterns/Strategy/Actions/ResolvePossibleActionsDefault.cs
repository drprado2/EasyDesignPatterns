using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions
{
    public class ResolvePossibleActionsDefault : IResolvePossibleActions
    {
        public IDictionary<string, Func<ActionResult>> Resolve(IDictionary<Func<ActionResult>, IAction> actions, int currentEnergy)
        {
            var result = new Dictionary<string, Func<ActionResult>>();

            foreach (var action in actions)
                if (action.Value.GetEnergyConsumed() <= currentEnergy)
                    result.Add(action.Value.GetActionName(), action.Key);

            result.Add("Nenhuma Ação", () => new ActionResult(0));

            return result;
        }
    }
}
