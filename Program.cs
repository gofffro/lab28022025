
namespace DocumentApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      SingletonDocument docManager = SingletonDocument.GetInstance();
      ShowMenu(docManager);
    }
    static void ShowMenu(SingletonDocument docManager)
    {
      string userInput;
      do
      {
        Console.WriteLine("Меню: ");
        Console.WriteLine("1. Добавить документ");
        Console.WriteLine("2. Список документов");
        Console.WriteLine("3. Выбрать документ");
        Console.WriteLine("4. Выйти");
        userInput = Console.ReadLine();

        switch (userInput)
        {
          case "1":
            AddDoc(docManager);
            break;
          case "2":
            docManager.ListAllDocuments();
            break;
          case "3":
            SelectDocument(docManager);
            break;
          case "4":
            Console.WriteLine();
            break;
          default:
            Console.WriteLine("Ошибка. Попробуйте снова");
            break;
        }
      } while (userInput != "4");
    }
  }
}
