using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStodents.Entities
{
    public class Books
    {
        private System.Collections.ArrayList BookList = new System.Collections.ArrayList();
        public void AddBook()
        {
            ProjectStudents.Model.Book book1 = new ProjectStudents.Model.Book() { Id = 12, Name = "Harry Poter" };
            ProjectStudents.Model.Book book2 = new ProjectStudents.Model.Book() { Id = 12, Name = "Harry Poter" };
            ProjectStudents.Model.Book book3 = new ProjectStudents.Model.Book() { Id = 12, Name = "Harry Poter" };

            BookList.Add(book1);
            BookList.Add(book2);
            BookList.Add(book3);
        }
    }
}
