using CinemaTicket.Business.Abstract;
using CinemaTicket.Business.DependencyResolvers.Ninject;
using CinemaTicket.Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicket.UI
{
    public partial class FilmForm : Form
    {

        static readonly HttpClient client = new HttpClient();
        private Form activeForm;
        private ISessionService _sessionService;

        public FilmForm()
        {
            InitializeComponent();
            _sessionService = InstanceFactory.GetInstance<ISessionService>();
        }

        private async void FilmForm_LoadAsync(object sender, EventArgs e)
        {

            List<Result> results = await GetFilms();
            List<Session> sessions = _sessionService.GetAll();
            int i = 1;

            foreach (var film in results)
            {

                CustomPictureBox pan = new CustomPictureBox(film.poster_path, film.title, film);

                if (results.IndexOf(film) == 0)
                {
                    pan.Location = new Point(i, 100);
                }
                else
                {
                    pan.Location = new Point(i * 160, 100);
                    i++;
                }

                pan.Size = new Size(150, 300);

                pnlSlider.Controls.Add(pan);
                pnlSlider.Dock = System.Windows.Forms.DockStyle.Left;
                pnlSlider.AutoScroll = true;

                Session session = sessions.ElementAt(i-1);

                session.FilmName = film.title;
                _sessionService.Update(session);

            }

        }

        private static async Task<List<Result>> GetFilms()
        {
            HttpResponseMessage responseMessage = await client.GetAsync(String.Format("https://api.themoviedb.org/3/movie/now_playing?api_key={0}&language=en-US&page=1", ConfigurationManager.AppSettings["APIKey"]));
            var resultArray = await responseMessage.Content.ReadAsStringAsync();
            var filmList = JsonConvert.DeserializeObject<Root>(resultArray);
            foreach (var film in filmList.results)
            {
                Console.WriteLine(film.title);
            }
            return filmList.results;
        }
    }
}
