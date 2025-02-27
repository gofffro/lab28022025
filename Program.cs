
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

    static void AddDoc(SingletonDocument docManager)
    {
      Console.Write("Введите имя документа: ");
      string name = Console.ReadLine();

      Console.Write("Введите автора документа: ");
      string author = Console.ReadLine();

      Console.Write("Введите ключевые слова через запятую например: (классика, драма): ");
      List<string> keywords = new List<string>(Console.ReadLine().Split(','));

      Console.Write("Введите тему документа: ");
      string theme = Console.ReadLine();

      Console.Write("Введите путь к документу: ");
      string pathDoc = Console.ReadLine();

      Console.Write("Выберите тип документа ([1]Word, [2]PDF, [3]Excel, [4]TXT, [5]HTML): ");
      string docType = Console.ReadLine();

      Document doc = null;

      switch (docType)
      {
        case "1":
          doc = new WordDocument(name, author, keywords, theme, pathDoc, GetWordCount());
          break;
        case "2":
          doc = new PdfDocument(name, author, keywords, theme, pathDoc, GetPageCount());
          break;
        case "3":
          doc = new ExcelDocument(name, author, keywords, theme, pathDoc, GetSheetCount());
          break;
        case "4":
          doc = new TxtDocument(name, author, keywords, theme, pathDoc, GetSymbolCount());
          break;
        case "5":
          doc = new HtmlDocument(name, author, keywords, theme, pathDoc, GetTagCount());
          break;
        default:
          Console.WriteLine("Ошибка!");
          return;
      }

      if (doc != null)
      {
        docManager.AddDocument(doc);
        Console.WriteLine("Документ добавлен.");
      }

    }
  }
}
