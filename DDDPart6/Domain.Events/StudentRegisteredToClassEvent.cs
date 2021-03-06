﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infrastructure;

namespace Domain.Events
{
    [Serializable]
    public class StudentRegisteredToClassEvent : IEvent
    {
        public readonly Guid StudentId;
        public readonly int RegistrationId;
        public readonly Guid ClassId;
        public readonly int Credits;

        public StudentRegisteredToClassEvent(Guid studentId, Guid classId, int registrationId, int credits)
        {
            StudentId = studentId;
            ClassId = classId;
            Credits = credits;
            RegistrationId = registrationId;
        }
    }
}
