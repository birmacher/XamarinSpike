namespace XamarinSpike
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using FreshMvvm;
    using Models.UserDetails;
    using Models.UserList;
    using PropertyChanged;
    using Xamarin.Forms;

    [ ImplementPropertyChanged ]
    public class UserListPageModel: FreshBasePageModel
    {
        public override void Init( object initData )
        {
            base.Init( initData );

            Candidates = new ObservableCollection<UserListModel>( new List<UserListModel>
                                                                  {
                                                                      new UserListModel
                                                                      {
                                                                          Name = "Wibble"
                                                                      },
                                                                      new UserListModel
                                                                      {
                                                                          Name = "Bibble"
                                                                      },
                                                                      new UserListModel
                                                                      {
                                                                          Name = "Dibble"
                                                                      }
                                                                  } );
        }

        public Command<UserListModel> CandidateSelected
        {
            get
            {
                return new Command<UserListModel>( async ( candidate ) =>
                                                         {
                                                             var data = new UserDetailsModel
                                                                        {
                                                                            Name = candidate.Name,
                                                                            EmailAddress = $"{candidate.Name.ToLowerInvariant()}@test.com"
                                                                        };

                                                             await CoreMethods.PushPageModel<UserDetailsPageModel>( data );
                                                         } );
            }
        }

        public ObservableCollection<UserListModel> Candidates { get; set; }

        public UserListModel SelectedCandidate
        {
            get { return selectedCandidate; }
            set
            {
                selectedCandidate = value;

                if( value != null )
                {
                    CandidateSelected.Execute( value );
                }
            }
        }

        private UserListModel selectedCandidate;
    }
}
