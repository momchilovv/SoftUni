using System;
using System.Collections.Generic;

class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Article> articles = new List<Article>();

        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string[] input = Console.ReadLine().Split(", ");

            Article article = new Article()
            {
                Title = input[0],
                Content = input[1],
                Author = input[2]
            };

            articles.Add(article);
        }

        Console.WriteLine(string.Join("\r\n", articles));
    }
}