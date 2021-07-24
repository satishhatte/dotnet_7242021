using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
             var versions = new string[4]{"-v","--v","/v","--version"};
             var sizes = new string[4]{"-s","--s","/s","--size"};
             FileDetails _fileDetails = new FileDetails();

            // Task 1- check if specified version attribute is -v then pass second arg to get filedetails.version
            if (args[0].Equals("-v"))
            {                
                Console.WriteLine( _fileDetails.Version(args[1]));               
                
            }

            // Task 2- call FileDetails.Version if the first argument is either of -v, --v, /v, --version
            if (!string.IsNullOrEmpty(args[0]))
            {
                if(versions.Contains(args[0]))
                    Console.WriteLine(_fileDetails.Version(args[1]));
                 if(sizes.Contains(args[0]))
                    Console.WriteLine(_fileDetails.size(args[1]));
            }
            Console.ReadLine();
        }
    }
}
