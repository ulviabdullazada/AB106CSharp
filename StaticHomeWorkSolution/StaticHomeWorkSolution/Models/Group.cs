using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticHomeWorkSolution.Models
{
    internal class Group
    {
        public static Group[] _groups=new Group[0];

        public static int GroupCount = 1;
        Student[] _students = new Student[0];
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public Student[] Students { get { return _students; } set { _students = value; } }



        public Group(string groupName)
        {
            GroupId = GroupCount;
            GroupCount++;
            GroupName = groupName;
        }


        public void GetGroupInfo()
        {
            Console.WriteLine($"{GroupId} {GroupName} Group Students:");
            ShowAllStudents();
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref _students,Students.Length+1);
            Students[Students.Length-1] = student;
                       
        }     
        public Student GetStudent(int id)
        {
            foreach (Student student in Students)
            {
                if (student.Id == id) return student;
            }
            return null;

        }
        public void Search(string search)
        {
            foreach (Student student in Students)
            {
                if (student.Name.ToLower().Contains(search.ToLower())|| student.Surname.ToLower().Contains(search.ToLower()))
                {
                    student.GetInfo();
                }
            }
        }
        public void ShowAllStudents()
        {
            foreach (Student student in Students)
            {
                student.GetInfo();
            }
        }
        public override string ToString()
        {
            return $"{GroupId} {GroupName} {Students.Length}";
        }


        public static void AddGroup(Group group)
        {
            Array.Resize(ref _groups, _groups.Length + 1);
            _groups[_groups.Length-1] = group;
        }
        public static Group GetGroup(int id)
        {
            foreach (Group group in _groups)
            {
                if (group.GroupId==id)
                {
                    return group;
                }
            }
            return null;
        }
        public static void RemoveGroup(int id)
        {
            Group[] newGroups= new Group[_groups.Length-1];
            int j = 0;
            for (int i=0; i<_groups.Length; i++)
            {
                if (_groups[i].GroupId!=id)
                {
                    newGroups[j] = _groups[i];
                    j++;
                }
            }   
            _groups = newGroups;
        }

    }
}
