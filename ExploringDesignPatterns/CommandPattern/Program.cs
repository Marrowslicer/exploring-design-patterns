namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var programActionService = new ProgramActionService();
            var writer = new Writer();
            var copyAction = new CopyItemProgramAction(writer);

            programActionService.AddProgramAction(copyAction);
            programActionService.Execute();
            programActionService.Undo();
            programActionService.Redo();
        }
    }
}
