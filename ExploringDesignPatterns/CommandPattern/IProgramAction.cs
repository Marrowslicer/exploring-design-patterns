namespace CommandPattern
{
    public interface IProgramAction
    {
        void Execute();
        void Undo();
        void Redo();
    }
}
