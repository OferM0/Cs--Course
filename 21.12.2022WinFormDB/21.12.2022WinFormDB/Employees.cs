using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._12._2022WinFormDB
{
    public class Employees
    {
        public Employees(int code, int id, string firstName, string lastName, DateTime birthDate, string status, string gender, string city, int number, string street, int homeNumber, int phoneNumber)
        {
            Code = code;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Status = status;
            Gender = gender;
            City = city;
            Number = number;
            Street = street;
            HomeNumber = homeNumber;
            PhoneNumber = phoneNumber;
        }
        [Key]
        public int Code { get; set; }
        [Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Status { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
        public int HomeNumber { get; set; }
        public int PhoneNumber { get; set; }
    }
}
