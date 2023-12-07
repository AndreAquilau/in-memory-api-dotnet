using InMemoryAPIDonet.Entities;

namespace InMemoryAPIDonet.Database.Storage;

public static class UserData
{
    public static void DefaultData(ApplicationContextDb context)
    {
        List<User> users = new List<User>()
        {
            new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
            new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" },
            new User { Id = 3, Name = "Michael Johnson", Email = "michael.johnson@example.com" },
            new User { Id = 4, Name = "Emily Davis", Email = "emily.davis@example.com" },
            new User { Id = 5, Name = "Daniel Wilson", Email = "daniel.wilson@example.com" },
            new User { Id = 6, Name = "Olivia Taylor", Email = "olivia.taylor@example.com" },
            new User { Id = 7, Name = "Matthew Anderson", Email = "matthew.anderson@example.com" },
            new User { Id = 8, Name = "Sophia Thomas", Email = "sophia.thomas@example.com" },
            new User { Id = 9, Name = "Jacob Hernandez", Email = "jacob.hernandez@example.com" },
            new User { Id = 10, Name = "Isabella Clark", Email = "isabella.clark@example.com" },
            new User { Id = 11, Name = "Ethan Lee", Email = "ethan.lee@example.com" },
            new User { Id = 12, Name = "Mia Baker", Email = "mia.baker@example.com" },
            new User { Id = 13, Name = "William Martinez", Email = "william.martinez@example.com" },
            new User { Id = 14, Name = "Abigail Brown", Email = "abigail.brown@example.com" },
            new User { Id = 15, Name = "Benjamin Thompson", Email = "benjamin.thompson@example.com" },
            new User { Id = 16, Name = "Emily Harris", Email = "emily.harris@example.com" },
            new User { Id = 17, Name = "Christopher Young", Email = "christopher.young@example.com" },
            new User { Id = 18, Name = "Ava Anderson", Email = "ava.anderson@example.com" },
            new User { Id = 19, Name = "Samuel King", Email = "samuel.king@example.com" },
            new User { Id = 20, Name = "Natalie Wright", Email = "natalie.wright@example.com" }
        };
        
        context.users.AddRange(users);

        context.SaveChanges();
    }
}
