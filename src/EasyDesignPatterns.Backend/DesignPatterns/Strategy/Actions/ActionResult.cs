using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions
{
    public class ActionResult
    {
        public ActionResult(int damage)
        {
            Damage = damage;
        }

        public int Damage { get; private set; }
    }
}
