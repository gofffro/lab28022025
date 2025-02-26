using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentApp
{
  public class Document
  {
    public required string Name { get; set; }
    public required string Author { get; set; }
    public List<string> Keywords { get; set; } = new List<string>();
    public required string Theme { get; set; }
    public required string PathDoc { get; set; }

    public virtual void DisplayInfo()
    {
      Console.WriteLine($"Имя документа: {Name}");
      Console.WriteLine($"Автор документа: {Author}");
      Console.WriteLine($"Ключевые слова: ");
      foreach (var word in Keywords)
      {
        Console.Write($"{word}\t");
      }
      Console.WriteLine($"Тема документа: {Theme}");
      Console.WriteLine($"Путь документа: {PathDoc}");
    }

    public class WordDocument : Document
    {
      public int WordCount { get; set; }

      public WordDocument(string name, string author, List<string> keywords, string theme, string pathDoc, int wordCount)
      {
        Name = name;
        Author = author;
        Keywords = keywords;
        Theme = theme;
        PathDoc = pathDoc;
        WordCount = wordCount;
      }

      public override void DisplayInfo()
      {
        base.DisplayInfo();
        Console.WriteLine($"Количество слов: {WordCount}");
      }
    }
  }
}
