using System;
using System.Collections;
using System.Collections.Generic;
using EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy.Machines
{
    // Esse é um robo de combate, para poder utilizar o robo ele deve saber socar, chutas e bloquear
    // podem existir vários tipos de robo, cada robo implementa sua própria forma de socar chutar e bloquear
    // o robo deve retornar um valor inteiro que representar quanto de dano ele causa ou ele absorve.
    public abstract class CombatMachine
    {
        private int _life = 100;

        public int Life
        {
            get { return _life; }
        }

        public abstract int GetEnergy();

        public void TakeDamage(int damage)
        {
            _life -= damage;
        }

        public abstract string Name { get; }

        public abstract void ResetEnergy();

        public abstract ActionResult PerformPunch();

        public abstract ActionResult PerformKick();

        public abstract IDictionary<string, Func<ActionResult>> GetPossibleActions();

        public abstract ActionResult PerformBlock();

        public abstract bool CanPlayAgain();

        public bool IsDead()
        {
            return _life <= 0;
        }
    }
}
