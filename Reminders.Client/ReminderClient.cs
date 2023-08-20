using Reminders.Client.Models;
namespace Reminders.Client;

public static class ReminderClient
{
    private static readonly List<Reminder> reminders = new ()
    {
        new Reminder()
        {
            Number = 1,
            Name = "Example",
            Description = "Example",
            Time = 5.5M,
            DueDate = new DateTime(2023,8,7)
        }
    };

    public static Reminder[] GetReminders()
    {
        return reminders.ToArray();
    }

    public static void AddReminder(Reminder reminder)
    {
        reminder.Number = reminders.Max(reminder => reminder.Number) + 1;
        reminders.Add(reminder);
    }

    public static Reminder GetReminder(int id)
    {
        return reminders.Find(reminder => reminder.Number == id) ?? throw new Exception("Could not find reminder");
    }

    public static void UpdateReminder(Reminder reminder)
    {
        Reminder existingReminder = GetReminder(reminder.Number);
        existingReminder.Name = reminder.Name;
        existingReminder.Description = reminder.Description;
        existingReminder.Time = reminder.Time;
        existingReminder.DueDate = reminder.DueDate;
    }

    public static void DeleteReminder(int id)
    {
        Reminder reminder = GetReminder(id);
        reminders.Remove(reminder);
    }
}