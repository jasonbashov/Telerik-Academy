﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {
        
        public string Lab { get; set; }

        public LocalCourse(string courseName)
            : this(courseName, null)
        {
        }

        public LocalCourse(string courseName, string teacherName)
            : this(courseName, teacherName, new List<string>())
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab = null)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { Name = ");

            result.Append(base.ToString());

            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
