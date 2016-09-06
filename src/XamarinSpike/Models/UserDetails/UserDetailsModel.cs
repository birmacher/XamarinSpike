namespace XamarinSpike.Models.UserDetails
{
    using PropertyChanged;

    [ ImplementPropertyChanged ]
    public class UserDetailsModel
    {
        public string EmailAddress { get; set; }
        public string Name { get; set; }
    }
}
