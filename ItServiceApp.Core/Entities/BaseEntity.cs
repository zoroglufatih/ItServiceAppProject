﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ItServiceApp.Core.Entities
{
    public abstract class BaseEntity
    {
        [Key] 
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        [StringLength(128)] 
        public string CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [StringLength(128)] 
        public string UpdatedUser { get; set; }
    }
}