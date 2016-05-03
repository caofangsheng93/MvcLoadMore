using MVCLoadMore.DbContexts;
using MVCLoadMore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLoadMore.Controllers
{
    public class StudentController : Controller
    {
        StudentDbContext db = new StudentDbContext();
        public int pageSize = 2;
        // GET: Student
        public ActionResult Index(int page=1)
        {
          ViewBag.CurrentPage = page;
         
          List<Student> lstStudent=GetPagedList(page, pageSize, s => s.ID);
          return View(lstStudent);
        }

        public ActionResult _StudentDetails(int currentPage)
        {
            
            List<Student> lstStudent = GetPagedList(currentPage, pageSize, s => s.ID);
            return View(lstStudent);
        }


        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页容量</param>
        /// <param name="orderLambda">排序条件</param>
        /// <returns></returns>
        public List<Student> GetPagedList<TKey>(int pageIndex, int pageSize, Func<Student, TKey> orderLambda)
        { 

            var query = db.Students.OrderBy(orderLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsQueryable();
              return query .ToList();
        }
    }
}