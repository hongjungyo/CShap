using System.Collections.Generic;
using UnityEngine;
namespace GenericClass
{
    public class GenericCollection : MonoBehaviour
    {   
        //제네릭 클래스 (List<t>)
        //:형식 매개변수 T에 지정한 형식으로 클래스와 멤버의 성질이 결정되는 클래스
        //List<T> => int, float, string, 클래스
        public class Student
        {
            public string Name { get; set; }
            public int number { get; set; }

        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //학생 전용 리스트
            List<Student> students = new List<Student>
            {
                new Student {Name = "감자소년", number = 1 },
                new Student {Name = "고구마소년", number = 2 },
                new Student {Name = "옥수수소년", number = 3 },
            };

            Student student = new Student() { Name = "계란 소녀", number = 4 };
            students.Add(student);

            foreach(var s in students)
            {
                Debug.Log($"이름:{s.Name}, 번호:{s.number}");
            }
        }
    }
}