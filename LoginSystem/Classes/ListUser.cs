using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Classes
{
    internal class ListUser
    {
        List<User> users;

        public ListUser()
        {
            users = new List<User>();
        }

        public bool AddUser(User user)
        {
            for(int index = 0; index < GetQuantityUsers(); index++)
            {
                if (users.ElementAt(index).NameOrEmail.Equals(user.NameOrEmail))
                {
                    return false;
                }
            }

            users.Add(user);

            return true;
        }

        public User GetUser(int index)
        {
            return users.ElementAt(index);
        }

        public bool HasUser(User user)
        {
            for (int index = 0; index < GetQuantityUsers(); index++)
            {
                if(users.ElementAt(index).NameOrEmail.Equals(user.NameOrEmail) 
                   && users.ElementAt(index).Password.Equals(user.Password))
                {
                    return true;
                }
            }

            return false;
        }

        public int GetQuantityUsers()
        {
            return users.Count;
        }
    }
}
