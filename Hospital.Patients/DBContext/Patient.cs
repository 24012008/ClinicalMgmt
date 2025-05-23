﻿using System;
using System.Collections.Generic;

namespace Hospital.Patients.DBContext;

public partial class Patient
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }
}
