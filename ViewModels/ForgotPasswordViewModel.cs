using System;
using System.ComponentModel.DataAnnotations;

namespace newNest.ViewModels;

public class ForgotPasswordViewModel
{
    [Required, DataType(DataType.EmailAddress)]
    public string Email { get; set; }
}
