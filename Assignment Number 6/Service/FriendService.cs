using Day9Prac.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Prac.Service
{
    internal class FriendService
    {
        List<Friend> objList= new List<Friend>();
        public int createFriends(Friend fr)
        {
            objList.Add(fr);
            return objList.Count();
        }

        public List<Friend> getFriends()
        {
            return objList;
        }
        public int DeleteFriends(int Id)
        {
            foreach(var obj in objList)
            {
                if (obj.FriendId == Id)
                {
                    objList.Remove(obj);
                    break;
                }
                
            }
            return objList.Count;
        }

        public int SearchFriend(string name)
        {
            foreach(var obj in objList)
            {
                if (obj.FriendName == name)
                {
                    return obj.FriendId;
                }
            }
            return -1;
        }
        public void updateFriends(string name,string updateName)
        {
            foreach(var obj in objList)
            {
                if (obj.FriendName == name)
                {
                    obj.FriendName = updateName;
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }
        }
        public void displayFriends()
        {
            foreach(var obj in objList)
            {
                Console.WriteLine(obj.FriendId+" "+obj.FriendName+" "+obj.FriendAge);  
            }
        }
    }
}
