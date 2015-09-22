using System;
using System.Net;
using System.Web.Mvc;
using TAC.TesteAxado.Application.Interfaces;
using TAC.TesteAxado.Application.ViewModels;

namespace TAC.TesteAxado.Presentation.MVC.Controllers
{
    [Authorize]
    public class TransportadoraController : Controller
    {
        private readonly ITransportadoraAppService _transportadoraAppService;

        public TransportadoraController(ITransportadoraAppService transportadoraAppService)
        {
            _transportadoraAppService = transportadoraAppService;
        }

        public ActionResult Index()
        {
            return View(_transportadoraAppService.GetAll());
        }

        public ActionResult Details(Guid id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            TransportadoraViewModel transportadoraViewModel = _transportadoraAppService.GetById(id);

            if (transportadoraViewModel == null)
                return HttpNotFound();

            return View(transportadoraViewModel);
        }

        public ActionResult Create()
        {
            return View(new TransportadoraViewModel());
        }

        [HttpPost]
        public ActionResult Create(TransportadoraViewModel transportadora)
        {
            if (string.IsNullOrEmpty(transportadora.Nome))
                ModelState.AddModelError("", "Preencha o campo Nome");

            if (string.IsNullOrEmpty(transportadora.Email))
                ModelState.AddModelError("", "Preencha o campo Email");

            if (ModelState.IsValid)
            {
                _transportadoraAppService.Add(transportadora);

                return RedirectToAction("Index");
            }

            return View(transportadora);
        }

        // GET: Transportadora/Edit/5
        public ActionResult Edit(Guid id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            TransportadoraViewModel transportadoraViewModel = _transportadoraAppService.GetById(id);

            if (transportadoraViewModel == null)
                return HttpNotFound();

            return View(transportadoraViewModel);
        }

        // POST: Transportadora/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(TransportadoraViewModel transportadora)
        {
            if (string.IsNullOrEmpty(transportadora.Nome))
                ModelState.AddModelError("", "Preencha o campo Nome");

            if (string.IsNullOrEmpty(transportadora.Email))
                ModelState.AddModelError("", "Preencha o campo Email");

            if (ModelState.IsValid)
            {
                _transportadoraAppService.Update(transportadora);

                return RedirectToAction("Index");
            }

            return View(transportadora);
        }

        // GET: Transportadora/Delete/5
        public ActionResult Delete(Guid id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            TransportadoraViewModel transportadoraViewModel = _transportadoraAppService.GetById(id);
            if (transportadoraViewModel == null)
                return HttpNotFound();

            return View(transportadoraViewModel);
        }

        // POST: Transportadora/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _transportadoraAppService.Remove(_transportadoraAppService.GetById(id));
            return RedirectToAction("Index");
        }
    }
}