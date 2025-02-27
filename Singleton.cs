using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentApp
{
  public class SingletonDocument
  {
    private static SingletonDocument instance;
    private List<Document> documents;

    private SingletonDocument()
    {
      documents = new List<Document>();
    }

    public static SingletonDocument GetInstance()
    {
      if (instance == null)
      {
        instance = new SingletonDocument();
      }
      return instance;
    }

    public void AddDocument(Document document)
    {
      documents.Add(document);
    }

    public void ListAllDocuments()
    {
      Console.WriteLine("Список документов: ");
      for (int indexDoc = 0; indexDoc < documents.Count; ++indexDoc)
      {
        Console.WriteLine($"[{indexDoc}] {documents[indexDoc].Name} (Путь: {documents[indexDoc].PathDoc})");
      }
    }
  }
}
