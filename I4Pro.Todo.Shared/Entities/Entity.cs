using Flunt.Notifications;
using System;

namespace I4Pro.Todo.Shared
{
    public class Entity : Notifiable
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
