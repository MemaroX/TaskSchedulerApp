using TaskSchedulerApp.Models;
using System;

namespace TaskSchedulerApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Check if there are any prayers already in the database
            if (context.Prayers.Any())
            {
                return; // Database has been seeded
            }

            var prayers = new Prayer[]
            {
                new Prayer { PrayerName = "Fajr", Time = new TimeSpan(5, 0, 0) },
                new Prayer { PrayerName = "Dhuhr", Time = new TimeSpan(12, 0, 0) },
                new Prayer { PrayerName = "Asr", Time = new TimeSpan(15, 0, 0) },
                new Prayer { PrayerName = "Maghrib", Time = new TimeSpan(18, 0, 0) },
                new Prayer { PrayerName = "Isha", Time = new TimeSpan(20, 0, 0) }
            };

            foreach (var prayer in prayers)
            {
                context.Prayers.Add(prayer);
            }

            context.SaveChanges();
        }
    }
}
