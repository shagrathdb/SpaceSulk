using System;

namespace SpaceSulk
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (SpaceSulk game = new SpaceSulk())
            {
                game.Run();
            }
        }
    }
#endif
}

