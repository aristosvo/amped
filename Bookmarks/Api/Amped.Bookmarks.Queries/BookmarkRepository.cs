using Amped.Bookmarks.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Amped.Bookmarks.Queries;

public interface IBookmarkRepository
{
    Task<IEnumerable<Bookmark>> GetAll();
}

public class BookmarkRepository : IBookmarkRepository
{
    private readonly AmpedDbContext _db;

    public BookmarkRepository(AmpedDbContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Bookmark>> GetAll()
    {
        return await _db.Bookmarks
            .Select(b => new Bookmark
            {
                Id = b.Id,
                Uri = b.Uri,
                Owner = Guid.Parse(b.Owner),
                Read = b.Read
            })
            .ToListAsync();
    }
}