using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions
{
    public class NoKick : IKicker
    {
        public int GetEnergyConsumed()
        {
            return 10;
        }

        public ActionResult Execute()
        {
            return Kick();
        }

        public string GetActionName()
        {
            return "Eu não sei chutar Y.Y";
        }

        public ActionResult Kick()
        {
            return new ActionResult(0);
        }
    }
}
