using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreatTrade.Models;

namespace GreatTrade.Models.Context
{
    public class GreatTradeContext : DbContext {
        /*
         * Table that reference the users on the database
         */
        public DbSet<User> Users { get; set; }

        /*
         * The table that reference the Profiles on the database
         */
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<View> Views { get; set; }

        public GreatTradeContext(DbContextOptions<GreatTradeContext> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            var profiles = new List<Profile>()
            {
                new Profile(){ Id=1, UserId = 1, Description="Hola :)", Facebook="https://www.facebook.com/",
                    Instagram ="https://www.instagram.com", Twitter="https://twitter.com/" , Avatar = "/images/korkux.png" },
                new Profile(){ Id=2, UserId = 2, Description="Hola, soy un Humano", Facebook="https://www.facebook.com/", Avatar = "/images/avatar.jpg" },
                new Profile(){ Id=3, UserId = 3, Description="Hola, soy una Humana", Avatar = "/images/avatar.jpg" },
                new Profile(){ Id=4, UserId = 4, Avatar = "/images/avatar.jpg" },
                new Profile(){ Id=5, UserId = 5, Avatar = "/images/avatar.jpg" },
            };

            var users = new List<User>()
            {
               new User(){ Id = 1, FirstName= "KorKux", Role=Enum.TypeRoles.Administrator,  Email="korkux@globant.com",Country= Enum.TypeCountries.Colombia, CityId=3, }, 
               new User(){ Id = 2, FirstName= "Sara", IsActive=true, Role=Enum.TypeRoles.Administrator ,LastName="Cabrera",Email="s.cabreara@globant.com",Country= Enum.TypeCountries.Colombia, CityId=2},
               new User(){ Id = 3, FirstName= "Sara", LastName="Garcia",Email="sara_garcia@globant.com",Country= Enum.TypeCountries.Colombia, CityId=1},
               new User(){ Id = 4, FirstName= "Carlos", Role=Enum.TypeRoles.Administrator, LastName="Sanchez",Email="carlos.san@globant.com",Country= Enum.TypeCountries.Argentina, CityId=5},
               new User(){ Id = 5, FirstName= "Roberto", LastName="Diaz",Email="rdiaz@globant.com",Country= Enum.TypeCountries.Colombia, CityId=4},
            };

            var publications = new List<Publication>() {
                new Publication(){ Id=1, UserId=1, },
                new Publication(){ Id=2, UserId=1, },
                new Publication(){ Id=3, UserId=1, },
                new Publication(){ Id=4, UserId=2, },
                new Publication(){ Id=5, UserId=3, },
                new Publication(){ Id=6, UserId=4, },
                new Publication(){ Id=7, UserId=5, },
                new Publication(){ Id=8, UserId=2, },
                new Publication(){ Id=9, UserId=3, },
                new Publication(){ Id=10, UserId=5, },
            };

            var cities = new List<City>() {
                new City(){ Id = 1, Contry = Enum.TypeCountries.Colombia, Name="Bogotá" },
                new City(){ Id = 2, Contry = Enum.TypeCountries.Colombia, Name="Medellin" },
                new City(){ Id = 3, Contry = Enum.TypeCountries.Colombia, Name="Cali" },
                new City(){ Id = 4, Contry = Enum.TypeCountries.Colombia, Name="Cartagena" },
                new City(){ Id = 5, Contry = Enum.TypeCountries.Argentina, Name="Buenos Aires" },
            };

            var categories = new List<Category>() {
                 new Category(){  Id= 1, Name="Tecnología", },
                new Category(){  Id= 2, Name="Ropa", },
                new Category(){  Id= 3, Name="Vehiculos", },
                new Category(){  Id= 4, Name="Accesorios", },
                new Category(){  Id= 5, Name="Entretenimiento",},
            };

            var alerts = new List<Alert>() {
                new Alert(){ Id=1,  }
            };

            var subcategories = new List<SubCategory>() {
                new SubCategory(){ Id = 1, CategoryId=1, Name="Celulares" },
                new SubCategory(){ Id = 2, CategoryId=3, Name="Motos" },
                new SubCategory(){ Id = 3, CategoryId=2, Name="Camisetas" },
                new SubCategory(){ Id = 4, CategoryId=5, Name="Balones" },
                new SubCategory(){ Id = 5, CategoryId=1, Name="Tablets" },
                new SubCategory(){ Id = 6, CategoryId=1, Name="Tecnologia Avanzada" },
                 new SubCategory(){ Id = 7, CategoryId=4, Name="Relojes" },
                  new SubCategory(){ Id = 8, CategoryId=3, Name="Carros" },
                   new SubCategory(){ Id = 9, CategoryId=1, Name="Camaras" },
            };

            var products = new List<Product>() {
               new Product( ){ Id = 1, PublicationId=1, SubCategoryId = 1, Title="Samsung S7", Insignia = Enum.TypeInsignias.New, Date= new DateTime(2019,04,30), Units=10, Price=700000,
                    Status = Enum.ProductStatus.Active, CityId=1,  Description="Samsung Galaxy S7", RelatedCities="Cali", Tags="Celulares,Tecnologia" },
                new Product( ){ Id = 2, PublicationId=2, SubCategoryId = 8, Title="Carro 25000 km",Insignia = Enum.TypeInsignias.New, Date= new DateTime(2019,04,17), Units=1, Price=80000000,
                    Status = Enum.ProductStatus.Active, CityId=1,  Description="Modelo 2017", RelatedCities="Bogota", Tags="Automoviles" },
                new Product( ){ Id = 3, PublicationId=3, SubCategoryId = 9, Title="Camara Gopro", Insignia = Enum.TypeInsignias.New, Date= new DateTime(2019,03,01), Units=6, Price=2000000,
                    Status = Enum.ProductStatus.Active, CityId=2,  Description="24 Megapixeles", RelatedCities="Medellin" , Tags="Camaras"},
                new Product( ){ Id = 4, PublicationId=4, SubCategoryId = 3, Title="Camisa Barcelona 2019", Insignia = Enum.TypeInsignias.New, Date= new DateTime(2019,04,24), Units=10, Price=250000,
                    Status = Enum.ProductStatus.Active, CityId=2,  Description="Coleccion 2019", RelatedCities="Montevideo", Tags="Ropa"},
                new Product( ){ Id = 5, PublicationId=5, SubCategoryId = 6, Title="Drone",Insignia = Enum.TypeInsignias.New, Date= new DateTime(2019,04,24), Units=5, Price=900000,
                    Status = Enum.ProductStatus.Active, CityId=3,  Description="1 mes de uso, con camara" , RelatedCities="Rio", Tags="Tecnologia"},
                new Product( ){ Id = 6,PublicationId=6, SubCategoryId = 6, Title="Impresora 3D", Insignia = Enum.TypeInsignias.New, Date= new DateTime(2019,04,24), Units=3, Price=2500000,
                    Status = Enum.ProductStatus.Active, CityId=4,  Description="2 Meses de uso", RelatedCities="Barcelona", Tags="Tecnologia"},
                new Product( ){ Id = 7,PublicationId=7, SubCategoryId = 4, Title="Balon de la Champions", Insignia = Enum.TypeInsignias.New, Date= new DateTime(2019,04,30), Units=12, Price=150000,
                    Status = Enum.ProductStatus.Active, CityId=3,  Description="Nuevo" , RelatedCities="Cali", Tags="Deportes"},
                new Product( ){ Id = 8,PublicationId=8, SubCategoryId = 5, Title="Tablet Generica",Insignia = Enum.TypeInsignias.New, Date= new DateTime(2019,04,30), Units=10, Price=120000,
                    Status = Enum.ProductStatus.Active, CityId=4,  Description="Android 8.0" , RelatedCities="Bogota", Tags="Tecnologia"},
                new Product( ){ Id = 9,PublicationId=9, SubCategoryId = 7, Title="Reloj Rolex", Insignia = Enum.TypeInsignias.New, Date= new DateTime(2019,04,17), Units=2, Price=40000000,
                    Status = Enum.ProductStatus.Active, CityId=5,  Description="Oro 18k" , RelatedCities="Medellin", Tags="Accesorios"},
                 new Product( ){ Id = 10, PublicationId=10, SubCategoryId = 2, Title="Moto Suzuki", Insignia = Enum.TypeInsignias.New, Date= new DateTime(2019,04,17), Units=1, Price=150000000,
                    Status = Enum.ProductStatus.Active, CityId=3,  Description="Nueva de concesionario" , RelatedCities="Cali" , Tags="Vehiculos"},

            };

            var photos = new List<Photo>() {
                new Photo(){ Id=1, ProductId=1, Route="/images/celular.jpg"},
                new Photo(){ Id=2, ProductId=2, Route="/images/carro.jpg"},
                new Photo(){ Id=3, ProductId=3, Route="/images/GoPro.jpg"},
                new Photo(){ Id=4, ProductId=4, Route="/images/BarcaShirt.jpg"},
                new Photo(){ Id=5, ProductId=5, Route="/images/Drone.jpg"},
                new Photo(){ Id=6, ProductId=6, Route="/images/3D.jpg"},
                new Photo(){ Id=7, ProductId=7, Route="/images/BallChampions.jpg"},
                new Photo(){ Id=8, ProductId=8, Route="/images/Tablet.jpg"},
                new Photo(){ Id=9, ProductId=9, Route="/images/Rolex.jpg"},
                new Photo(){ Id=10, ProductId=10, Route="/images/Suzuki.jpg"},

            };

            var questions = new List<Question>() {
                new Question(){ Id=1,  Description="¿Cómo hago para comprar este producto?", ProductId=1 },
            };

            var answers = new List<Answer>()
            {
                new Answer(){ Id=1, QuestionId=1, Description="Le das en el botón de comprar" }
            };

            var tags = new List<Tag>() {
                new Tag(){  Id= 1, ProductId=1, Description="Samsung", AlertId=1},
            };

            var transactions = new List<Transaction>() {
                new Transaction(){ Id=1, BuyerId=1, SellerId=2, ProductId=3, },
                new Transaction(){ Id=2, BuyerId=2, SellerId=1, ProductId=1, },
            };



            var notifcations = new List<Notification>()
            {
                new Notification(){ Id=1, UserId=1, Messasge="Carlos está interesado en tu producto", Checked=false},
                new Notification(){ Id=2, UserId=1, Messasge="Notificación de prueba 1", Checked=true},
                new Notification(){ Id=3, UserId=2, Messasge="Notificación 2", Checked=false},
                new Notification(){ Id=4, UserId=4, Messasge="Notificación 3", Checked=false},
                new Notification(){ Id=5, UserId=3, Messasge="Roberto está interesado en tu producto", Checked=true},
                new Notification(){ Id=6, UserId=5, Messasge="Sara está interesado en tu producto", Checked=false},
                new Notification(){ Id=7, UserId=6, Messasge="Jorge está interesado en tu producto", Checked=false},
            };

            modelBuilder.Entity<City>().HasData(cities.ToArray());
            modelBuilder.Entity<Product>().HasData(products.ToArray());

            modelBuilder.Entity<User>().HasData(users.ToArray());
            modelBuilder.Entity<Profile>().HasData(profiles.ToArray());
            modelBuilder.Entity<Publication>().HasData(publications.ToArray());
            modelBuilder.Entity<Transaction>().HasData(transactions.ToArray());
            modelBuilder.Entity<Photo>().HasData(photos.ToArray());

            modelBuilder.Entity<Alert>().HasData(alerts.ToArray());

            modelBuilder.Entity<Answer>().HasData(answers.ToArray());
            modelBuilder.Entity<Category>().HasData(categories.ToArray());
            modelBuilder.Entity<Question>().HasData(questions.ToArray());
            modelBuilder.Entity<SubCategory>().HasData(subcategories.ToArray());
            modelBuilder.Entity<Tag>().HasData(tags.ToArray());


            /*Load Users */
            // var users = LoadUsers();

            /*Load the profiles*/
            // var profiles = GetProfiles(users);






            /* modelBuilder.Entity<Match>()
                     .HasRequired(m => m.HomeTeam)
                     .WithMany(t => t.HomeMatches)
                     .HasForeignKey(m => m.HomeTeamId)
                     .WillCascadeOnDelete(false);

             modelBuilder.Entity<Match>()
                         .HasRequired(m => m.GuestTeam)
                         .WithMany(t => t.AwayMatches)
                         .HasForeignKey(m => m.GuestTeamId)
                         .WillCascadeOnDelete(false);*/
        }

