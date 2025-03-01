using System;
using System.Collections.Generic;

namespace DocumentApp
{
  public class DocManager
  {
    private List<Document> _documents;

    public DocManager()
    {
      _documents = new List<Document>();
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
        Console.WriteLine($"\n[{indexDoc}] {_documents[indexDoc].Name} (Путь: {_documents[indexDoc].PathDoc})\n");
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