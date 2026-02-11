using System;
using System.Collections.Generic;
using System.Text;

namespace MagicLibrary
{
    internal class LibraryService
    {
        public static int totalBookRead;
        public static void LogRead() 
        {
            totalBookRead++;
        }
    }
}
