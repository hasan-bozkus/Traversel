using ClosedXML.Excel;
using DataAccessLayer.Concrete;
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
			ExcelPackage excel = new ExcelPackage();
			var workSheet = excel.Workbook.Worksheets.Add("Sayfa1");
			workSheet.Cells[1, 1].Value = "Rota";
			workSheet.Cells[1, 2].Value = "Rehber";
			workSheet.Cells[1, 3].Value = "Kontenjan";

			workSheet.Cells[2, 1].Value = "Gürcistan Batum Turu";
			workSheet.Cells[2, 2].Value = "Kadır Yıldız";
			workSheet.Cells[2, 3].Value = "50";

			workSheet.Cells[3, 1].Value = "Sırbistan - Makedonya Turu";
			workSheet.Cells[3, 2].Value = "Zeynep Öztürk";
			workSheet.Cells[3, 3].Value = "30";

			var bytes = excel.GetAsByteArray();
			return File(bytes, "application/vnd.openxmlformats-officedocument-spreadsheetml.sheet", "dosya2.xlsx");
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
