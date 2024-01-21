using BirazdanKapinda.DataAccess.Data;
using BirazdanKapinda.DataAccess.Repository.IRepository;
using BirazdanKapinda.Models;
using BirazdanKapinda.Models.ViewModels;
using BirazdanKapinda.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BirazdanKapindaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CompanyController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Company> objCompanyList = _unitOfWork.Company.GetAll().ToList();

            return View(objCompanyList);
        }
        public IActionResult Upsert(int? id) //UpdateInsert = Upsert - BBeratgenc
        {

            if(id == null || id == 0)
            {
                return View(new Company());
            }
            else
            {
                Company companyObj = _unitOfWork.Company.Get(u => u.Id == id);
                return View(companyObj);
            }
            
        }
        //public IActionResult Create()
        //{
        //    // ViewBag.CategoryList = CategoryList; -- ViewBag ve ViewData olarak yapılabilir. - BBeratgenc
        //    // ViewData["CategoryList"] = CategoryList;
        //    CompanyVM CompanyVM = new()
        //    {
        //        CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
        //        {
        //            Text = u.Name,
        //            Value = u.Id.ToString()
        //        }),
        //        Company = new Company()
        //    };
        //    return View(CompanyVM);
        //}
        //[HttpPost]
        //public IActionResult Create(CompanyVM CompanyVM)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _unitOfWork.Company.Add(CompanyVM.Company);
        //        _unitOfWork.Save();
        //        TempData["success"] = "Kategori oluşturma başarılı";
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        CompanyVM.CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
        //        {
        //            Text = u.Name,
        //            Value = u.Id.ToString()
        //        });
        //        return View(CompanyVM);
        //    }
        //}

        [HttpPost]
        public IActionResult Upsert(Company CompanyObj)
        {
            if (ModelState.IsValid)
            {
                if (CompanyObj.Id == 0)
                {
                    _unitOfWork.Company.Add(CompanyObj);
                }
                else
                {
                    _unitOfWork.Company.Update(CompanyObj);
                }
                _unitOfWork.Save();
                TempData["success"] = "Kategori ekleme-güncelleme başarılı";
                return RedirectToAction("Index");
            }
            else
            {
                return View(CompanyObj);
            }
        }

        #region APICALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Company> objCompanyList = _unitOfWork.Company.GetAll().ToList();
            return Json(new { data = objCompanyList });
         }
        
        public IActionResult Delete(int? id)
        {
            var CompanyToBeDeleted = _unitOfWork.Company.Get(u=>u.Id == id);
            if (CompanyToBeDeleted == null)
            {
                return Json(new { success = false, message = "Silme işleminde hata oluştu." });
            }

            _unitOfWork.Company.Remove(CompanyToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Silme İşlemi Başarılı" });
        }
        #endregion
    }
}