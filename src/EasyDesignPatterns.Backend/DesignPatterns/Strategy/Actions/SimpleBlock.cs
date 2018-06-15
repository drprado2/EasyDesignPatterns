using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions
{
    public class SimpleBlock : IBlocker
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
            return "Bloqueio com os braços!";
        }

        public ActionResult Block()
        {
            return new ActionResult(10);
        }
    }
}
