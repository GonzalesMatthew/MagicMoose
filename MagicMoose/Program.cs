using System;

namespace MagicMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            var _responses = new ResponseRepository();
            Console.WriteLine("Ask the Magic Moose a question...");
            var question = Console.ReadLine();
            if (question.Length == 0) Environment.Exit(0);
            if (question.Length > 0) Console.WriteLine(_responses.Reply()); 
        }
    }
}
