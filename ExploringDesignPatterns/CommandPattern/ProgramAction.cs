namespace CommandPattern
{
    // Класс "Команда" (Command):
    // объявляет интерфейс для выполнения операции
    public abstract class ProgramAction : IProgramAction
    {
        protected Writer writer;

        public ProgramAction(Writer writer)
        {
            this.writer = writer;
        }

        public abstract void Execute();
        public abstract void Undo();
        public abstract void Redo();
    }
}
