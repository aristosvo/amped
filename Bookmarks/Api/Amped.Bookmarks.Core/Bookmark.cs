﻿namespace Amped.Bookmarks.Core;

public class Bookmark
{
    public Guid Id { get; }
    public Uri Uri { get; }
    public bool Read { get; private set; }
    public string Owner { get; }

    public static Bookmark CreateUnreadBookmark(Uri uri, string owner) => new(uri, owner, false); 
        
    internal Bookmark(Uri uri, string owner, bool read)
    {
        Uri = uri ?? throw new ArgumentNullException();
        Owner = owner;
        Read = read;
        Id = Guid.NewGuid();
    }

    private Bookmark()
    {
        
    }

    public void MarkRead()
    {
        Read = true;
    }
}