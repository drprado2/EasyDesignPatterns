using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions
{
    public class ThornsPunch : IPuncher
    {
        public int GetEnergyConsumed()
        {
            return 50;
        }

        public ActionResult Execute()
        {
            return Punch();
        }

        public string GetActionName()
        {
            return "Soco de Espinhos HAAA!";
        }

        public ActionResult Punch()
        {
            return new ActionResult(40);
        }
    }
}
