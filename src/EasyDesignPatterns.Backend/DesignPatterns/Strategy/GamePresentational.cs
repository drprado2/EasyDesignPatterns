using System;
using System.Collections.Generic;
using System.Linq;
using EasyDesignPatterns.Backend.DesignPatterns.Strategy.Actions;
using EasyDesignPatterns.Backend.DesignPatterns.Strategy.Machines;

namespace EasyDesignPatterns.Backend.DesignPatterns.Strategy
{
    public class GameMachinePossible
    {
        private Func<CombatMachine> _buildFunc;

        public GameMachinePossible(Func<CombatMachine> machineBuildFunc)
        {
            _buildFunc = machineBuildFunc;
            MachineName = machineBuildFunc().Name;
        }

        public string MachineName { get; private set; }
        public CombatMachine Machine { get => _buildFunc();  }
    }

    public class GamePresentational
    {
        private GameMachinePossible[] _machines;

        private CombatMachine _gameSelectedMachime;
        private CombatMachine _userSelectedMachine;

        public GamePresentational()
        {
            _machines = new GameMachinePossible[]
            {
                new GameMachinePossible(() => new DestroyerMachine()),
                new GameMachinePossible(() => new FighterMachine()),
                new GameMachinePossible(() => new BlockerMachine())
            };
        }

        private void PrintMachines()
        {
            var index = 1;
            foreach (var machine in _machines)
            {
                Console.WriteLine($"{index} - {machine.MachineName}");
                index++;
            }
        }

        private void GameRandomSelectMachine()
        {
            var random = new Random();
            var index = random.Next(1, 3);

            _gameSelectedMachime = _machines[index].Machine;
        }

        private void UserPlayAction()
        {
            PrintHeader();
            Console.WriteLine("Jogador escolha uma ação:\n");
            var userPossibleActions = _userSelectedMachine.GetPossibleActions();

            var userPossibleActionsIndexed = new Dictionary<int, string>();

            var index = 1;
            foreach (var userPossibleAction in userPossibleActions)
            {
                userPossibleActionsIndexed.Add(index, userPossibleAction.Key);
                index++;
            }

            foreach (var action in userPossibleActionsIndexed)
                Console.WriteLine($"{action.Key} - {action.Value}");

            var selected = Console.ReadKey();
            var selectedIndex = Convert.ToInt32(selected.KeyChar.ToString());

            var userDamage = userPossibleActions[userPossibleActionsIndexed[selectedIndex]]();
            _gameSelectedMachime.TakeDamage(userDamage.Damage);

            Console.WriteLine($"\nO robo da máquina tomou {userDamage.Damage} de dano\nContinuar =>");
            Console.ReadKey();
        }

        private void PrintHeader()
        {
            Console.WriteLine($"Você {_userSelectedMachine.Name} Vida: {_userSelectedMachine.Life} ** Energia: {_userSelectedMachine.GetEnergy()} ---- Máquina {_gameSelectedMachime.Name} Vida: {_gameSelectedMachime.Life} ** Energia: {_gameSelectedMachime.GetEnergy()}\n");
        }

        private void GamePlayRandomAction()
        {
            PrintHeader();
            Console.WriteLine("A máquina está escolhendo um movimento:\n");
            var gamePossibleActions = _gameSelectedMachime.GetPossibleActions();

            var gamePossibleActionsIndexed = new Dictionary<int, string>();

            var index = 1;
            foreach (var possible in gamePossibleActions)
            {
                gamePossibleActionsIndexed.Add(index, possible.Key);
                index++;
            }

            Console.WriteLine("As opções são:\n");
            foreach (var action in gamePossibleActionsIndexed)
                Console.WriteLine($"{action.Key} - {action.Value}");

            var random = new Random();
            var selectedIndex = random.Next(1, gamePossibleActions.Count);

            var gameSelectedAction = gamePossibleActions[gamePossibleActionsIndexed[selectedIndex]];

            Console.WriteLine($"\nA máquina escolheu {gamePossibleActionsIndexed[selectedIndex]}");

            var gameDamage = gameSelectedAction();
            _userSelectedMachine.TakeDamage(gameDamage.Damage);

            Console.WriteLine($"O seu robo tomou {gameDamage.Damage} de dano\nContinuar=>");
            Console.ReadKey();
        }

        private void PlayActions()
        {
            UserPlayAction();
            Console.Clear();
            GamePlayRandomAction();
            Console.Clear();

            if (_gameSelectedMachime.IsDead() || _userSelectedMachine.IsDead())
            {
                var subject = _gameSelectedMachime.IsDead() ? "Parabéns!!! A máquina" : "A nãoooo!!! Você";
                Console.Write($"{subject} perdeu!!!");

                Console.WriteLine("\n Fim de jogo");
                return;
            }

            if(_userSelectedMachine.CanPlayAgain() || _gameSelectedMachime.CanPlayAgain())
                PlayActions();

            _userSelectedMachine.ResetEnergy();
            _gameSelectedMachime.ResetEnergy();
        }

        public void Play()
        {
            Console.WriteLine("Bem vindos ao Combate de Robos");
            Console.WriteLine("Jogador 1 escolha seu robo \n");

            PrintMachines();
            var selected = Console.ReadKey();
            var index = Convert.ToInt32(selected.KeyChar.ToString());

            _userSelectedMachine = _machines[index -1].Machine;

            Console.WriteLine($"\nVocê selecionou {_userSelectedMachine.Name} \nContinuar =>");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("A máquina está selecionando seu robo \n");

            GameRandomSelectMachine();
            Console.WriteLine($"A máquina escolheu {_gameSelectedMachime.Name}\nContinuar =>");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("O jogo vai iniciar");
            Console.WriteLine("**********************************************\n\n");
            Console.ReadKey();

            Console.Clear();

            while (!_gameSelectedMachime.IsDead() && !_userSelectedMachine.IsDead())
            {
                PlayActions();
                Console.WriteLine("A energia dos robos acabou, reiniciando turno\nContinuar =>");
                Console.Clear();
                Console.ReadKey();
            }
        }
    }
}
