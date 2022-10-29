using Microsoft.AspNetCore.Mvc;
using net6_note_system.DAL.IRepository;
using net6_note_system.ViewModels;

namespace net6_note_system.Controllers
{
    public class NoteController : Controller
    {
        private INoteRepository _repository;
        public NoteController(INoteRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var notes = _repository.GetListAsync();

            return View(notes);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(NoteViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _repository.AddAsync(new Models.Note
            {
                Title = model.Title,
                Content = model.Content,
                CreateUser = 1,
                CreateTime = DateTime.Now
            });

            return RedirectToAction("Index");
        }
    }
}
