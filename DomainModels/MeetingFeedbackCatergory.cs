using System;
using System.ComponentModel.DataAnnotations;

namespace Student_plus.DomainModels
{
	public class MeetingFeedbackCatergory
	{
        [Key]
        public string FCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public MeetingFeedbackCatergory(string fCategoryId, string categoryName, string categoryDescription)
        {
            FCategoryId = fCategoryId;
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;
        }
    }
}

