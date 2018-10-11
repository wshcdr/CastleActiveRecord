using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;

namespace AR001
{
    [ActiveRecord("Blogs")]
    public class Blog : ActiveRecordBase<Blog>
    {
        [PrimaryKey(PrimaryKeyType.Native, "blog_id")]
        public int Id { get; set; }

        [Property("blog_name")]
        public String Name { get; set; }

        [Property("blog_author")]
        public String Author { get; set; }
    }
}
