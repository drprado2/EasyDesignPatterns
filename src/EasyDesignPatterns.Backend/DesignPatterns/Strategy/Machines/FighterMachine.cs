using System;
using System.Collections.Generic;
using EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Machines
{
    // Esse é um robo lutador, ele possui pernas turbinadas para o chute assim como o destroyer machine, para soco
    // ele possui punhos simples, e para bloquear ele também usas a guarda de seus braços
    public class FighterMachine : CombatMachine
    {
        private const int _fullEnergy = 100;

        private int _energy = _fullEnergy;

        private readonly IPuncher _puncher;

        private readonly IKicker _kicker;

        private readonly IBlocker _blocker;

        private readonly IResolvePossibleActions _resolvePossibleActions;

        public FighterMachine()
        {
            _puncher = new SimplePunch();
            _kicker = new TurbineKick();
            _blocker = new SimpleBlock();
            _resolvePossibleActions = new ResolvePossibleActionsDefault();
        }

        public override int GetEnergy()
        {
            return _energy;
        }

        public override string Name { get => "Robo Lutador"; }

        public override void ResetEnergy()
        {
            _energy = _fullEnergy;
        }

        public override bool CanPlayAgain()
        {
            return GetPossibleActions().Count > 1;
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
