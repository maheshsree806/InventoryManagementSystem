using InventoryManagementSystem.Domain;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Repository;
using System.Web.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class ProcessOrderController : Controller
    {

        // GET: ProcessOrder
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProcessOrder/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProcessOrder/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProcessOrder/Create
        [HttpPost]
        public ActionResult Create(ProcessOrderModel request)
        {
            try
            {
                IProcessOrderRepository processOrderRepository = new ProcessOrderRepo();
                var isOrderCreated = processOrderRepository.ProcessOrder(request.ProductId, request.Quantity);
                if (isOrderCreated)
                    return RedirectToAction("Index");
                else
                {
                    return View("Failure");
                }

            }
            catch
            {
                return View();
            }
        }


    }
}
