using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ 'pro' или 'expert'");
            ProDocumentWorker dc = new ExpertDocumentWorker();
            dc.key = Console.ReadLine();
            dc.OpenDocument();
            dc.EditDocument();
            dc.SaveDocument();
            Console.ReadLine();
        }
    }
    class DocumentWorker
    {
        public string key = null;
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            if (key == "pro" || key == "expert") Console.WriteLine("Документ отредактирован");
            else base.EditDocument();
        }
        public override void SaveDocument()
        {
            if (key == "pro") Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
            else base.SaveDocument();
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            if (key == "expert") Console.WriteLine("Документ сохранен в новом формате");
            else base.SaveDocument();
        }
    }
}
