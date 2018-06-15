using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions
{
    public class TurbineKick : IKicker
    {
        public int GetEnergyConsumed()
        {
            return 60;
        }

        public ActionResult Execute()
        {
            return Kick();
        }

        public string GetActionName()
        {
            return "Chute TURBINADOOOOO!";
        }

        public ActionResult Kick()
        {
            return new ActionResult(50);
        }
    }
}
