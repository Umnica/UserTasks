using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserTasks.Web.Controllers
{
    public class ExamleController : Controller
    {

        private readonly ILogger<ExamleController> _logger;


        public ExamleController(ILogger<ExamleController> logger)
        {
            _logger = logger;
        }

        // GET: /Examle
        public ActionResult Index()
        {
            _logger.LogDebug("public ActionResult Index()");
            return View(Index);
        }

        // GET: ExamleController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExamleController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExamleController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExamleController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExamleController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExamleController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExamleController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
