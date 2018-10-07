using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Forms;
using System.IO;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace Exam_mediaplayer
{
    class ViewModel : ViewModelBase
    {
        List<string> filter = new List<string>() { @"mp3", @"avi"};
        private MediaPlayer _mpBgr;
        int _get_selected;
        string _playing_track;
        double _vol;
        public double Vol
        {
            get
            {
                return _vol;
            }
            set
            {
                _vol = value;
                RaisePropertyChanged(() => Vol);
            }
        }
        public string Playing_track
        {
            get
            {
                return _playing_track;
            }
            set
            {
                _playing_track = value;
                RaisePropertyChanged(() => Playing_track);
            }
        }




        public ViewModel()
        {
            Tracks = new ObservableCollection<Track>();
            _mpBgr = new MediaPlayer();
        }
    

        public int Get_selected
        {
            get
            {
                return _get_selected;
            }
            set
            {
                _get_selected = value;
                RaisePropertyChanged(() => Get_selected);
            }
        }
        public ObservableCollection<Track> Tracks
        {
            get;
            private set;
        }

        #region Commands
        ICommand _get_tracks;
        ICommand _play_track;
        ICommand _stop_track;
        ICommand _next;
        ICommand _prev;
        ICommand _pause_command;
        ICommand _change_volume_command;
        public ICommand Change_volume_command
        {
            get
            {
                return _change_volume_command ?? (_change_volume_command = new RelayCommand(() =>
                {
                    change_volume();
                }));
            }
        }
        public ICommand Pause_command
        {
            get
            {
                return _pause_command ?? (_pause_command = new RelayCommand(() =>
                {
                    Pause();
                }));
            }
        }
        public ICommand Next
        {
            get
            {
                return _next ?? (_next = new RelayCommand(() =>
                {
                    int temp = Tracks.Count - 1;
                    if (Get_selected < temp)
                    {
                        Get_selected += 1;
                        Playing_track = Tracks[Get_selected].Path_to_Track;
                    }
                    else
                    {
                        Get_selected = 0;
                        Playing_track = Tracks[Get_selected].Path_to_Track;
                    }
                    Play();
                }));
            }
        }
        public ICommand Prev
        {
            get
            {
                return _prev ?? (_prev = new RelayCommand(() =>
                {
                    int temp = Tracks.Count - 1;
                    if (Get_selected > 0)
                    {
                        Get_selected -= 1;
                        Playing_track = Tracks[Get_selected].Path_to_Track;
                    }
                    else
                    {
                        Get_selected = temp;
                        Playing_track = Tracks[Get_selected].Path_to_Track;
                    }
                    Play();
                }));
            }
        }


        public ICommand Stop_track
        {
            get
            {
                return _stop_track ?? (_stop_track = new RelayCommand(() =>
                {
                    Stop();
                }));
            }
        }

        public ICommand Play_track
        {
            get
            {
                return _play_track ?? (_play_track = new RelayCommand(() =>
                {
                    Playing_track = Tracks[Get_selected].Path_to_Track;
                    Play();
                }));
            }
        }

        public ICommand Get_tracks
        {
            get
            {
                return _get_tracks ?? (_get_tracks = new RelayCommand(Load_files));
            }
        }

        #endregion
        void Load_files()
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Tracks.Clear();
                foreach (string file in Directory.GetFiles(dialog.SelectedPath))
                {
                    if (filter.Exists(n => n == file.Split(new char[] { '.' }).Last().ToLower()))
                    {
                        try
                        {
                            var fileinfo = new FileInfo(file);
                            Tracks.Add(new Track { Name = fileinfo.Name, Path_to_Track = fileinfo.FullName, Size = fileinfo.Length / 1000 });
                        }
                        catch (Exception ex)
                        {
                            System.Windows.MessageBox.Show(ex.Message);
                        }
                    }
                }

            }
        }
        void Play()
        {
            _mpBgr.Open(new Uri(Playing_track));
            _mpBgr.Play();
        }
        void Stop()
        {
            _mpBgr.Stop();
        }
        void Pause()
        {
            _mpBgr.Pause();
        }
        void change_volume()
        {
            _mpBgr.Volume = Vol;
        }

    }
}
