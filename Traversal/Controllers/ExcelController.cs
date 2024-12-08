using BusinnesLayer.Abtstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Office2010.Ink;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Traversal.Models;

namespace Traversal.Controllers
{
	[AllowAnonymous]
	public class ExcelController : Controller
	{
		private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
		{
			return View();
		}

		public List<DetinationModel> DestinationList()
		{
			List<DetinationModel> detinationModels = new List<DetinationModel>();
			using (var c = new Context())
			{
				detinationModels = c.Destinations.Select(x => new DetinationModel
				{
					City = x.City,
					DayNight = x.DayNight,
					Price = x.Price,
					Capaticty = x.Capacity
				}).ToList();
			}
			return detinationModels;
		}

		public IActionResult StaticExcelReport()
        {
			return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument-spreadsheetml.sheet", "YeniExcel.xlsx");
			//return File(bytes, "application/vnd.openxmlformats-officedocument-spreadsheetml.sheet", "dosya2.xlsx");
		}

		public IActionResult DestinationExcelReport()
		{
			using(var workBook = new XLWorkbook())
			{
				var workSheet = workBook.Worksheets.Add("Tur Listesi");
				workSheet.Cell(1, 1).Value = "Şehir";
				workSheet.Cell(1, 2).Value = "Konaklama Süresi";
				workSheet.Cell(1, 2).Value = "Fiyat";
				workSheet.Cell(1, 4).Value = "Kapasite";

				int rowCount = 2;
				foreach(var item in DestinationList())
				{
					workSheet.Cell(rowCount, 1).Value = item.City;
					workSheet.Cell(rowCount, 2).Value = item.DayNight;
					workSheet.Cell(rowCount, 3).Value = item.Price;
					workSheet.Cell(rowCount, 4).Value = item.Capaticty;
					rowCount++;
				}

				using(var stream = new MemoryStream())
				{
					workBook.SaveAs(stream);
					var content = stream.ToArray();
					return File(content, "application/vnd.openxmlformats-officedocument-spreadsheetml.sheet", "YeniListe.xlsx");
				}
			}
		}
	}
}
