using MovieTicketingSystem_LLD.Models;
using MovieTicketingSystem_LLD.Repositories;
using MovieTicketingSystem_LLD.Services;

var repo = new InMemoryShowRepository();
var showService = new ShowService(repo);
var bookingService = new BookingService(repo);

var movie = new Movie("Interstellar");
var screen = new Screen("Screen 1", 10);

var show = showService.CreateShow(movie, screen, DateTime.Now.AddHours(2));

var booking = bookingService.CreateBooking(show.Id, new List<int> { 1, 2, 3 });

Console.WriteLine($"Booking {booking.Id} confirmed for seats: {string.Join(",", booking.SeatNumbers)}");
