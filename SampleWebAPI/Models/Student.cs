using System;
using System.Collections.Generic;

namespace SampleWebAPI.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public string? Qualification { get; set; }

    public string? MobileNumber { get; set; }

    public string? Email { get; set; }
}
