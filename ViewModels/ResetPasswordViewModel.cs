using System;
using System.ComponentModel.DataAnnotations;

namespace newNest.ViewModels;

public class ResetPasswordViewModel
{
    public string Email { get; set; }
    public string Token { get; set; }
}