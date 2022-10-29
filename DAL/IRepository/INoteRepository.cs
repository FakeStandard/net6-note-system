using net6_note_system.Models;

namespace net6_note_system.DAL.IRepository
{
    public interface INoteRepository
    {
        Task<List<Note>> GetListAsync();
        Task<Note> GetByIdAsync(int id);
        Task AddAsync(Note note);
        Task UpdateAsync(Note note);
    }
}
