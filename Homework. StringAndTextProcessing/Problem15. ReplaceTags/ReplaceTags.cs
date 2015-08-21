using System;
/*
 Problem 15. Replace tags

Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> 
with corresponding tags [URL=…]…/URL].
Example:

input	output
<p>Please visit <a href="http://academy.telerik. com">
our site</a> to choose a training course. Also visit 
<a href="www.devbg.org">our forum</a> to discuss 
the courses.</p>	
 * 
 * 
 <p>Please visit [URL=http://academy.telerik. com]our 
 site[/URL] to choose a training course. Also visit 
 [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 */
class ReplaceTags
{
    static void Main()
    {

        Console.Write("Enter a text: ");
        string textInput = Console.ReadLine();

        string[] replaceWords = new string[3];

        replaceWords[0] = "<a href=\"";
        replaceWords[1] = "\">";
        replaceWords[2] = "</a>";


        Console.WriteLine(Replace(textInput, replaceWords));
    }
    static string Replace(string textInput, string[] replaceWords)
    {

        string lookupWord = string.Empty;
        string substring = string.Empty;

        //loop through all of the forbidden words
        for (int replaceIndex = 0; replaceIndex < replaceWords.Length; replaceIndex++)
        {
            int startIndex = 0;
            lookupWord = replaceWords[replaceIndex];

            // loop through the the element to the end
            for (int i = startIndex; i < textInput.Length - lookupWord.Length; i++)
            {
                substring = textInput.Substring(i, lookupWord.Length);// get a substring from the text

                if (substring == lookupWord)// check for equality
                {
                    startIndex = i;
                    string outcomeWord = string.Empty;
                    switch (replaceIndex)
                    {
                        case 0: outcomeWord = "[URL="; break;
                        case 1: outcomeWord = "]"; break;
                        case 2: outcomeWord = "[/URL]"; break;
                    }
                    string toReplace = textInput.Substring(startIndex, lookupWord.Length);// set part of the string to be replaced
                    textInput = textInput.Replace(toReplace, outcomeWord);// store the replaced string
                }
            }
        }
        return textInput;
    }
}