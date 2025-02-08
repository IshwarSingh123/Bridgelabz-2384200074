//using System;

//class Course
//{
//    public string CourseName { get; set; }
//    public int Duration { get; set; } // Duration in weeks

//    public Course(string courseName, int duration)
//    {
//        CourseName = courseName;
//        Duration = duration;
//    }

//    public virtual void DisplayCourseInfo()
//    {
//        Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks");
//    }
//}

//class OnlineCourse : Course
//{
//    public string Platform { get; set; }
//    public bool IsRecorded { get; set; }

//    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
//        : base(courseName, duration)
//    {
//        Platform = platform;
//        IsRecorded = isRecorded;
//    }

//    public override void DisplayCourseInfo()
//    {
//        base.DisplayCourseInfo();
//        Console.WriteLine($"Platform: {Platform}, Recorded: {(IsRecorded ? "Yes" : "No")}");
//    }
//}

//class PaidOnlineCourse : OnlineCourse
//{
//    public double Fee { get; set; }
//    public double Discount { get; set; }

//    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
//        : base(courseName, duration, platform, isRecorded)
//    {
//        Fee = fee;
//        Discount = discount;
//    }

//    public override void DisplayCourseInfo()
//    {
//        base.DisplayCourseInfo();
//        Console.WriteLine($"Fee: ${Fee}, Discount: {Discount}%");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Course basicCourse = new Course("Mathematics", 12);
//        basicCourse.DisplayCourseInfo();

//        OnlineCourse onlineCourse = new OnlineCourse("Python Programming", 8, "Udemy", true);
//        onlineCourse.DisplayCourseInfo();

//        PaidOnlineCourse paidCourse = new PaidOnlineCourse("Advanced AI", 10, "Coursera", false, 299.99, 20);
//        paidCourse.DisplayCourseInfo();
//    }
//}
