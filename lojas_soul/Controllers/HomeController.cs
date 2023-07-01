using lojas_soul.Data;
using lojas_soul.Models;
using lojas_soul.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace lojas_soul.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly lojas_soulContext _context;

        public HomeController(ILogger<HomeController> logger, lojas_soulContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        //chama dashboardGraphs da view models  
        {
            var dashboardGraphs = new DashboardGraphsViewModel();

            dashboardGraphs.FornecedorChart = GetFornecedorChartData();
            return View(dashboardGraphs);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //cria um relatorio de produtos cadastrados por fornecedor
        public ChartModel GetFornecedorChartData()
        {
            var fornecedorData = _context.Fornecedor
                .Select(f => new
                {
                    Fornecedor = f.Nome,
                    Count = f.ProdutoList.Count
                })
                .OrderBy(f => f.Fornecedor)
                .ToList();

            var chartLabels = fornecedorData.Select(f => f.Fornecedor).ToList();
            var chartValues = fornecedorData.Select(f => f.Count).ToList();

            var chartModel = new ChartModel
            {
                Labels = chartLabels,
                Values = chartValues
            };

            return chartModel;
        }

    }
}