﻿namespace Reservation_System.Domain
{
    public class Candidate
    {
        public int IdCandidate { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Email { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public virtual List<CandidateExperience>? Experience { get; set; }
    }
}
