using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentApp
{
  public class Singleton
  {
    private static Singleton s_instance;
    private DocManager _docManager;

    private Singleton()
    {
      _docManager = new DocManager();
    }

    public static Singleton GetInstance()
    {
      if (s_instance == null)
      {
        s_instance = new Singleton();
      }
      return s_instance;
    }

    public void ShowMenu()
    {
      string userInput;
      do
      {
        Console.WriteLine("Меню: ");
        Console.WriteLine("1. Добавить документ");
        Console.WriteLine("2. Список документов");
        Console.WriteLine("3. Выбрать документ");
        Console.WriteLine("4. Выйти");
        Console.Write("Ввод: ");
        userInput = Console.ReadLine();

        switch (userInput)
        {
          case "1":
            AddDoc();
            break;
          case "2":
            _docManager.ListAllDocuments();
            break;
          case "3":
            SelectDocument();
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

    private void AddDoc()
    {
      Console.Write("Введите имя документа: ");
      string name = Console.ReadLine();

      Console.Write("Введите имя автора документа: ");
      string author = Console.ReadLine();

      Console.Write("Введите ключевые слова через запятую, например, 'классика, драма': ");
      List<string> keywords = new List<string>(Console.ReadLine().Split(','));

      Console.Write("Введите название темы документа: ");
      string theme = Console.ReadLine();

      Console.Write("Введите путь к документу: ");
      string pathDoc = Console.ReadLine();

      Console.Write("1. Word\n2. PDF\n3. Excel\n4. TXT\n5. HTML\nВыберите тип документа: ");
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
        _docManager.AddDocument(doc);
        Console.WriteLine("Документ добавлен.");
      }
    }

    private void SelectDocument()
    {
      Console.Write("Введите индекс документа для просмотра информации: ");
      if (int.TryParse(Console.ReadLine(), out int indexDoc))
      {
        Console.WriteLine();
        _docManager.DisplayDocInfo(indexDoc);
        Console.WriteLine();
      }
      else
      {
        Console.WriteLine("Ошибка!");
      }
    }

    private int GetWordCount()
    {
      Console.Write("Введите количество слов: ");
      return int.Parse(Console.ReadLine());
    }

    private int GetPageCount()
    {
      Console.Write("Введите количество страниц: ");
      return int.Parse(Console.ReadLine());
    }

    private int GetSheetCount()
    {
      Console.Write("Введите количество листов: ");
      return int.Parse(Console.ReadLine());
    }

    private int GetSymbolCount()
    {
      Console.Write("Введите количество символов: ");
      return int.Parse(Console.ReadLine());
    }

    private int GetTagCount()
    {
      Console.Write("Введите количество тегов: ");
      return int.Parse(Console.ReadLine());
    }
  }
}