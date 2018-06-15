using System;
using System.Collections.Generic;
using System.Text;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions
{
    // Para implementar essa interface a classe deverá saber socar
    public interface IPuncher : IAction
    {
        ActionResult Punch();
    }
}
