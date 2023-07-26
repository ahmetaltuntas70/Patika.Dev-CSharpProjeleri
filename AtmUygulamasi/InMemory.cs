using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmUygulamasi
{
    public class InMemory
    {
        List<User> _users;
        public InMemory()
        {
            _users = new List<User>
            {
                new User { ID = 1, CardNumber = "000", Password = "123" , FirstName = "Fero" , LastName = "Baba" , CreateDate = new DateTime(1999, 04, 10) ,IsDelete = false , Balance = 180},
                new User { ID = 1, CardNumber = "1111", Password = "345" , FirstName = "Ahmo" , LastName = "Fero" , CreateDate = new DateTime(1997, 10, 30) ,IsDelete = false , Balance = 75 },
                new User { ID = 1, CardNumber = "22222", Password = "567" , FirstName = "Ferhat" , LastName = "Code" , CreateDate = new DateTime(2014, 08, 08) ,IsDelete = false , Balance = 90 },
                new User { ID = 1, CardNumber = "333333", Password = "789" , FirstName = "Anna" , LastName = "Ahmo" , CreateDate = new DateTime(1994, 01, 08) ,IsDelete = false , Balance = 950 }

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
        public User GetByUser(string cardNumber)
        {
            return _users.Find(x => x.CardNumber == cardNumber);
        }
        public void UpdateBalance(string cardNumber, int balance)
        {
            User user = _users.Find(x => x.CardNumber == cardNumber);
            user.Balance = balance;

        }
    }
}
