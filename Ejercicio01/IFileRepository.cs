using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public interface IFileRepository
    {
        Task<string> ReadFileAsync(string filePath);
        Task WriteFileAsync (string filePath, string content);
        
    }
}
