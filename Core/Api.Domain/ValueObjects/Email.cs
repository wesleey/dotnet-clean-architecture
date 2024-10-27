using System.Text.RegularExpressions;

namespace Api.Domain.ValueObjects;

public class Email
{
    public Email(string adderss)
    {
        if (string.IsNullOrEmpty(adderss))
            throw new ArgumentException("Email cannot be empty.");

        if (!Validate(adderss))
            throw new ArgumentException("Email is not valid");

        Address = adderss;
    }

    public string Address { get; set; }

    public static bool Validate(string email)
    {
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        Regex regex = new(pattern, RegexOptions.IgnoreCase);
        return regex.IsMatch(email);
    }
}
