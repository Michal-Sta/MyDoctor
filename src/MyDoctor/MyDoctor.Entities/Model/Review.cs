﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyDoctor.Entities.Model.Enums;

namespace MyDoctor.Entities.Models
{
    public class Review : EntityBase
    {
        protected Review()
        {
        }

        public Review(string content, RatingType rating, User reviewer, User reviewedUser)
        {
            Content = content;
            Rating = rating;
            ReviewerId = reviewer.Id;
            ReviewdUserId = reviewedUser.Id;
            Reviewer = reviewer;
            ReviewedUser = reviewedUser;
        }

        [MaxLength(500)]
        public string Content { get; } = string.Empty;

        public RatingType Rating { get; } = RatingType.None;

        [Required]
        public int ReviewerId { get; }

        [Required]
        public int ReviewdUserId { get; }

        [ForeignKey(nameof(ReviewerId))]
        public virtual User Reviewer { get; }

        [ForeignKey(nameof(ReviewdUserId))]
        public virtual User ReviewedUser { get; }
    }
}