using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Delegat
{
    class UseDelegate
    {
        public static void Example()
        {
            Blogger blogger = new Blogger();
            User user1 = new User("Jola", blogger);
            User user2 = new User("Asia", blogger);
            User user3 = new User("Kamila", blogger);

            BloggerEventArgs bloggerArgs = new BloggerEventArgs("Post nr1","dawno dawno temu...");
            blogger.OnNewPost(bloggerArgs);
            
        }
        
    }
}
