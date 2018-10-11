# CastleActiveRecord
It is a ActiveRecord tutorial
and SQL like following:

<pre><code>

CREATE TABLE Blogs (
    blog_id     int IDENTITY(1, 1) PRIMARY KEY,
    blog_name   varchar(50),
    blog_author varchar(50)
)

CREATE TABLE Posts (
    post_id        int IDENTITY(1, 1) PRIMARY KEY,
    post_title     varchar(50),
    post_contents  text,
    post_category  varchar(50),
    post_blogid    int FOREIGN KEY REFERENCES Blogs (blog_id),
    post_created   datetime,
    post_published bit
)
</code></pre>

enjoy it!
