namespace Glimpse.Agent.Web.Message
{
    public class UserIdentification
    {
        public UserIdentification(string userId, string username, string email, string image, bool isAnonymous)
        {
            UserId = userId;
            Username = username;
            Email = email;
            Image = image;
            IsAnonymous = isAnonymous;
        }

        [PromoteTo("request-userId")]
        public string UserId { get; }

        public string Username { get; }

        public string Email { get; }

        public string Image { get; }

        public bool IsAnonymous { get; }
    }
}