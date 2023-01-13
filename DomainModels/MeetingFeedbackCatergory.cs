using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
    [Table("MEETING_FEEDBACK_CATEGORY")]
    public class MeetingFeedbackCatergory
	{
        [Key]
        [Column("f_category_id")]
        public string FCategoryId { get; set; }

        [Column("category_name")]
        public string CategoryName { get; set; }

        [Column("category_description")]
        public string CategoryDescription { get; set; }

        public MeetingFeedbackCatergory(string fCategoryId, string categoryName, string categoryDescription)
        {
            FCategoryId = fCategoryId;
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;
        }
    }
}

