using MusicApp.Functions;
using System.Security.Policy;

namespace MusicApplication
{
    public partial class fMain : Form
    {
        private List<List<string>> ListViewData = new List<List<string>>();
        private List<List<string>> ListLibrary = new List<List<string>>();

        private Mp3Player player = new Mp3Player();
        int currentVolume;
        bool isMute = false;

        public fMain()
        {
            InitializeComponent();

            listSong.View = View.Details;
            listSong.Columns.Add("Name", 700);
            listSong.Columns.Add("Path", listSong.Width / 2);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "mp3 files (*.mp3)|*.mp3";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in ofd.FileNames)
                {
                    string songName = Path.GetFileNameWithoutExtension(filename);
                    bool songExists = false;
                    foreach (List<string> songInfo in ListViewData)
                    {
                        if (songInfo[0] == songName)
                        {
                            MessageBox.Show("Song is already in the list");
                            songExists = true;
                            break;
                        }
                    }
                    if (!songExists)
                    {
                        ListViewItem item = new ListViewItem(songName);
                        item.SubItems.Add(filename);
                        listSong.Items.Add(item);

                        List<string> songInfo = new List<string>();
                        songInfo.Add(songName);
                        songInfo.Add(filename);
                        ListViewData.Add(songInfo);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listSong.SelectedItems.Count >= 1)
            {
                foreach (ListViewItem item in listSong.SelectedItems)
                {
                    string songName = item.SubItems[0].Text;
                    listSong.Items.Remove(item);
                    foreach (List<string> songInfo in ListViewData)
                    {
                        if (songInfo[0] == songName)
                        {
                            ListViewData.Remove(songInfo);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a song to remove.");
            }
        }

        private void btnAddLib_Click(object sender, EventArgs e)
        {
            if (listSong.SelectedItems.Count == 1)
            {
                foreach (ListViewItem selectedItem in listSong.SelectedItems)
                {
                    string songName = selectedItem.SubItems[0].Text;
                    string songPath = selectedItem.SubItems[1].Text;
                    bool songLibExists = false;
                    foreach (List<string> songLibInfo in ListLibrary)
                    {
                        if (songLibInfo[0] == songName)
                        {
                            MessageBox.Show("Song is already in the list");
                            songLibExists = true;
                            break;
                        }
                    }
                    if (!songLibExists)
                    {
                        ListViewItem item = new ListViewItem(songName);
                        item.SubItems.Add(songPath);
                        listLibrary.Items.Add(item);

                        List<string> songLibInfo = new List<string>();
                        songLibInfo.Add(songName);
                        songLibInfo.Add(songPath);
                        ListLibrary.Add(songLibInfo);
                    }

                }
            }
        }

        private void btnRemoveLib_Click(object sender, EventArgs e)
        {
            if (listLibrary.SelectedItems.Count >= 1)
            {
                foreach (ListViewItem item in listLibrary.SelectedItems)
                {
                    string songName = item.SubItems[0].Text;
                    listLibrary.Items.Remove(item);
                    foreach (List<string> songLibInfo in ListLibrary)
                    {
                        if (songLibInfo[0] == songName)
                        {
                            ListLibrary.Remove(songLibInfo);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a song to remove.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string textsearch = txtSearch.Text.ToLower();
            listSong.Items.Clear();
            if (textsearch != "")
            {
                foreach (List<string> searchName in ListViewData)
                {
                    if (searchName[0].ToLower().Contains(textsearch))
                    {
                        string songName = searchName[0];
                        string songPath = searchName[1];
                        ListViewItem item = new ListViewItem(songName);
                        listSong.Items.Add(item);
                        item.SubItems.Add(songPath);
                    }
                }
            }
            else
            {
                foreach (List<string> songInfo in ListViewData)
                {
                    ListViewItem item = new ListViewItem(songInfo[0]);
                    listSong.Items.Add(item);
                    item.SubItems.Add(songInfo[1]);
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (player.isPlaying())
            {
                songDuration.Text = player.getDurationString();
                songCurrentDuration.Text = player.currentPositionString();
                trackBarTime.Maximum = Convert.ToInt32(player.getDuration());
                trackBarTime.Value = Convert.ToInt32(player.currentPosition());
            }
        }

        private void checkPlay()
        {
            if (!player.isPlaying())
            {
                btnPlay.Image = Properties.Resources.pause;
                player.play();
            }
            else
            {
                btnPlay.Image = Properties.Resources.play;
                player.pause();
            }
        }

        private void trackBarTime_Scroll(object sender, EventArgs e)
        {
            player.setPosition(trackBarTime.Value);
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            player.setVolume(trackBarVolume.Value);
            if (player.getVolume() == 0)
            {
                picVolume.Image = Properties.Resources.mute;
            }
            else if (player.getVolume() < 30)
            {
                picVolume.Image = Properties.Resources.low_volume;
            }
            else if (player.getVolume() < 70)
            {
                picVolume.Image = Properties.Resources.medium_volume;
            }
            else
            {
                picVolume.Image = Properties.Resources.hight_volume;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!player.isPlaying())
            {
                btnPlay.Image = Properties.Resources.pause;
                player.play();
            }
            else
            {
                btnPlay.Image = Properties.Resources.play;
                player.pause();
            }
            player.setVolume(trackBarVolume.Value);
        }

        private void listSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listSong.SelectedItems.Count == 1)
            {
                string selectedSong = listSong.SelectedItems[0].SubItems[0].Text;
                string selectedPath = listSong.SelectedItems[0].SubItems[1].Text;
                lbName.Text = selectedSong;
                player.setUrl(selectedPath);
                player.play();
                checkPlay();
            }
        }

        private void listLibrary_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listLibrary.SelectedItems.Count == 1)
            {
                string selectedSong = listLibrary.SelectedItems[0].SubItems[0].Text;
                string selectedPath = listLibrary.SelectedItems[0].SubItems[1].Text;
                lbName.Text = selectedSong;
                player.setUrl(selectedPath);
                player.play();
                checkPlay();
            }
        }

        private void picVolume_Click(object sender, EventArgs e)
        {
            currentVolume = trackBarVolume.Value;
            if (!isMute)
            {
                player.mute(true);
                picVolume.Image = Properties.Resources.mute;
            }
            else
            {
                player.mute(false);
                picVolume.Image = Properties.Resources.medium_volume;
            }
            isMute = !isMute;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
