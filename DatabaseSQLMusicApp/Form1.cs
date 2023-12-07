namespace DatabaseSQLMusicApp
{
    public partial class Form1 : Form
    {
        BindingSource albumbBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDOA albumsDOA = new AlbumsDOA();
            
            Album a1 = new Album
            {
                ID = 1,
                AlbumName = "my first album",
                ArtistName = "Noah Eliasson",
                Year = 2023,
                ImageURL = "nothing",
                Description = "nothing special"
            };
            Album a2 = new Album
            {
                ID = 1,
                AlbumName = "my second album",
                ArtistName = "Noah Eliasson",
                Year = 2023,
                ImageURL = "nothing",
                Description = "nothing special"
            };

            albumsDOA.albums.Add(a1);
            albumsDOA.albums.Add(a2);

            //koppla list och grid view controll
            albumbBindingSource.DataSource = albumsDOA.albums;

            dataGridView1.DataSource = albumbBindingSource;
        }
    }
}