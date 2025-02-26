using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentApp
{
  public class Document
  {
    public string Name { get; set; }
    public string Author { get; set; }
    public List<string> Keywords { get; set; } = new List<string>();
    public string Theme { get; set; }
    public string PathDoc { get; set; }

    public virtual void DisplayInfo()
    {
      Console.WriteLine($"Имя документа: {Name}");
      Console.WriteLine($"Автор документа: {Author}");
      Console.WriteLine($"Ключевые слова: ");
      foreach (var word in Keywords)
      {
        Console.Write($"{word}\t");
      }
      Console.WriteLine($"Путь документа: {PathDoc}");                              
    }
  }
}
