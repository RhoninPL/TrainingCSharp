using System;

namespace ConsoleApplication1.Delegat
{
    public class User
    {
        public string Name { get; private set; }

        public User(string name, Blogger blogger)
        {
            Name = name;
            blogger.NewPost += Blogger_NewPost;
        }

        private void Blogger_NewPost(object sender, EventArgs e)
        {
            if (e is BloggerEventArgs)
            {
                BloggerEventArgs bloggerEvent= e as BloggerEventArgs;

                Console.WriteLine("Uzytkowniku {0} nowy post", Name);
                Console.WriteLine("O nazwie {0}", bloggerEvent.Title);
            }
        }
    }
}