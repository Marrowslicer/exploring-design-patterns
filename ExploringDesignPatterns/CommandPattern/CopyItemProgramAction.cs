using System;

namespace CommandPattern
{
    // Класс "Конкретная команда" (ConcretCommand):
    // определяет связь между объектом-получателем Receiver и действием;
    // реализует операцию Execute путем вызова соответсвующих операций
    // объекта Receiver
    public class CopyItemProgramAction : ProgramAction
    {
        public CopyItemProgramAction(Writer writer)
            : base(writer)
        {

        }

        public override void Execute()
        {
            writer.Copy();
        }

        public override void Redo()
        {
            writer.Redo();
        }

        public override void Undo()
        {
            writer.Undo();
        }
    }
}
