namespace Domain.Entities;

public class Person: BaseEntity
{
    public Fullname Fullname { get; private set; }
    public Gender Gender { get; private set; }
    public DateTime BirthDate { get; private set; }


    public string PhoneNumber { get; private set; }
    public string TelegramId { get; private init; }
    public int Age {
        get
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;
            if (BirthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
    public Person(
        Fullname fullname,
        Gender gender,
        DateTime birth,
        string phoneNumber,
        string telegramId)
    {
        Fullname = fullname;
        Gender = gender;
        BirthDate = birth;
        PhoneNumber = phoneNumber;
        TelegramId = telegramId;
    }
}