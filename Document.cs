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
      Console.WriteLine($"\nТема документа: {Theme}");
      Console.WriteLine($"Путь документа: {PathDoc}");
    }
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

  public class PdfDocument : Document
  {
    public int PageCount { get; set; }

    public PdfDocument(string name, string author, List<string> keywords, string theme, string pathDoc, int pageCount)
    {
      Name = name;
      Author = author;
      Keywords = keywords;
      Theme = theme;
      PathDoc = pathDoc;
      PageCount = pageCount;
    }

    public override void DisplayInfo()
    {
      base.DisplayInfo();
      Console.WriteLine($"Количество страниц: {PageCount}");
    }
  }

  public class ExcelDocument : Document
  {
    public int SheetCount { get; set; }

    public ExcelDocument(string name, string author, List<string> keywords, string theme, string pathDoc, int sheetCount)
    {
      Name = name;
      Author = author;
      Keywords = keywords;
      Theme = theme;
      PathDoc = pathDoc;
      SheetCount = sheetCount;
    }

    public override void DisplayInfo()
    {
      base.DisplayInfo();
      Console.WriteLine($"Количество листов: {SheetCount}");
    }
  }

  public class TxtDocument : Document
  {
    public int SymbolCount { get; set;}

    public TxtDocument(string name, string author, List<string> keywords, string theme, string pathDoc, int symbolCount)
    {
      Name = name;
      Author = author;
      Keywords = keywords;
      Theme = theme;
      PathDoc = pathDoc;
      SymbolCount = symbolCount;
    }

    public override void DisplayInfo()
    {
      base.DisplayInfo();
      Console.WriteLine($"Количество символов: {SymbolCount}");
    }
  }

  public class HtmlDocument : Document
  {
    public int TagCount { get; set; }

    public HtmlDocument(string name, string author, List<string> keywords, string theme, string pathDoc, int tagCount)
    {
      Name = name;
      Author = author;
      Keywords = keywords;
      Theme = theme;
      PathDoc = pathDoc;
      TagCount = tagCount;
    }

    public override void DisplayInfo()
    {
      base.DisplayInfo();
      Console.WriteLine($"Количество тегов: {TagCount}");
    }
  }
}
