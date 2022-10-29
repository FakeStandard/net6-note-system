using Microsoft.EntityFrameworkCore;
using net6_note_system.DAL.IRepository;
using net6_note_system.Models;

namespace net6_note_system.DAL.Repository
{
    public class NoteRepository : INoteRepository
    {
        private NoteContext _context;

        public NoteRepository(NoteContext context)
        {
            _context = context;
        }

        public Task<List<Note>> GetListAsync()
            => _context.Notes.ToListAsync();

        public Task<Note> GetByIdAsync(int id)
            => _context.Notes.FirstOrDefaultAsync(c => c.ID == id);

        public Task AddAsync(Note note)
        {
            _context.Notes.Add(note);
            return _context.SaveChangesAsync();
        }

        public Task UpdateAsync(Note note)
        {
            _context.Entry(note).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }
    }
}
