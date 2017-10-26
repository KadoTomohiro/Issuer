﻿using System.ComponentModel.DataAnnotations;

namespace Issues.Db
{
    public class IssueSchema
    {
        [Key]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsOpen { get; set; }
    }
}