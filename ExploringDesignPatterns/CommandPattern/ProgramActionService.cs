using System.Collections.Generic;

namespace CommandPattern
{
    // Класс "Инициатор" (Invoker):
    // обращается к команде для выполнения запроса
    public class ProgramActionService
    {
        private List<IProgramAction> actions;
        private int currentIndex;

        public ProgramActionService()
        {
            actions = new List<IProgramAction>();
            currentIndex = -1;
        }

        public bool CanUndo => currentIndex >= 0;
        public bool CanRedo => actions.Count > 0 && currentIndex < actions.Count - 1;

        public void AddProgramAction(IProgramAction action)
        {
            actions.Add(action);
            currentIndex++;
        }

        public void Execute()
        {
            actions[currentIndex].Execute();
        }

        public void Undo()
        {
            if (CanUndo)
            {
                actions[currentIndex--].Undo();
            }
        }

        public void Redo()
        {
            if (CanRedo)
            {
                actions[++currentIndex].Redo();
            }
        }
    }
}
