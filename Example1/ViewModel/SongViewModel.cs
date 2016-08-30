using MicroMvvm;
using MVVMSandbox.Model;
using System.Windows.Input;

namespace MVVMSandbox.ViewModel
{
    public class SongViewModel : ObservableObject
    {
        #region Fields

        private Song _song;

        #endregion

        #region Constructors

        public SongViewModel()
        {
            // Generate local data (should be replaced by a database)
            _song = new Song
            {
                Name = "Amanda",
                Time = 4.27f,
                Album = new Album { Name = "Greatest Hits", Year = 1997, Genre = "Rock" },
                Artist = new Artist { Name = "Boston" }
            };
        }

        #endregion

        #region Properties

        public Song Song
        {
            get { return _song; }
            set { _song = value; RaisePropertyChanged(nameof(Song)); }
        }

        #endregion

        #region Commands

        private void SaveSongExecute()
        {
            // Write to debug console (should persist on database)
            System.Diagnostics.Debug.Print(string.Format("Name: {0}", Song.Name));
            System.Diagnostics.Debug.Print(string.Format("Time: {0}", Song.Time));
            System.Diagnostics.Debug.Print(string.Format("Artist: {0}", Song.Artist.Name));
            System.Diagnostics.Debug.Print(string.Format("Album: {0}", Song.Album.Name));
            System.Diagnostics.Debug.Print(string.Format("Year: {0}", Song.Album.Year));
        }

        private bool CanSaveSongExecute()
        {
            return true;
        }

        public ICommand SaveSong
        {
            get { return new RelayCommand(SaveSongExecute, CanSaveSongExecute); }
        }

        private void CancelExecute()
        {
            // Exit the Application
            System.Windows.Application.Current.Shutdown();
        }

        private bool CanCancelExecute()
        {
            return true;
        }

        public ICommand Cancel
        {
            get { return new RelayCommand(CancelExecute, CanCancelExecute); }
        }

        #endregion
    }
}
