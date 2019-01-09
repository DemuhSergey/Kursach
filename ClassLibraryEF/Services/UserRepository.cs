using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Web;
using System.IO;

namespace ClassLibraryEF.Services
{
   public class UserRepository
   {
        emploeeEF db = new emploeeEF();

        public User Add(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user;
        }

        public User Find(string login, string password)
        {
            return db.Users.FirstOrDefault(u => ((u.Login == login) && (u.Pasword == password)));
        }
    }
}
