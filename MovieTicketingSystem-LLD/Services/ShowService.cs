using MovieTicketingSystem_LLD.Models;
using MovieTicketingSystem_LLD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketingSystem_LLD.Services
{
    public class ShowService
    {
        private readonly IShowRepository _repo;

        public ShowService(IShowRepository repo)
        {
            _repo = repo;
        }

        public Show CreateShow(Movie movie, Screen screen, DateTime time)
        {
            var show = new Show(movie, screen, time);
            _repo.AddShow(show);
            return show;
        }
    }
}
