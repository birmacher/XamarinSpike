namespace XamarinSpike
{
    using FreshMvvm;
    using Models.UserDetails;
    using PropertyChanged;

    [ ImplementPropertyChanged ]
    public class UserDetailsPageModel: FreshBasePageModel
    {
        public override void Init( object initData )
        {
            base.Init( initData );

            Candidate = initData as UserDetailsModel;

            if( Candidate == null )
            {
                CoreMethods.PopToRoot( true );
            }
        }

        public UserDetailsModel Candidate { get; set; }
    }
}
