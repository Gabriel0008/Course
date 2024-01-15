using System;

namespace Business.Models
{
    public abstract class Entity //Classe Base
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
