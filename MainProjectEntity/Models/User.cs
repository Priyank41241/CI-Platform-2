using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MainProjectEntity.Models
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            FavoriteMissions = new HashSet<FavoriteMission>();
            MissionApplications = new HashSet<MissionApplication>();
            MissionInviteFromUsers = new HashSet<MissionInvite>();
            MissionInviteToUsers = new HashSet<MissionInvite>();
            MissionRatings = new HashSet<MissionRating>();
            Stories = new HashSet<Story>();
            StoryInviteFromUsers = new HashSet<StoryInvite>();
            StoryInviteToUsers = new HashSet<StoryInvite>();
            Timesheets = new HashSet<Timesheet>();
            UserSkills = new HashSet<UserSkill>();
        }

        [Key]
        public long UserId { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        public int PhoneNumber { get; set; }
        public string? Avatar { get; set; }
        public string? WhyIVolunteer { get; set; }
        public string? EmployeeId { get; set; }
        public string? Department { get; set; }
        public long CityId { get; set; } = 1;
        public long CountryId { get; set; } = 1;
        public string? ProfileText { get; set; }
        public string? LinkedInUrl { get; set; }
        public string? Title { get; set; }
        public string Status { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual City City { get; set; } = null!;
        public virtual Country Country { get; set; } = null!;
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<FavoriteMission> FavoriteMissions { get; set; }
        public virtual ICollection<MissionApplication> MissionApplications { get; set; }
        public virtual ICollection<MissionInvite> MissionInviteFromUsers { get; set; }
        public virtual ICollection<MissionInvite> MissionInviteToUsers { get; set; }
        public virtual ICollection<MissionRating> MissionRatings { get; set; }
        public virtual ICollection<Story> Stories { get; set; }
        public virtual ICollection<StoryInvite> StoryInviteFromUsers { get; set; }
        public virtual ICollection<StoryInvite> StoryInviteToUsers { get; set; }
        public virtual ICollection<Timesheet> Timesheets { get; set; }
        public virtual ICollection<UserSkill> UserSkills { get; set; }
    }
}
