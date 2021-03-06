﻿using DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Model
{
    public class EventModel
    {
        public Event Event { get; set; }
        [Required]
        [EnumDataType(typeof(Event.CATEGORIES))]
        public String Category { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Name is too long.")]
        public string EventName { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        public int NumberOfSeats { get; set; }
        [DefaultValue(0)]
        public int RegisteredUsers { get; set; }
        public Event.EventHost Host { get; set; }
        public Room Room { get; set; }
        public Campus Campus { get; set; }

        public Event GetEvent()
        {
            return new Event(-1, EventName, Category, StartTime, EndTime, Host, Room, Campus);
        }
        public void SetEvent(Event e)
        {
            Event = e;
            Category = e.Category;
            EventName = e.EventName;
            StartTime = e.StartTime;
            EndTime = e.EndTime;
            NumberOfSeats = e.NumberOfSeats;
            RegisteredUsers = e.RegisteredUsers;
            Host = e.Host;
            Room = e.Room;
            Campus = e.Campus;
        }
    }
}
