using System;
using System.Globalization;
using System.IO;

namespace csreview
{
  class GarbageCollector
  {
    public static void CollectGarbage()
    {
      StreamReader streamReaderObject = null;
      try
      {
          // Assigns "streamReaderObject" to read from a text file named "file1"
          streamReaderObject = new StreamReader("file1.txt");
          
          // Reads all characters from the current position to the end of the stream
          String contents = streamReaderObject.ReadToEnd();
          
          streamReaderObject.Close();

          Console.WriteLine("The file has {0} text elements.", new StringInfo(contents).LengthInTextElements);
      }
      catch (FileNotFoundException)
      {
          Console.WriteLine("The file cannot be found.");
      }
    }
  } // class GarbageCollector
}