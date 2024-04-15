namespace Domain.Entities;

public class Person: BaseEntity
{
    public Fullname Fullname { get; private set; }
    public Gender Gender { get; private set; }
    public DateTimeOffset BirthDate { get; private set; }

    public int Age => (DateTimeOffset.UtcNow - BirthDate).Days / 365;
    
    public string PhoneNumber { get; private set; }
    
    public string TelegramId { get; private init; }

    public Person(
        Fullname fullname,
        Gender gender,
        DateTimeOffset birth,
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