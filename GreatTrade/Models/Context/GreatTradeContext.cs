using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models.Context
{
    public class GreatTradeContext:DbContext {
        /*
         * Table that reference the users on the database
         */
        public DbSet<User> Users { get; set; }

        /*
         * The table that reference the Profiles on the database
         */
        public DbSet<Profile> Profiles { get; set; }

        public GreatTradeContext(DbContextOptions<GreatTradeContext> options): base (options ) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);


            /*Load Users */
            var users = LoadUsers();

            /*Load the profiles*/
            var profiles = GenerateProfiles(users);

            modelBuilder.Entity<User>().HasData(users.ToArray());
            modelBuilder.Entity<Profile>().HasData(profiles.ToArray());
        }

       /* private List<Profile> LoadProfies(List<User> users)
        {
            var profiles = new List<Profile>();

            foreach (var user in users)
            {
                var profile = GenerateProfile(user);
                Profiles.Append(profile);
            }
        }*/

        /*private List<Profile> LoadProfie() {
            return GenerateProfiles(20);
        }*/

        private List<User> LoadUsers()
        {
            var listUsers = GenerateUsers(20);
            for (int i = 0; i < listUsers.Count(); i++)
            {
                var user = listUsers[i];
                user.Id = i+1;
                //user.Profile = GenerateProfile(user);
            }
            return listUsers;
        }



        /*private List<Profile> LoadProfiles(List<User> users) {
            var profiles = users.Select(user => user.Profile).ToList();
            return profiles;
        }*/

        private List<User> GenerateUsers(int cant)
        {
            string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] last_name1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] last_name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var userList =  from n1 in name1
                            from n2 in last_name2
                            from a1 in last_name1
                            select new User {
                                FirstName = $"{n1} {n2}",
                                LastName = $"{a1}",
                                Email = $"{n1.ToLower()}_{n2.ToLower()}_{a1.ToLower()}@globant.com",
                            };
            return userList.OrderBy((user) => user.Id).Take(cant).ToList();
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

            /*for (int i = 0; i < profiles.Count(); i++)
            {
                var profile = new Profile()
                {
                    Id = i+1,
                    UserId = user.Id,
                    Description = " Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. " +
                    "Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Pellentesque in ipsum id orci porta dapibus. " +
                    "Proin eget tortor risus.",
                };
                profiles.Append(profile);*/
            /*}*/    
        }

        private Profile GenerateProfile(User user) {
            var profile = new Profile() {
                Id = user.Id,
                UserId = user.Id,
                Description = /*"Yo soy "+user.FullName()+*/
            " Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. " +
                "Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Pellentesque in ipsum id orci porta dapibus. " +
                "Proin eget tortor risus.",
            };
            return profile;
        }
    }
}
