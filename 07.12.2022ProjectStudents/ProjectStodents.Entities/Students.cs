using ProjectStudents.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStodents.Entities
{
    public class Students
    {
        public void AddNewStudent(int id, string name, int age,string address)
        {
            try
            {
                DAL.SqlQuery.RunNonQueryCommand($"Insert Into Students(id, name, age, address) Values({id},'{name}',{age},'{address}')");
            }
            catch (Exception ex)
            {
            }
        }
        public object BuildStudentList(SqlDataReader reader)
        {
            MainManager.Instance.ht.Clear();
            while (reader.Read())
            {
                ProjectStudents.Model.Student student = new ProjectStudents.Model.Student();
                student.Id = reader.GetInt32(reader.GetOrdinal("id"));
                student.Name = reader.GetString(reader.GetOrdinal("name"));
                student.Age = reader.GetInt32(reader.GetOrdinal("age"));
                student.Address = reader.GetString(reader.GetOrdinal("address"));
                MainManager.Instance.ht.Add(student.Id, student);
            }
            return MainManager.Instance.ht;
        }

        //------------------------------------------------------------------------------------------
        public void ResetHash()
        {
            try
            {
                DAL.SqlQuery.RunCommandResult("select * from Students", BuildStudentList);
            }
            catch (Exception ex)
            {
            }
        }
        public Student GetStudent(int id)
        {
            if (MainManager.Instance.ht[id] is Student)
            {
                return (Student)MainManager.Instance.ht[id];
            }
            else
            {
                return null;
            }
        }
    }
}
