using Business.Abstract;
using ClosedXML.Excel;
using Data.Concrete;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public List<DestinationModel> DestinationList() {
            var destinationlist = new List<DestinationModel>();
            using (var context = new Context())
            {
                destinationlist = context.Destinations.Select(x => new DestinationModel()
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Capasity = x.Capasity,
                    Price = x.Price
                }).ToList();
            }

            return destinationlist;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DestinationExcelReport()
        {
            using (var workbook=new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Tur Listesi");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Konaklama Süresi";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";


                var row = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(row, 1).Value = item.City;
                    workSheet.Cell(row,2).Value=item.DayNight;
                    workSheet.Cell(row,3).Value=item.Price;
                    workSheet.Cell(row,4).Value=item.Capasity;
                    row++;
                }
                using (var stream=new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content=stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "dosya1.xlsx");
                }


            }
         
        }
        public IActionResult StaticExcelReport()
        {
            //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            //ExcelPackage excel = new ExcelPackage();
            //var WorkSheet = excel.Workbook.Worksheets.Add("Sayfa1");
            //WorkSheet.Cells[1, 1].Value = "Rota";
            //WorkSheet.Cells[1, 2].Value = "Rehber";
            //WorkSheet.Cells[1, 3].Value = "Kontenjan";



            //WorkSheet.Cells[2, 1].Value = "Gürcistan-Batum";
            //WorkSheet.Cells[2, 2].Value = "Kadir Yıldız";
            //WorkSheet.Cells[2, 3].Value = "50";



            //WorkSheet.Cells[3, 1].Value = "Sırbistan";
            //WorkSheet.Cells[3, 2].Value = "Zeynep Öztürk";
            //WorkSheet.Cells[3, 3].Value = "35";



            return File(_excelService.ExcelList(DestinationList()),"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","yeniexcel.xlsx");
        }
    }
}
