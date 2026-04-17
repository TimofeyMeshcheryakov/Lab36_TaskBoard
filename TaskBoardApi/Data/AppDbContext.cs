using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using TaskBoardApi.Models;

namespace TaskBoardApi.Data;

public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) :
    base(options) { }
    public DbSet<TaskItem> Tasks { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<TaskItem>().HasData(
            new TaskItem {
                Id = 1,
                Title = "Изучить ASP.NET Core",
                Description = "Контроллеры, маршруты, middleware",
                IsComplered = true,
                CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new TaskItem {
                Id = 2,
                Title = "Подключить SQLite",
                Description = "EF Core, миграции, DbContext",
                IsComplered = true,
                CreatedAt = new DateTime(2026, 1, 2, 0, 0, 0, DateTimeKind.Utc)
            },

            new TaskItem {
                Id = 3,
                Title = "Написать фронтенд",
                Description = "HTML, CSS, JavaScript, fecth",
                IsComplered = false,
                CreatedAt = new DateTime(2026, 1, 3, 0, 0, 0, DateTimeKind.Utc)
            },
            new TaskItem {
                Id = 4,
                Title = "Сдать итоговый проект",
                Description = "Показать преподавателю работающее приложение",
                IsComplered = false,
                CreatedAt = new DateTime(2026, 1, 4, 0, 0, 0, DateTimeKind.Utc)
            }
        );
    }
}

