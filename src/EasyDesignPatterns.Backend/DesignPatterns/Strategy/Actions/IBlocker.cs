using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions
{
    // Para implementar essa interface a classe deverá saber bloquear
    public interface IBlocker : IAction
    {
        ActionResult Block();
    }
}
