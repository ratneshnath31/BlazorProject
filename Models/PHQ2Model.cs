
using System;
namespace BlazorMediLab.Models
{
    public class PHQ2Model
    {

        public int Id { get; set; }
        public int Question1 { get; set; }
        public int Question2 { get; set; }
        public int TotalScore { get; set; }
        public DateTime SubmittedAt { get; set; }
    }

}
