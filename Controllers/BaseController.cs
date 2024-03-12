using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmorcilloCrudApp.Repository;

namespace AmorcilloCrudApp.Controllers
{
    public class BaseController : Controller
    {
        public CRUDPracticeEntities _db;
        public BaseRepository<user> _userRepo;
        public BaseController()
        {
            _db = new CRUDPracticeEntities();
            _userRepo = new BaseRepository<user>();
        }

    }
}