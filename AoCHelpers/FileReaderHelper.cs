using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AoCHelpers
{
    public class FileReaderHelper
    {
        public static List<string> FileContents { get; set; }

        public FileReaderHelper(List<string> content)
        {
            FileContents = content;
        }

        public FileReaderHelper(string singleLine)
        {
            if (FileContents == null) FileContents = new List<string>();
            FileContents.Add(singleLine);
        }
        
        public static List<string> ReadFile(string fileName)
        {
            List<string> content = new List<string>();

            try
            {
                using (StreamReader stream = new StreamReader(fileName, Encoding.UTF8))
                {
                    while (!stream.EndOfStream)
                    {
                        content.Add(stream.ReadLine());
                    }

                    FileContents = content;
                }
            }
            catch (FileNotFoundException)
            {
                FileContents = new List<string>
                {
                    {"File Not Found"}
                };
            }

            return FileContents;
        }
    }
}