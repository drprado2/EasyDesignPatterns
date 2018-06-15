using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions
{
    public interface IAction
    {
        int GetEnergyConsumed();

        ActionResult Execute();

        string GetActionName();
    }
}
