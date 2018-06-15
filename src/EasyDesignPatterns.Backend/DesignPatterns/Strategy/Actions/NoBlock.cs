using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions
{
    public class NoBlock : IBlocker
    {
        public int GetEnergyConsumed()
        {
            return 10;
        }

        public ActionResult Execute()
        {
            return Block();
        }

        public string GetActionName()
        {
            return "Eu não sei bloquear Y.Y";
        }

        public ActionResult Block()
        {
            return new ActionResult(0);
        }
    }
}
