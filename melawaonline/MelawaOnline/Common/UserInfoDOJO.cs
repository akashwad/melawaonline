using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class UserInfoDOJO
    {
        private string phoneNumber;
        private string firstName;
        private string fatherName;
        private string lastName;
        private string dateOfBirth;
        private string gender;
        private string uncleName;
        private string urgencyLevel;
        private string maritalStatus;
        private string feets;
        private string expectation;
        private string inches;

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string FatherName { get => fatherName; set => fatherName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string UncleName { get => uncleName; set => uncleName = value; }
        public string UrgencyLevel { get => urgencyLevel; set => urgencyLevel = value; }
        public string MaritalStatus { get => maritalStatus; set => maritalStatus = value; }
        public string Feets { get => feets; set => feets = value; }
        public string Expectation { get => expectation; set => expectation = value; }
        public string Inches { get => inches; set => inches = value; }
    }
}
