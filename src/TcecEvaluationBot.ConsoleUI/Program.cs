﻿namespace TcecEvaluationBot.ConsoleUI
{
    using System;

    using CommandLine;

    public static class Program
    {
        public static void Main(string[] args)
        {
            var parserResult = Parser.Default.ParseArguments<Options>(args);
            parserResult.WithParsed(RunBot);
        }

        private static void RunBot(Options options)
        {
            var bot = new TwitchBot(options);
            bot.Run();
            Console.ReadLine();
        }
    }
}
