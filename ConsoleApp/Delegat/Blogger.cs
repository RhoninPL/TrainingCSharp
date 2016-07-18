using System;

namespace ConsoleApplication1.Delegat
{
    public class Blogger
    {
        public event EventHandler NewPost;

        public void OnNewPost(BloggerEventArgs e)
        {
            EventHandler newPostBlog = NewPost;
            if (newPostBlog != null)
            {
                newPostBlog(this, e);
            }
        }
    }

    public class BloggerEventArgs : EventArgs
    {
        public string Title { get; private set; }

        public string Text { get; private set; }

        public BloggerEventArgs(string title, string text)
        {
            Title = title;
            Text = text;
        }
    }
}