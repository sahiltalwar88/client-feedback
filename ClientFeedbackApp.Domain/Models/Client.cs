﻿using System;

namespace ClientFeedbackApp.DataLayer.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PocName { get; set; }
        public string ProjectName { get; set; }
        public string Quarter { get; set; }
        public DateTime Date { get; set; }
        public string Grade { get; set; }
        public string Feedback { get; set; }
        public bool IsInEditMode { get; set; }
    }
}
