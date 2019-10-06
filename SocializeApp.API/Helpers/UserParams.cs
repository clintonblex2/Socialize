namespace DatingApp.API.Helpers
{
    public class UserParams
    {
        // properties for pagination
        public const int MAX_PAGE_SIZE = 20;
        public int PageNumber { get; set; } = 1; // default value of 1. Always show the first page
        
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MAX_PAGE_SIZE) ? MAX_PAGE_SIZE : value; }
        }

        // properties for filteration
        public int UserId { get; set; }
        public string Gender { get; set; }
        public int MinAge { get; set; } = 18;
        public int MaxAge { get; set; } = 99;
    }
}