public class Member
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Birthplace { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }
    public bool IsGraduated { get; set; }
    public Member(string firstName, string lastName, string gender, string dateOfBirth, string birthplace, string phoneNumber, bool isGraduated)
    {
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        // xử lí ngày sinh dạng chuỗi dd/mm/yyyy
        string[] split = dateOfBirth.Split("/");
        DateOfBirth = new DateTime(Convert.ToInt32(split[2]), Convert.ToInt32(split[1]), Convert.ToInt32(split[0]));
        Birthplace = birthplace;
        // tính toán tuổi từ ngày sinh
        Age = DateTime.Now.Year - Convert.ToInt32(split[2]);
        PhoneNumber = phoneNumber;
        IsGraduated = isGraduated;
    }
    public override string ToString()
    {
        return "Name =  " + LastName + " " + FirstName + ", Gender = " + Gender + ", Date of Birth = " + DateOfBirth.ToString("dd/MM/yyyy") + ", Birth place = " + Birthplace + ", Age = " + Age + ", Phone number = " + PhoneNumber + ", Is graduated = " + IsGraduated;
    }
}
