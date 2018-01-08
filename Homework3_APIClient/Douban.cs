using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3_APIClient
{
    public partial class Douban : Form
    {
        public Douban()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            getInTheatersData();
        }

        private class Movie
        {
            public string Title { get; set; }
        }

        private async void getInTheatersData()
        {
            HttpClient client = new HttpClient();

            richTextBox.Text = "Loading...";

            var resp = await client.GetAsync(@"http://api.douban.com/v2/movie/in_theaters");

            var str = await resp.Content.ReadAsStringAsync();

            JObject jObject = JObject.Parse(str);
            List<Movie> movies = new List<Movie>();

            foreach (var subj in jObject["subjects"].Children().ToList())
            {
                movies.Add(subj.ToObject<Movie>());
            }

            listBoxMain.Items.Clear();

            foreach (var m in movies)
            {
                Console.WriteLine(m.Title);
                listBoxMain.Items.Add(m.Title);
            }

            richTextBox.Text = "Finish";
        }
    }
}
