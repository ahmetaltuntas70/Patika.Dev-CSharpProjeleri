using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingUygulamasi
{
    public class InMemory
    {
        List<User> _users;
        public InMemory()
        {
            _users = new List<User>
            {
                new User { ID = 1, UserName = "Fero", Password = "123" , FirstName = "Ahmet" , LastName = "Agaç" , CreateDate = new DateTime(1999, 10, 06) ,IsDelete = false},
                new User { ID = 1, UserName = "Ahmo", Password = "147" , FirstName = "Muslera" , LastName = "Saz" , CreateDate = new DateTime(1997, 11, 14) ,IsDelete = false},
                new User { ID = 1, UserName = "Ferhat", Password = "258" , FirstName = "Kazım" , LastName = "Cod" , CreateDate = new DateTime(2022, 08, 04) ,IsDelete = false}

            };

        }
        public void Add(User user)
        {
            _users.Add(user);
        }
        public List<User> GetUsers()
        {
            return _users;
        }
        public User GetByUser(string userName)
        {
            return _users.Find(x => x.UserName == userName);
        }

    }
}
