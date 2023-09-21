using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPool.Utils;
internal class ConvertUtils
{
    public static string AutoConvertBytes(decimal bytes, int decimalPlaces = 2)
    {
        string[] sizes = { "B", "KB", "MB", "GB", "TB" };
        int order = 0;
        while (bytes >= 1024 && order < sizes.Length - 1)
        {
            order++;
            bytes = bytes / 1024;
        }

        return $"{bytes:0.##} {sizes[order]}";

    }

    //public static string ConvertBytesToMegabytes(long bytes)
    //{
    //    return ((bytes / 1024f) / 1024f).ToString("0.00");
    //}
}