        private List<Profile> GetProfiles(List<User> users)
        {
            var profiles = new List<Profile>();
            foreach (var user in users) {
                profiles.Add(user.Profile);
            }
            return profiles;
        }

        private List<User> LoadUsers()
        {
            var listUsers = GenerateUsers(20);
            for (int i = 0; i < listUsers.Count(); i++)
            {
                var user = listUsers[i];
                user.Id = i + 1;
                user.Profile = GenerateProfile(user);
            }
            return listUsers;
        }

        private List<Notification> GenerateNotifacations(int cant) {
            List<Notification> notifications = new List<Notification>();
            for (int i = 0; i < cant; i++)
            {
                notifications.Add(new Notification() {
                    Messasge = "Notificaión Número " +(i+1)
                });

            }
            return notifications;
        }

        private List<User> GenerateUsers(int cant)
        {
            string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] last_name1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] last_name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var userList = from n1 in name1
                           from n2 in last_name2
                           from a1 in last_name1
                           select new User
                           {
                               FirstName = $"{n1} {n2}",
                               LastName = $"{a1}",
                               Email = $"{n1.ToLower()}_{n2.ToLower()}_{a1.ToLower()}@globant.com",
                           };
            return userList.OrderBy((user) => user.Id).Take(cant).ToList();
        }

        






        private List<Category> GenerateCategories(){
            var categories = new List<Category>() {
                new Category() {
                    Name = "Ropa",
                    
                },
            };
            return categories;
        }



        private List<Profile> GenerateProfiles(List<User> users)
        {
            var profiles = new List<Profile>();
            var temp = new List<Profile>();
            foreach (var user in users)
            {
                var profile = new Profile();
                profile.Id = user.Id;
                profile.UserId = user.Id;
                profile.Description = user.FullName() + " Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. " +
                    "Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Pellentesque in ipsum id orci porta dapibus. " +
                    "Proin eget tortor risus.";
                temp.Add(profile);
            }

            profiles.AddRange(temp);

            return profiles;
        }

        private Profile GenerateProfile(User user) {
            var profile = new Profile() {
                Id = user.Id,
                UserId = user.Id,
                Description = "Hola, mi nombre es "+user.FullName(),
            };
            return profile;
        }

        public DbSet<GreatTrade.Models.Publication> Publication { get; set; }

        public DbSet<GreatTrade.Models.Transaction> Transaction { get; set; }


        public User UserActive()
        {
            return Users.First(x => x.IsActive);
        }
    }
}
