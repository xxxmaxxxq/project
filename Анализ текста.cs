using System;

class TextAnalyzer
{
    static void Main()
    {
        Console.WriteLine("Введите текст (для завершения введите пустую строку):");

        string inputText = "";
        string line;
        while ((line = Console.ReadLine()) != "")
        {
            inputText += line + "\n";
        }

        string[] paragraphs = inputText.Split(new string[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);
        int paragraphCount = paragraphs.Length;

        int sentenceCount = 0;
        int wordCount = 0;

        foreach (string paragraph in paragraphs)
        {
            string[] sentences = paragraph.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            sentenceCount += sentences.Length;

            foreach (string sentence in sentences)
            {
                string[] words = sentence.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                wordCount += words.Length;
            }
        }

        Console.WriteLine($"Количество абзацев: {paragraphCount}");
        Console.WriteLine($"Количество предложений: {sentenceCount}");
        Console.WriteLine($"Количество слов: {wordCount}");
    }
}
