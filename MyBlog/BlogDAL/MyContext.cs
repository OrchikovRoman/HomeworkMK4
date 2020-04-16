using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BlogDAL.Entities;

namespace BlogDAL
{
    public class MyContext : DbContext
    {
        static MyContext()
        {
            Database.SetInitializer<MyContext>(new MyContextInit());
        }
        public MyContext() : base(@"Data Source=.;Initial Catalog=MyWebBlog;Integrated Security=True")
        {
            Configuration.LazyLoadingEnabled = true;
        }


        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        class MyContextInit : CreateDatabaseIfNotExists<MyContext>
        {
            protected override void Seed(MyContext context)
            {
                context.Authors.Add(new Author { Id = 1, Name = "Admin" });
                context.Authors.Add(new Author { Id = 2, Name = "Roman Orchikov" });
                context.Authors.Add(new Author { Id = 3, Name = "Humanoid" });
                context.Authors.Add(new Author { Id = 4, Name = "Auto" });

                context.Categories.Add(new Category { Id = 1, Name = "News" });
                context.Categories.Add(new Category { Id = 2, Name = "Porno News" });
                context.Categories.Add(new Category { Id = 3, Name = "Other" });
                context.Categories.Add(new Category { Id = 4, Name = "Auto" });
                context.Categories.Add(new Category { Id = 5, Name = "Main" });

                context.Tags.Add(new Tag { Id = 1, Name = "Kharkiv" });
                context.Tags.Add(new Tag { Id = 2, Name = "UA" });
                context.Tags.Add(new Tag { Id = 3, Name = "Bloger" });
                context.Tags.Add(new Tag { Id = 4, Name = "Whether News" });

                context.Articles.Add(new Article { Id = 1, Title = "Роман решил стать Админом", Txt = "В скором времени Роман станет Админом сие чудного сайта, заявил он всем", Img = "Orchikov.jpg", DateArticle = new DateTime(2020, 4, 11), AuthorId = 2 });
                context.Articles.Add(new Article { Id = 2, Title = "Украина движется по оптимистичному сценарию распространения коронавируса — Ляшко", Txt = "Об этом заявил главный санитарный врач Виктор Ляшко в интервью LB.ua. «Сейчас мы идем по сценарию, который предусматривает, что за период вспышки будет инфицировано не более 2 % населения.Почему 2 % это оптимистичный сценарий ? Потому что, по нашим расчетам, при 2 % инфицированного населения наша система здравоохранения безболезненно справится с тем количеством больных, которые будут поступать в отделения интенсивной терапии», — рассказал Ляшко.", Img = "Lyashko.jpg", DateArticle = new DateTime(2020, 4, 12), AuthorId = 1 });
                context.Articles.Add(new Article { Id = 3, Title = "PornHub впервые покажет на своем сайте не порно-фильм: трейлер", Txt = "PornHub покажет документальный фильм о сексуальных меньшинствах Лос-Анжелеса 2000-х годов Американский порносайт PornHub предоставит пользователям возможность посмотреть первый не порнографический фильм на сайте.Об этом сообщает Variety. Речь идет о фильме Shakedown(\"Вымогательство\") американской концептуальной художницы Лейлы Вейнрауб о сексуальных меньшинствах Лос - Анджелеса в 2000 - х годах. Подпишитесь на наши новости в Telegram: проверенные факты, только важное Вейнрауб в 2002 году начала снимать черный лесбийский стриптиз - клуб в районе Мид - Сити в Лос - Анджелесе.За шесть лет она накопила более 400 часов видеоматериалов, из которого впоследствии и смонтировала фильм.Shakedown был впервые показан в Берлине в 2018 г. \"Этот фильм является частью общего обязательства Pornhub по поддержке искусства. Мы хотим, чтобы нас воспринимали как платформу, которую могут использовать художники\", -сказал директор бренда Pornhub Алекс Кляйн. На Pornhub фильм будет доступен в течение месяца, а после появится на ТВ и в iTunes. Видео: 18 + ", Img = "Pornohub.jpg", DateArticle = new DateTime(2020, 4, 10), AuthorId = 3 });
                context.Articles.Add(new Article { Id = 4, Title = "Test", Txt = "test", Img = "Other.png", DateArticle = new DateTime(2011, 01, 01), AuthorId = 2 });
            }
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .ToTable("Articles")
                .HasKey(x => x.Id);
            modelBuilder.Entity<Article>()
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            modelBuilder.Entity<Article>()
                .Property(x => x.Title)
                .HasColumnName("Title")
                .IsRequired();
            modelBuilder.Entity<Article>()
                .Property(x => x.Txt)
                .HasColumnName("Txt")
                .IsOptional();
            modelBuilder.Entity<Article>()
                .Property(x => x.Img)
                .HasColumnName("Img")
                .IsOptional();
            modelBuilder.Entity<Article>()
                .Property(x => x.DateArticle)
                .HasColumnName("DataArticle")
                .IsRequired();

            modelBuilder.Entity<Author>()
                .ToTable("Authors")
                .HasKey(x => x.Id);
            modelBuilder.Entity<Author>()
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            modelBuilder.Entity<Author>()
                .Property(x => x.Name)
                .HasColumnName("Name")
                .IsRequired();
            modelBuilder.Entity<Author>()
                .HasMany(x => x.Articles)
                .WithRequired(x => x.Author);

            modelBuilder.Entity<Category>()
                .ToTable("Categories")
                .HasKey(x => x.Id);
            modelBuilder.Entity<Category>()
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            modelBuilder.Entity<Category>()
                .Property(x => x.Name)
                .HasColumnName("Name")
                .IsRequired();
            modelBuilder.Entity<Category>()
                .HasMany(x => x.Articles)
                .WithMany(x => x.Categories);

            modelBuilder.Entity<Tag>()
                .ToTable("Tags")
                .HasKey(x => x.Id);
            modelBuilder.Entity<Tag>()
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            modelBuilder.Entity<Tag>()
                .Property(x => x.Name)
                .HasColumnName("Name")
                .IsRequired();
            modelBuilder.Entity<Tag>()
                .HasMany(x => x.Articles)
                .WithMany(x => x.Tags);


        }
    }
}
