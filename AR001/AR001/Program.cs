using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;
using System.Configuration;
using Castle.ActiveRecord.Framework.Config;
using System.Collections;

namespace AR001
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfigurationSource source = (IConfigurationSource)ConfigurationManager.GetSection("activerecord");
            ActiveRecordStarter.Initialize(source, typeof(Post), typeof(Blog));


            Blog _blog = new Blog();
            _blog.Author = "dd";
            _blog.Name = "forum";
            _blog.Create();

            Blog blog = Blog.Find(1);

            Post post = new Post("This is my second post");
            post.Blog = blog; // Linking them
            post.Save();

            

        }
    }
}
