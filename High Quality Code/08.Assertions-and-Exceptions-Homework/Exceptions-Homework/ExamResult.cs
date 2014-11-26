using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public int Grade
    {
        get
        {
            return this.grade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The grade can not be less than 0");
            }

            this.grade = value;
        }
    }
    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The min. grade can not be less than 0");
            }

            this.minGrade = value;
        }
    }
    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }
        private set
        {
            if (value <= this.MinGrade)
            {
                throw new ArgumentOutOfRangeException("The max grade can not be less than the min grade");
            }
            this.maxGrade = value;
        }
    }
    public string Comments
    {
        get
        {
            return this.comments;
        }
        private set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The comments can not be null or empty");
            }
            this.comments = value;
        }
    }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
