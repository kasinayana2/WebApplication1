using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : ApiController
    {
        List<User> userList = new List<User>();
        public UserController()
        {
            userList.Add(new User { Id = 1, Name = "kasi", Address = "plvd" });
            userList.Add(new User { Id = 2, Name = "Nagen", Address = "pdtr" });
            userList.Add(new User { Id = 3, Name = "siva", Address = "CN" });
            userList.Add(new User { Id = 4, Name = "Charan", Address = "Kdp" });

        }

        // api/user
       
        public IHttpActionResult GetUsers()
        {
            return Ok(userList);
        }

        // api/user/1         

        public IHttpActionResult Getuser(int id)
        {
            User user = userList.Find(u => u.Id == id);
            return Ok(user);
        }
    }
}
