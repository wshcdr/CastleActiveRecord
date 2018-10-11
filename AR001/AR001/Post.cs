using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;

namespace AR001
{
    [ActiveRecord("Posts")]
    public class Post : ActiveRecordBase<Post>
    {
        public Post()
        {
            Created = DateTime.Now;
        }

        public Post(String title)
            : this()
        {
            Title = title;
        }


        public Post(Blog blog, String title, String contents, String category)
            : this()
        {
            Blog = blog;
            Title = title;
            Contents = contents;
            Category = category;
        }

        [PrimaryKey(PrimaryKeyType.Native, "post_id")]
        public int Id { get; set; }

        [Property("post_title")]
        public String Title { get; set; }

        [Property("post_contents", ColumnType = "StringClob")]
        public String Contents { get; set; }

        [Property("post_category")]
        public String Category { get; set; }

        [BelongsTo("post_blogid")]
        public Blog Blog { get; set; }

        [Property("post_created")]
        public DateTime Created { get; set; }

        [Property("post_published")]
        public bool Published { get; set; }
    }
}
