using System;

namespace CommandPattern
{
    // Класс "Получатель" (Receiver):
    // располагает информацией о способах выполнения операций,
    // необходимых для удовлетворения запроса
    public class Writer
    {
        public void Copy()
        {
            Console.WriteLine("Item was copped");
        }

        public void Undo()
        {
            Console.WriteLine("Undone");
        }

        public void Redo()
        {
            Console.WriteLine("Reded");
        }
    }
}
