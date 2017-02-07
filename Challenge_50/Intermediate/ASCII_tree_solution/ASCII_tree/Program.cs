using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


/*  Given an absolute path, write a program that outputs an ASCII tree of that directory.
 *  Note: 'tree' utility is not allowed.
 *  Link to the challenge : https://www.reddit.com/r/dailyprogrammer/comments/teu9p/592012_challenge_50_intermediate/
 */
namespace ASCII_tree
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.SetBufferSize(Console.BufferWidth + 100, Console.BufferHeight + 100);
            string dirPath = "C:\\Users\\Stanislav\\Google Drive\\EDB4";
            listDir(dirPath, 0);
            Console.ReadLine();

        }
        static void listDir(string path,int pass)
        {
            FileAttributes attr = new FileAttributes();
            attr = File.GetAttributes(path);

            // Its a directory 
            if(attr.HasFlag( FileAttributes.Directory))
            {
                
                for(int i = 0 ; i <pass; i++ )
                    Console.Write(" │ ");

                //Get only the name of the directory ( not the full path)
                string DirectoryName =  new DirectoryInfo(path).Name;
                Console.WriteLine(" ├─+" + DirectoryName);
                
                //Print all files in the current directory
                foreach (var f in Directory.GetFiles(path))
                {
                    for (int i = 0; i < pass; i++)
                        Console.Write(" │ ");
                    var file = new FileInfo(f);
                    var fileName = file.Name;
                    Console.WriteLine(" │  ├─" + fileName);
                }

                
                // Execute the function for each directory
                foreach (var d in Directory.GetDirectories(path))
                {
                    
                    var dir = new DirectoryInfo(d);
                    var dirName = dir.Name;
                    listDir(path + "\\" + dirName, pass +1);
                }         
            }
        }
    }

}
