using System;
using System.Collections.Generic;
using EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Machines
{
    // Esse é um robo de destruição, ele não possui escudo, ele possui luvas com espinhos para socar, e pernas turbinadas
    // para chutas
    public class DestroyerMachine : CombatMachine
    {
        private const int _fullEnergy = 100;

        private int _energy = _fullEnergy;

        private readonly IPuncher _puncher;

        private readonly IKicker _kicker;

        private readonly IBlocker _blocker;

        private readonly IResolvePossibleActions _resolvePossibleActions;

        public DestroyerMachine()
        {
            _puncher = new ThornsPunch();
            _kicker = new TurbineKick();
            _blocker = new NoBlock();
            _resolvePossibleActions = new ResolvePossibleActionsDefault();
        }

        public override int GetEnergy()
        {
            return _energy;
        }

        public override bool CanPlayAgain()
        {
            return GetPossibleActions().Count > 1;
        }

        public override string Name { get => "Robo Destruídor"; }

        public override void ResetEnergy()
        {
            _energy = _fullEnergy;
        }

        public override ActionResult PerformPunch()
        {
            _energy -= _puncher.GetEnergyConsumed();
            return _puncher.Punch();
        }

        public override ActionResult PerformKick()
        {
            _energy -= _kicker.GetEnergyConsumed();
            return _kicker.Kick();
        }

        public override ActionResult PerformBlock()
        {
            _energy -= _blocker.GetEnergyConsumed();
            return _blocker.Block();
        }

        public override IDictionary<string, Func<ActionResult>> GetPossibleActions()
        {
            var possibles = new Dictionary<Func<ActionResult>, IAction>()
            {
                {PerformPunch, _puncher },
                {PerformKick, _kicker },
                {PerformBlock, _blocker }
            };

            return _resolvePossibleActions.Resolve(possibles, _energy);
        }
    }
}
