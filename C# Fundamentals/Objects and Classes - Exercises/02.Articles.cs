using System;

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
        string[] input = Console.ReadLine().Split(", ");

        Article article = new Article()
        {
            Title = input[0],
            Content = input[1],
            Author = input[2]
        };

        int commands = int.Parse(Console.ReadLine());

        for (int i = 0; i < commands; i++)
        {
            string[] command = Console.ReadLine().Split(": ");

            if (command[0] == "Edit")
            {
                article.Content = command[1];
            }
            else if (command[0] == "ChangeAuthor")
            {
                article.Author = command[1];
            }
            else if (command[0] == "Rename")
            {
                article.Title = command[1];
            }
        }
        Console.WriteLine(article);
    }
}