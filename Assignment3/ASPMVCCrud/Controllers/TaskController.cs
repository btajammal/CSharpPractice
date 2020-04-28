using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using ASPMVCCrud.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task = ASPMVCCrud.Models.Task;

namespace ASPMVCCrud.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        private readonly ITaskRepository taskRepository;
        public TaskController(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }
        public ViewResult Index()
        {
            var model = taskRepository.GetAllTask();
            return View(model);
        }

        // GET: Task/Details/5
        public ViewResult Details(int id)
        {
            Models.Task task = taskRepository.GetTask(id);
            return View(task);
        }

        // GET: Task/Create
        public ViewResult Create()
        {
            return View();
        }

        // POST: Task/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Task task)
        {
            if (ModelState.IsValid)
            {
                Task newTask = taskRepository.AddTask(task);
                return RedirectToAction("details", new { id = newTask.Id });
            }
            return View();
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            Models.Task task = taskRepository.GetTask(id);
            return View(task);
        }

        // POST: Task/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Task task)
        {
            if (ModelState.IsValid)
            {
                Task updatedTask = taskRepository.UpdateTask(task);
                return RedirectToAction("details", new { id = updatedTask.Id });
            }
            return View();
        }

        // GET: Task/Delete/5
        public ActionResult Delete(int id)
        {
            Models.Task task = taskRepository.GetTask(id);
            taskRepository.DeleteTask(task);
            return RedirectToAction("Index");
        }
        public ActionResult Search(String searchTitle)
        {
            Models.Task task = taskRepository.SearchTask(searchTitle);
            if(task is null)
            {
                TempData["ErrorMsg"]= "No Result Found";
                return RedirectToAction("Index");
            }
            else
            {
            return RedirectToAction("details", new { id = task.Id });
            }
        }
        public ViewResult ErrorPage(int? errorCode)
        {
            return View();
        }

    }
}