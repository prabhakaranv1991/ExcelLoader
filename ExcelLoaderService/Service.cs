using CommonModule.Domain.Entity;
using ExcelLoaderRepository;
using ExcelLoaderService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelLoaderService
{
    public class Service : IService
    {
        IExcelDataLoaderRepository _excelRepository;
        public Service(IExcelDataLoaderRepository excelRepository)
        {
            _excelRepository = excelRepository;
        }

        public void SaveExcelToSQL(IList<ExcelDataLoader> excelData)
        {
            _excelRepository.SaveExcelToSQL(excelData);
        }
    }
}
