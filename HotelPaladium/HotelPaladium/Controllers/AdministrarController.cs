using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelPaladium.Models;
namespace MvcApplication1.Controllers
{
    public class AdministrarController : Controller
    {
        //
        // GET: /Administrar/

        public ActionResult Index()
        {
            return View();
        }
        /*
        public JsonResult AddRol(string idUs2, string idRol) {
            Guid _idUs = new Guid(idUs2);
            Guid _idRol = new Guid(idRol);
            ConectorDataContext db = new ConectorDataContext();
            UsersInRole rol = new UsersInRole()
            {
                RoleId = _idRol,
                UserId = _idUs
            };
            db.UsersInRoles.InsertOnSubmit(rol);
            db.SubmitChanges();
            //string data = idUs2 + idRol;
            return Json(new { success = "Rol Agregado" });
        }
        public JsonResult DeleteRol(string idRol)
        {
            Guid _idRol = new Guid(idRol);
            ConectorDataContext db = new ConectorDataContext();
            UsersInRole rol = db.UsersInRoles.Where(a => a.RoleId == _idRol).First();
            db.UsersInRoles.DeleteOnSubmit(rol);
            db.SubmitChanges();
            return Json(new { success = true });
        }
        
        public ActionResult getUserRoles() 
        {
            ConectorDataContext db = new ConectorDataContext();
            List<UserListRol> Lista = db.Users.
                Select(a => new UserListRol()
                {
                    id = a.UserId,
                    nombre = a.UserName,
                    ListaRoles = db.UsersInRoles.Where(b=>b.UserId==a.UserId).
                    Select(b => new RolView() 
                    {
                        id=b.Role.RoleId,
                        nombre = b.Role.RoleName
                    }).ToList()
                }).ToList();
            ViewBag.lista = Lista;
            //Consultar la tabla roles de la base de datos
            List<Role> listaRoles = db.Roles.ToList();
            ViewBag.listRol = listaRoles;
            return View();
        }
        */
    }
}
