using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPool.Utils;

public delegate void FileProgressDelegate(string currentUnits, string totalUnits,  int progress);
internal class FileUtils
{

    public static void Copy(string source, string destination, FileProgressDelegate? fileProgress = null)
    {
        using (FileStream sourceStream = new(source, FileMode.Open))
        using (FileStream destinationStream = new(destination, FileMode.Create))
        {
            decimal fileLength = sourceStream.Length;

            int bufferSize = 1024 * 1024;
            byte[] buffer = new byte[bufferSize];

            int bytesRead = 0;
            decimal totalBytesRead = 0;

            while ((bytesRead = sourceStream.Read(buffer, 0, bufferSize)) > 0)
            {
                destinationStream.Write(buffer, 0, bytesRead);
                totalBytesRead += bytesRead;

                Console.WriteLine("{0} bytes read", totalBytesRead);

                if (fileProgress != null)
                {
                    var currentUnits = ConvertUtils.AutoConvertBytes(totalBytesRead);
                    var totalUnits = ConvertUtils.AutoConvertBytes(fileLength);
                    var progress = (int)((totalBytesRead / fileLength) * 100);
                    fileProgress.Invoke(currentUnits, totalUnits, progress);
                }
            }
        }
    }
}
