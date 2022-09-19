/*
 * Задание №3
Создайте класс DocumentWorker.
В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
В тело каждого из методов добавьте вывод на экран соответствующих строк: 
"Документ открыт", "Редактирование документа доступно в версии Pro", "Сохранение документа доступно в версии Pro".
Создайте производный класс ProDocumentWorker.
Переопределите соответствующие методы, при переопределении методов выводите следующие строки:
"Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert".
Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран "Документ сохранен в новом формате".
В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker

*/



namespace lab.Task3
{

    public class DocumentWorker
    {


        public DocumentWorker()
        {
            Console.WriteLine("DocumentWorker has been initialized!\n");
        }

        public virtual void  OpenDocument() {
            Console.WriteLine("Document has been opened!\n");
        }

        public virtual void EditDocument() {
            Console.WriteLine("Document Editing is only available in PRO version of DocumentWorker. \n");
        }

        public virtual void SaveDocument() {
            Console.WriteLine("Document Saving is only available in PRO version of DocumentWorker. \n");
        }


    }



    public class ProDocumentWorker : DocumentWorker
    {
        public ProDocumentWorker() : base() {
            Console.WriteLine("PRODocumentWorker has been initialized!\n");
        }

        public override void OpenDocument()
        {
            base.OpenDocument();
        }

        public override void EditDocument()
        {
            Console.WriteLine("Document has been successfuly edited! \n");
        }

        public override void SaveDocument() {
            Console.WriteLine("Document has been saved in OLD format. Other export types are availabe in EXPERT version\n");
        }

    }


    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public ExpertDocumentWorker() : base() { Console.WriteLine("ExpertDocumentWorker has been initialized!\n"); }

        public override void OpenDocument()
        {
            base.OpenDocument();
        }

        public override void EditDocument()
        {
            base.EditDocument();
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document has been saved in a new format\n");
        }
    }
    



    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the DocumentWorker!\n!" +
                "[0] for free version!\n" +
                "[1] for Pro version (pro key)\n" +
                "[2] for Expert version (expert key)");

            string? input;
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return;
            if (input == "0")
            {
                DocumentWorker documentWorker = new DocumentWorker();
                documentWorker.OpenDocument();
                documentWorker.EditDocument();
                documentWorker.SaveDocument();  
            }

            if (input == "1")
            {
                Console.WriteLine("Enter the PRO key");
                input = Console.ReadLine();

                while (input != "PRO_KEY")
                {
                    Console.WriteLine("Wrong key!");
                    input = Console.ReadLine();
                }
                ProDocumentWorker proDocumentWorket = new ProDocumentWorker();

                proDocumentWorket.OpenDocument();
                proDocumentWorket.EditDocument();
                proDocumentWorket.SaveDocument();
            }

            if (input == "2")
            {
                Console.WriteLine("Enter the EXPERT key");
                input = Console.ReadLine();

                while (input != "EXPERT_KEY")
                {
                    Console.WriteLine("Wrong key!");
                    input = Console.ReadLine();
                }
                ProDocumentWorker expertDocumentWorket = new ExpertDocumentWorker();

                expertDocumentWorket.OpenDocument();
                expertDocumentWorket.EditDocument();
                expertDocumentWorket.SaveDocument();
            }


        }
    }


}
