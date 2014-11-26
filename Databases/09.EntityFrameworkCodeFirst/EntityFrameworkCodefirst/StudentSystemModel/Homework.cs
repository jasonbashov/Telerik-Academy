namespace StudentSystemModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    public class Homework
    {
        public Homework()
        {
        }

        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        [ForeignKey]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        [ForeignKey]
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public int TimeSpent { get; set; }
    }
}
