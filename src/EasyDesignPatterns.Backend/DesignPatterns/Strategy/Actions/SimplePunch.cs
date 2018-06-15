using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions
{
    public class SimplePunch : IPuncher
    {
        public int GetEnergyConsumed()
        {
            return 20;
        }

        public ActionResult Execute()
        {
            return Punch();
        }

        public string GetActionName()
        {
            return "Soco Simples!";
        }

        public ActionResult Punch()
        {
            return new ActionResult(20);
        }
    }
}
