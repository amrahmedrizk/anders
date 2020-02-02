using anders.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace anders.Controllers
{
    public class playersController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: players/Create
        public ActionResult Create()
        {
            
            if (Session["uu"] != null)
            {
               var p = (List<players>)Session["uu"];
                return View("Create", p);

            }
            else
            {
                List<players> p = new List<players>();

                p = db.players.ToList();

                p.Sort();
                return View("Create", p);

            }

        }

        // POST: players/Create
        [HttpPost]
        public ActionResult Create(players player)
        {
            if (player.name != null && player.score != 0)
            {
                //var fg = db.players.ToList();
                //db.players.RemoveRange(fg);
                //db.SaveChanges();
                string n = player.name;
                int ss = player.score;
                players oo = new players { name = n, score = ss };
                db.players.Add(oo);
                db.SaveChanges();
            }
           

          var p = db.players.ToList();

            p.Sort();

            
            Session["uu"] = p;
           
            return View("Create", p);


        }




    }
}
