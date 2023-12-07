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
            
            

            //koppla list och grid view controll
            albumbBindingSource.DataSource = albumsDOA.getAllAlbums;

            dataGridView1.DataSource = albumbBindingSource;
        }
    }
}