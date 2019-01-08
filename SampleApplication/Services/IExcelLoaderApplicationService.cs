using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Services
{
    public interface IExcelLoaderApplicationService
    {
        void SaveExcelToSQL(string filePath);
    }
}
