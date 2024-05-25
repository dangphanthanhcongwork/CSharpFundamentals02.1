using System;

public enum Gender
{
    Male,
    Female,
    Other
}

public class Member
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get { return LastName + " " + FirstName; } }
    public Gender Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }
    public string Birthplace { get; set; }
    public string PhoneNumber { get; set; }
    public bool IsGraduated { get; set; }
    public override string ToString()
    {
        return $"Name: {FullName}, Gender: {Gender}, Date of Birth: {DateOfBirth}, Birthplace: {Birthplace}, Phone number: {PhoneNumber}, Graduated: {IsGraduated}";
    }
}
