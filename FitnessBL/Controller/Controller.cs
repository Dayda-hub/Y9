using FitnessBL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBL
{
    class Program
    {

        static void Main(string[] args)
        {
       
        }
    }
    public class Controller
    {
        public List<User>User { get; }

        public Controller(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("поле User не может быть пустым");
            }

            User = new  List<User>();   
        }
        public void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();      
            using(var fs = new FileStream("users.dat",FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);      
            }
           
        }
        /// <summary>
        /// /
        /// </summary>
        /// <returns>Пользователь приложения</returns>
        /// <exception cref="FileLoadException"></exception>
        public List<User> GetUserData() 
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.bin", FileMode.OpenOrCreate))
            {
                if(formatter.Deserialize(fs) is User User) 
                {
                    return User;
                }
                else
                {
                    return new List<User>();
                }
              
            }
        }  
    }
}
