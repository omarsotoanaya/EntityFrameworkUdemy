using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabaseFirstDemoEntities1();
            var post = new Post
            {
                Body = "Body",
                DataPublished = DateTime.Now,
                Title = "Title",
                TestColumn = "test",
                PostID = 2
            };

            context.Post.Add(post);
            context.SaveChanges();
        }
    }
}
