using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentApp
{
  public class SingletonDocument
  {
    private static SingletonDocument _instance;
    private List<Document> _documents;

    private SingletonDocument()
    {
      _documents = new List<Document>();
    }

    public static SingletonDocument GetInstance()
    {
      if (_instance == null)
      {
        _instance = new SingletonDocument();
      }
      return _instance;
    }

    public void AddDocument(Document document)
    {
      _documents.Add(document);
    }

    public void ListAllDocuments()
    {
      Console.WriteLine("Список документов: ");

      for (int indexDoc = 0; indexDoc < _documents.Count; ++indexDoc)
      {
        Console.WriteLine($"[{indexDoc}] {_documents[indexDoc].Name} (Путь: {_documents[indexDoc].DocumentPath})");
      }
    }

    public void DisplayDocInfo(int indexDoc)
    {
      if (indexDoc >= 0 && indexDoc < _documents.Count)
      {
        _documents[indexDoc].DisplayInfo();
      }
      else
      {
        Console.WriteLine("Неверный индекс");
      }
    }
  }
}
