using System;
namespace Student_plus.DomainModels
{
	public class MeetingFeedbackCatergory
	{
        public string FCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public MeetingFeedbackCategory(string fCategoryId, string categoryName, string categoryDescription)
        {
            FCategoryId = fCategoryId;
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;
        }
    }
}

