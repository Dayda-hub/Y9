using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBL.Model
{
    public class User
    {
        public string Name { get; }
        public Gender Gender { get; }
        public double Weight { get; set; }
        public double Height { get; set; }         
        public DateTime BirthDate { get; }
        
        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="name"> Имя. </param>
        /// <param name="gender"> Гендер. </param>
        /// <param name="weight"> Вес. </param>
        /// <param name="height"> Рост. </param>
        /// <param name="birthdate"> Дата рождения. </param>
       
        public User(string name, Gender gender, double weight, double height, DateTime birthdate)  
        {
            #region Проверка условий
            if (name == null) { throw new ArgumentNullException(); }
            if (weight <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (birthdate < DateTime.Parse("01.01.1900"))
            {

            }
            #endregion

            Name = name;    
            Gender = gender;    
            Weight = weight;        
            Height = height;    
            BirthDate = birthdate;
            BinaryFormatter formatter = new BinaryFormatter();  
                   
        }       
    }
}
