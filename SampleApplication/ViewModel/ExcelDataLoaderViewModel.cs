using System;
using System.Collections.Generic;
using System.Windows.Input;
using Prism.Commands;
using System.Windows.Forms;
using SampleApplication.Model;
using Microsoft.Office.Interop.Excel;
using System.Collections.ObjectModel;
using SampleApplication.Services;

namespace SampleApplication.ViewModel
{
    public class ExcelDataLoaderViewModel
    {
        public ICommand BrowseCommand { get; set; }
        ObservableCollection<ExcelLoaderClientModel> ExcelData;
        ExcelLoaderModuleController controller;

        IExcelLoaderApplicationService _excelLoaderApplicationService;

        public ExcelDataLoaderViewModel()
        {
            controller = new ExcelLoaderModuleController();
            _excelLoaderApplicationService = controller.Resolve<ExcelLoaderApplicationService>("ExcelLoaderApplicationService");

            BrowseCommand = new DelegateCommand<object>(LoadExcelData);
            ExcelData = new ObservableCollection<ExcelLoaderClientModel>();
        }

        public void LoadExcelData(object arg)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "(*.xlsx)|*.xlsx";
            var browseFile = fileDialog.ShowDialog();

            if(!string.IsNullOrWhiteSpace(fileDialog.FileName))
            {
                _excelLoaderApplicationService.SaveExcelToSQL(fileDialog.FileName);
            }
            
            //ExcelData = (ObservableCollection<ExcelModel>) excelData;
            var result = MessageBox.Show(fileDialog.FileName, "Alert", MessageBoxButtons.OKCancel);
        }

    }
}
