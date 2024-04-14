namespace Domain.Entities;

public class Person: BaseEntity
{
    public FullName FullName { get; private set; }
    public Gender Gender { get; private set; }
    public DateTimeOffset BirthDate { get; private set; }

    public int Age => (DateTimeOffset.UtcNow - BirthDate).Days / 365;
    
    public string PhoneNumber { get; private set; }
    
    public string TelegramId { get; private init; }

    public Person(
        FullName fullName,
        Gender gender,
        DateTimeOffset birth,
        string phoneNumber,
        string telegramId)
    {
        FullName = fullName;
        Gender = gender;
        BirthDate = birth;
        PhoneNumber = phoneNumber;
        TelegramId = telegramId;
    }
}