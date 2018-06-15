using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions
{
    public class ShieldBlock : IBlocker
    {
        public int GetEnergyConsumed()
        {
            return 25;
        }

        public ActionResult Execute()
        {
            return Block();
        }

        public string GetActionName()
        {
            return "Escudo Protetor HAAA!";
        }

        public ActionResult Block()
        {
            return new ActionResult(35);
        }
    }
}
