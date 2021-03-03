using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAB_Assignment_2.Models;
using DAB_Assignment_2.RelationshipClasses;
namespace DAB_Assignment_2.DAL
{
    //DENNE FIL BENYTTES TIL AT INDSÆTTE DUMMY DATA I DE FORSKELLIGE ENTITIES

    public class DbInitializer
    {
        public void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();



            var all = from c in context.ReviewGuests select c;
            context.ReviewGuests.RemoveRange(all);
            context.SaveChanges();

            var all2 = from c in context.Guests select c;
            context.Guests.RemoveRange(all2);
            context.SaveChanges();

            var all3 = from c in context.Reviews select c;
            context.Reviews.RemoveRange(all3);
            context.SaveChanges();

            var all4 = from c in context.Tables select c;
            context.Tables.RemoveRange(all4);
            context.SaveChanges();

            var all5 = from c in context.Waiters select c;
            context.Waiters.RemoveRange(all5);
            context.SaveChanges();

            var all6 = from c in context.RestaurantDishes select c;
            context.RestaurantDishes.RemoveRange(all6);
            context.SaveChanges();

            var all7 = from c in context.Dishes select c;
            context.Dishes.RemoveRange(all7);
            context.SaveChanges();

            var all8 = from c in context.Restaurants select c;
            context.Restaurants.RemoveRange(all8);
            context.SaveChanges();


            var restaurants = new Restaurant[]
            {
                new Restaurant{Name = "Bob's Place", Address = "Mordor Lane 35", AverageRating = 2, Type = "Dessert"},
                new Restaurant{Name = "The Golden Seagull", Address = "Fast Food Road 88", AverageRating = 4, Type = "Dinner"},
                new Restaurant{Name = "Jelle's Icecream Bar", Address = "Candy Way 15", AverageRating = 0.1, Type = "Dessert"},
                new Restaurant{Name = "Nicolo's Pizza", Address = "Growl Hill 32", AverageRating = 3, Type = "Lunch"},
                new Restaurant{Name = "Jogan's Fine Dining", Address = "Fancy Boulevard 1", AverageRating = 1, Type = "Dinner"},
                new Restaurant{Name = "Frederico's Breakfast", Address = "Early Bird 75", AverageRating = 3.5, Type = "Breakfast"},
                new Restaurant{Name = "Pregante's Sanwitch", Address = "Strange Green 2", AverageRating = 1, Type = "Lunch"},
                new Restaurant{Name = "Only Coffee", Address = "Sleepy Road 14", AverageRating = 5, Type = "Breakfast"},
            };
            foreach (Restaurant c in restaurants)
            {
                context.Restaurants.Add(c);
            }
            context.SaveChanges();

            var dishes = new Dish[]
            {
                new Dish{DishName = "Cheese Burger", Price = 14, Type = "Main Course"},
                new Dish{DishName = "Bananasplit", Price = 20, Type = "Dessert"},
                new Dish{DishName = "Breadsticks", Price = 10, Type = "Appetizer"},
                new Dish{DishName = "T-Bone", Price = 120, Type = "Main Course"},
                new Dish{DishName = "Sirloin Steak", Price = 110, Type = "Main Course"},
                new Dish{DishName = "Muffin", Price = 15, Type = "Dessert"},
                new Dish{DishName = "King Crabs", Price = 40, Type = "Appetizer"},
                new Dish{DishName = "Hamburger", Price = 12, Type = "Main Course"},
                new Dish{DishName = "Bacon Orionrings", Price = 33, Type = "Appetizer"},
                new Dish{DishName = "Hashbrowns", Price = 20, Type = "Appetizer"},
                new Dish{DishName = "Milkshake", Price = 30, Type = "Dessert"},
                new Dish{DishName = "Pizza Slice", Price = 20, Type = "Main Course"},
                new Dish{DishName = "Dates with Bacon", Price = 30, Type = "Appetizer"},
                new Dish{DishName = "Chilli Chesse Tops", Price = 8, Type = "Appetizer"},
                new Dish{DishName = "Pain au Chocolat", Price = 8, Type = "Appetizer"},
                new Dish{DishName = "Ice Cream", Price = 12, Type = "Dessert"},
                new Dish{DishName = "Coffee", Price = 15, Type = "Dessert"},
            };
            foreach (Dish d in dishes)
            {
                context.Dishes.Add(d);
            }
            context.SaveChanges();

            var restaurantDishes = new RestaurantDish[]
            {
                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Breadsticks").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Pain au Chocolat").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Muffin").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Bacon Orionrings").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Chilli Chesse Tops").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Hamburger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Bananasplit").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Ice Cream").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Muffin").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Breadsticks").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Pizza Slice").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Hamburger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Dates with Bacon").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "King Crabs").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "T-Bone").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Sirloin Steak").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Pain au Chocolat").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Hashbrowns").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Breadsticks").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Cheese Burger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Hamburger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Coffee").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Only Coffee").RestaurantId
                },

            };
            foreach (RestaurantDish rd in restaurantDishes)
            {
                context.RestaurantDishes.Add(rd);
            }
            context.SaveChanges();

            var waiters = new Waiter[]
            {
                new Waiter
                {
                    Name = "Jens Jensen",
                    Salary = 110,
                    WaiterId = 1,
                    PersonId = 1

                },
                new Waiter
                {
                    Name = "Trine Triger",
                    Salary = 110,
                    WaiterId = 2,
                    PersonId = 2


                },
                new Waiter
                {
                    Name = "Frederik Frederico",
                    Salary = 110,
                    WaiterId = 3,
                    PersonId = 3

                },
                new Waiter
                {
                    Name = "A. Nelprober",
                    Salary = 110,
                    WaiterId = 4,
                    PersonId = 4

                },
                new Waiter
                {
                    Name = "Dick Long",
                    Salary = 110,
                    WaiterId = 5,
                    PersonId = 5

                },
                new Waiter
                {
                    Name = "Hugh Janus",
                    Salary = 110,
                    WaiterId = 6,
                    PersonId = 6

                },
                new Waiter
                {
                    Name = "Moe Lester",
                    Salary = 110,
                    WaiterId = 7,
                    PersonId = 7

                },
                new Waiter
                {
                    Name = "Ho Lee Fuk",
                    Salary = 110,
                    WaiterId = 8,
                    PersonId = 8

                },
            };
            foreach (Waiter w in waiters)
            {
                context.Waiters.Add(w);
            }
            context.SaveChanges();

            var tabels = new Table[]
            {
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId,
                    TableId = 1,
                    WaiterId = 1
                    //WaiterId = waiters.Single(w => w.Name == "Jens Jensen").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId,
                    TableId = 2,
                    WaiterId = 1
                    //WaiterId = waiters.Single(w => w.Name == "Jens Jensen").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId,
                    TableId = 3,
                    WaiterId = 1
                    //WaiterId = waiters.Single(w => w.Name == "Jens Jensen").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId,
                    TableId = 4,
                    WaiterId = 1
                    //WaiterId = waiters.Single(w => w.Name == "Jens Jensen").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId,
                    TableId = 5,
                    WaiterId = 1
                    //WaiterId = waiters.Single(w => w.Name == "Jens Jensen").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    TableId = 6,
                    WaiterId = 2
                    //WaiterId = waiters.Single(w => w.Name == "Trine Triger").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    TableId = 7,
                    WaiterId = 2
                    //WaiterId = waiters.Single(w => w.Name == "Trine Triger").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    TableId = 8,
                    WaiterId = 2
                    //WaiterId = waiters.Single(w => w.Name == "Trine Triger").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    TableId = 9,
                    WaiterId = 2
                    //WaiterId = waiters.Single(w => w.Name == "Trine Triger").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    TableId = 10,
                    WaiterId = 2
                    //WaiterId = waiters.Single(w => w.Name == "Trine Triger").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    TableId = 11,
                    WaiterId = 3
                    //WaiterId = waiters.Single(w => w.Name == "Frederik Frederico").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    TableId = 12,
                    WaiterId = 3
                    //WaiterId = waiters.Single(w => w.Name == "Frederik Frederico").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    TableId = 13,
                    WaiterId = 3
                    //WaiterId = waiters.Single(w => w.Name == "Frederik Frederico").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    TableId = 14,
                    WaiterId = 3
                    //WaiterId = waiters.Single(w => w.Name == "Frederik Frederico").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    TableId = 15,
                    WaiterId = 3
                    //WaiterId = waiters.Single(w => w.Name == "Frederik Frederico").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    TableId = 16,
                    WaiterId = 4
                    //WaiterId = waiters.Single(w => w.Name == "A. Nelprober").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    TableId = 17,
                    WaiterId = 4
                    //WaiterId = waiters.Single(w => w.Name == "A. Nelprober").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    TableId = 18,
                    WaiterId = 4
                    //WaiterId = waiters.Single(w => w.Name == "A. Nelprober").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    TableId = 19,
                    WaiterId = 4
                    //WaiterId = waiters.Single(w => w.Name == "A. Nelprober").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    TableId = 20,
                    WaiterId = 4
                    //WaiterId = waiters.Single(w => w.Name == "A. Nelprober").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    TableId = 21,
                    WaiterId = 5
                    //WaiterId = waiters.Single(w => w.Name == "Dick Long").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    TableId = 22,
                    WaiterId = 5
                    //WaiterId = waiters.Single(w => w.Name == "Dick Long").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    TableId = 23,
                    WaiterId = 5
                    //WaiterId = waiters.Single(w => w.Name == "Dick Long").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    TableId = 24,
                    WaiterId = 5
                    //WaiterId = waiters.Single(w => w.Name == "Dick Long").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    TableId = 25,
                    WaiterId = 5
                    //WaiterId = waiters.Single(w => w.Name == "Dick Long").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId,
                    TableId = 26,
                    WaiterId = 6
                    //WaiterId = waiters.Single(w => w.Name == "Hugh Janus").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId,
                    TableId = 27,
                    WaiterId = 6
                    //WaiterId = waiters.Single(w => w.Name == "Hugh Janus").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId,
                    TableId = 28,
                    WaiterId = 6
                    //WaiterId = waiters.Single(w => w.Name == "Hugh Janus").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId,
                    TableId = 29,
                    WaiterId = 6
                    //WaiterId = waiters.Single(w => w.Name == "Hugh Janus").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId,
                    TableId = 30,
                    WaiterId = 6
                    //WaiterId = waiters.Single(w => w.Name == "Hugh Janus").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId,
                    TableId = 31,
                    WaiterId = 7
                    //WaiterId = waiters.Single(w => w.Name == "Moe Lester").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId,
                    TableId = 32,
                    WaiterId = 7
                    //WaiterId = waiters.Single(w => w.Name == "Moe Lester").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId,
                    TableId = 33,
                    WaiterId = 7
                    //WaiterId = waiters.Single(w => w.Name == "Moe Lester").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId,
                    TableId = 34,
                    WaiterId = 7
                    //WaiterId = waiters.Single(w => w.Name == "Moe Lester").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId,
                    TableId = 35,
                    WaiterId = 7
                    //WaiterId = waiters.Single(w => w.Name == "Moe Lester").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Only Coffee").RestaurantId,
                    TableId = 36,
                    WaiterId = 8
                    //WaiterId = waiters.Single(w => w.Name == "Ho Lee Fuk").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Only Coffee").RestaurantId,
                    TableId = 37,
                    WaiterId = 8
                    //WaiterId = waiters.Single(w => w.Name == "Ho Lee Fuk").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Only Coffee").RestaurantId,
                    TableId = 38,
                    WaiterId = 8
                    //WaiterId = waiters.Single(w => w.Name == "Ho Lee Fuk").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Only Coffee").RestaurantId,
                    TableId = 39,
                    WaiterId = 8
                    //WaiterId = waiters.Single(w => w.Name == "Ho Lee Fuk").WaiterId
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Only Coffee").RestaurantId,
                    TableId = 40,
                    WaiterId = 8
                    //WaiterId = waiters.Single(w => w.Name == "Ho Lee Fuk").WaiterId
                },
            };
            foreach (Table t in tabels)
            {
                context.Tables.Add(t);
            }
            context.SaveChanges();



            var guests = new Guest[]
            {
                new Guest
                {
                    Name = "Anders Andersen",
                    DateOfVisit = new DateTime(2019, 10, 12),
                    TableId = tabels.Single(t => t.TableId == 6).TableId,
                    GuestId = 1,
                    PersonId = 9

                },
                new Guest
                {
                    Name = "Hanne Hansen",
                    DateOfVisit = new DateTime(2019, 10, 13),
                    TableId = tabels.Single(t => t.TableId == 11).TableId,
                    GuestId = 2,
                    PersonId = 10
                },
                new Guest
                {
                    Name = "Christiane Christiansen",
                    DateOfVisit = new DateTime(2019, 10, 15),
                    TableId = tabels.Single(t => t.TableId == 26).TableId,
                    GuestId = 3,
                    PersonId = 11
                },
                new Guest
                {
                    Name = "Charlotte Charlottenborg",
                    DateOfVisit = new DateTime(2019, 10, 8),
                    TableId = tabels.Single(t => t.TableId == 21).TableId,
                    GuestId = 4,
                    PersonId = 12
                },
                new Guest
                {
                    Name = "Rasmus Rasmussen",
                    DateOfVisit = new DateTime(2019, 10, 26),
                    TableId = tabels.Single(t => t.TableId == 21).TableId,
                    GuestId = 5,
                    PersonId = 13
                },
                new Guest
                {
                    Name = "Nicolai Nicolajsen",
                    DateOfVisit = new DateTime(2019, 10, 5),
                    TableId = tabels.Single(t => t.TableId == 12).TableId,
                    GuestId = 6,
                    PersonId = 14
                },
                new Guest
                {
                    Name = "Jesper Jespersen",
                    DateOfVisit = new DateTime(2019, 9, 4),
                    TableId = tabels.Single(t => t.TableId == 22).TableId,
                    GuestId = 7,
                    PersonId = 15
                },
                new Guest
                {
                    Name = "Mette Metz",
                    DateOfVisit = new DateTime(2019, 11, 7),
                    TableId = tabels.Single(t => t.TableId == 31).TableId,
                    GuestId = 8,
                    PersonId = 16
                },
                new Guest
                {
                    Name = "Anna Antonsen",
                    DateOfVisit = new DateTime(2019, 11, 5),
                    TableId = tabels.Single(t => t.TableId == 7).TableId,
                    GuestId = 9,
                    PersonId = 17
                },
                new Guest
                {
                    Name = "A.S. Muncher",
                    DateOfVisit = new DateTime(2019, 11, 3),
                    TableId = tabels.Single(t => t.TableId == 27).TableId,
                    GuestId = 10,
                    PersonId = 18
                },
                new Guest
                {
                    Name = "Anita Dick",
                    DateOfVisit = new DateTime(2019, 11, 1),
                    TableId = tabels.Single(t => t.TableId == 18).TableId,
                    GuestId = 11,
                    PersonId = 19
                },
                new Guest
                {
                    Name = "Ben Derhover",
                    DateOfVisit = new DateTime(2019, 9, 12),
                    TableId = tabels.Single(t => t.TableId == 19).TableId,
                    GuestId = 12,
                    PersonId = 20
                },
                new Guest
                {
                    Name = "Dixon B. Tweenerlegs",
                    DateOfVisit = new DateTime(2019, 10, 22),
                    TableId = tabels.Single(t => t.TableId == 23).TableId,
                    GuestId = 13,
                    PersonId = 21
                },
                new Guest
                {
                    Name = "Dixon Butts",
                    DateOfVisit = new DateTime(2019, 10, 29),
                    TableId = tabels.Single(t => t.TableId == 8).TableId,
                    GuestId = 14,
                    PersonId = 22
                },
                new Guest
                {
                    Name = "Harry Nutt",
                    DateOfVisit = new DateTime(2019, 10, 17),
                    TableId = tabels.Single(t => t.TableId == 5).TableId,
                    GuestId = 15,
                    PersonId = 23
                },
                new Guest
                {
                    Name = "Ivana Fuccu",
                    DateOfVisit = new DateTime(2019, 10, 19),
                    TableId = tabels.Single(t => t.TableId == 13).TableId,
                    GuestId = 16,
                    PersonId = 24
                },
                new Guest
                {
                    Name = "Ivanna B. Spanked",
                    DateOfVisit = new DateTime(2019, 10, 19),
                    TableId = tabels.Single(t => t.TableId == 38).TableId,
                    GuestId = 17,
                    PersonId = 25
                },
                new Guest
                {
                    Name = "Mike Hunt",
                    DateOfVisit = new DateTime(2019, 10, 19),
                    TableId = tabels.Single(t => t.TableId == 24).TableId,
                    GuestId = 18,
                    PersonId = 26
                },
                new Guest
                {
                    Name = "Phil McAvity",
                    DateOfVisit = new DateTime(2019, 10, 19),
                    TableId = tabels.Single(t => t.TableId == 14).TableId,
                    GuestId = 19,
                    PersonId = 27
                },
                new Guest
                {
                    Name = "Wilma Dickfit",
                    DateOfVisit = new DateTime(2019, 10, 9),
                    TableId = tabels.Single(t => t.TableId == 18).TableId,
                    GuestId =20,
                    PersonId = 28
                },
                new Guest
                {
                    Name = "Don Al Trum",
                    DateOfVisit = new DateTime(2019, 10, 27),
                    TableId = tabels.Single(t => t.TableId == 4).TableId,
                    GuestId = 21,
                    PersonId = 29
                },

            };
            foreach (Guest w in guests)
            {
                context.Guests.Add(w);
            }
            context.SaveChanges();


            var reviews = new Review[]
{
                new Review{
                    Text = "Genial Mad oplevelse",
                    Stars = 5 ,
                    DishId = dishes.Single(d => d.DishName == "Cheese Burger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    ReviewId = 1,
                    DishName = "Cheese Burger",
                    GuestId = guests.Single(g => g.GuestId == 1).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 1).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 1).Name
                },
                new Review
                {
                    Text = "Jeg fortrød lidt at jeg gik herhen",
                    Stars = 2,
                    DishId = dishes.Single(d => d.DishName == "Bananasplit").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    ReviewId = 2,
                    DishName = "Bananasplit",
                    GuestId = guests.Single(g => g.GuestId == 2).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 2).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 2).Name
                },
                new Review
                {
                    Text = "AD!!!!",
                    Stars = 1,
                    DishId = dishes.Single(d => d.DishName == "Breadsticks").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId,
                    ReviewId = 3,
                    DishName = "Breadsticks",
                    GuestId = guests.Single(g => g.GuestId == 3).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 3).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 3).Name

                },
                new Review
                {
                    Text = "God betjening og en behagelig oplevelse",
                    Stars = 4,
                    DishId = dishes.Single(d => d.DishName == "T-Bone").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    ReviewId = 4,
                    DishName = "T-Bone",
                    GuestId = guests.Single(g => g.GuestId == 4).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 4).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 4).Name

                },
                new Review
                {
                    Text = "Okay til pengene",
                    Stars = 3,
                    DishId = dishes.Single(d => d.DishName == "Sirloin Steak").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    ReviewId = 5,
                    DishName = "Sirloin Steak",
                    GuestId = guests.Single(g => g.GuestId == 5).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 5).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 5).Name

                },
                new Review
                {
                    Text = "Uhmmm det kan godt anbefales. Lækkert mad",
                    Stars = 4,
                    DishId = dishes.Single(d => d.DishName == "Muffin").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    ReviewId = 6,
                    DishName = "Muffin",
                    GuestId = guests.Single(g => g.GuestId == 6).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 6).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 6).Name

                },
                new Review
                {
                    Text = "Hundeæde!!!",
                    Stars = 1,
                    DishId = dishes.Single(d => d.DishName == "King Crabs").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    ReviewId = 7,
                    DishName = "King Crabs",
                    GuestId = guests.Single(g => g.GuestId == 7).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 7).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 7).Name

                },
                new Review
                {
                    Text = "The sprinkling of gold flakes lent a top note of bullshit. And that was the good part. The skin had an off-putting tang and a rancid flavor, which seeped into the dried-out meat and left a greasy feeling on the roof of my mouth that, like the demonic clown from It, could not be destroyed",
                    Stars = 2,
                    DishId = dishes.Single(d => d.DishName == "Hamburger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId,
                    ReviewId = 8,
                    DishName = "Hamburger",
                    GuestId = guests.Single(g => g.GuestId == 8).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 8).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 8).Name

                },
                new Review
                {
                    Text = "Slowly, gradually, with great mental resistance but still inexorably, it dawned on me that I had paid $98 for a duck with almost no flavor. It was dry, too",
                    Stars = 1,
                    DishId = dishes.Single(d => d.DishName == "Bacon Orionrings").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    ReviewId = 9,
                    DishName = "Bacon Orionrings",
                    GuestId = guests.Single(g => g.GuestId == 9).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 9).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 9).Name

                },
                new Review
                {
                    Text = "When executed poorly (a gummy mass of vermicelli and shellfish that is presumably a riff on the Korean noodle dish japchae), his dishes just sing out of key",
                    Stars = 2,
                    DishId = dishes.Single(d => d.DishName == "Hashbrowns").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId,
                    ReviewId = 10,
                    DishName = "Hashbrowns",
                    GuestId = guests.Single(g => g.GuestId == 10).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 10).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 10).Name

                },
                new Review
                {
                    Text = "You’d better have something in the fridge at home, because the likelihood of your joining the Clean Plate Club here is as good as Omarosa Manigault Newman getting invited to a Christmas party at the White House",
                    Stars = 5,
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    ReviewId = 11,
                    DishName = "Milkshake",
                    GuestId = guests.Single(g => g.GuestId == 11).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 11).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 11).Name

                },
                new Review
                {
                    Text = "While there are many words I could use to describe Nicolo's Pizza, I’m going to say only this: Nicolo's Pizza is a bad restaurant",
                    Stars = 1,
                    DishId = dishes.Single(d => d.DishName == "Pizza Slice").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    ReviewId = 12,
                    DishName = "Pizza Slice",
                    GuestId = guests.Single(g => g.GuestId == 12).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 12).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 12).Name

                },
                new Review
                {
                    Text = "The initial flavor was bland, quickly followed by a fetid, ammonia-like tang. It was an aroma that recalled room-temperature hamburger meat from a grocer that lost power. I felt my eyes water up as I chewed. I tried to swallow. I felt my entire GI tract prepare to purge",
                    Stars = 2,
                    DishId = dishes.Single(d => d.DishName == "Dates with Bacon").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    ReviewId = 13,
                    DishName = "Dates with Bacon",
                    GuestId = guests.Single(g => g.GuestId == 13).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 13).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 13).Name

                },
                new Review
                {
                    Text = "Did it have ‘a simple flavor with a touch of sweetness’? It was hard to say after half of it had been simmered in soy sauce to a bony mush, the other half grilled in salt until chewy and served with its head still on, propped up with a wooden stake like a Big Mouth Billy Bass about to sing",
                    Stars = 5,
                    DishId = dishes.Single(d => d.DishName == "Chilli Chesse Tops").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    ReviewId = 14,
                    DishName = "Chilli Chesse Tops",
                    GuestId = guests.Single(g => g.GuestId == 14).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 14).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 14).Name

                },
                new Review
                {
                    Text = "When compared to similar restaurants, “Empire is their hollow echo, parroting back a faded, carbon-copied version that takes no risks and contributes little to Detroit’s dining scene dialogue",
                    Stars = 3,
                    DishId = dishes.Single(d => d.DishName == "Pain au Chocolat").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId,
                    ReviewId = 15,
                    DishName = "Pain au Chocolat",
                    GuestId = guests.Single(g => g.GuestId == 15).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 15).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 15).Name
                },
                new Review
                {
                    Text = "There’s V for Vegan. There’s GF for Gluten Free. There’s DF for Dairy Free. I think they’re missing a few. There should be TF for Taste Free and JF for Joy Free and AAHYWEH for Abandon All Hope, Ye Who Enter Here",
                    Stars = 1,
                    DishId = dishes.Single(d => d.DishName == "Ice Cream").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    ReviewId = 16,
                    DishName = "Ice Cream",
                    GuestId = guests.Single(g => g.GuestId == 16).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 16).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 16).Name
                },
                new Review
                {
                    Text = "Nobody told the recipe developer that Americans don’t much like small, stale peas in their pasta",
                    Stars = 1,
                    DishId = dishes.Single(d => d.DishName == "Coffee").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Only Coffee").RestaurantId,
                    ReviewId = 17,
                    DishName = "Coffee",
                    GuestId = guests.Single(g => g.GuestId == 17).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 17).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 17).Name
                },
                new Review
                {
                    Text = "Nobody should pay this much money to be sad",
                    Stars = 2,
                    DishId = dishes.Single(d => d.DishName == "Sirloin Steak").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    ReviewId = 18,
                    DishName = "Sirloin Steak",
                    GuestId = guests.Single(g => g.GuestId == 18).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 18).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 18).Name
                },
                new Review
                {
                    Text = "McDonald’s does a better job for one-third of the price",
                    Stars = 1,
                    DishId = dishes.Single(d => d.DishName == "Bananasplit").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    ReviewId = 19,
                    DishName = "Bananasplit",
                    GuestId = guests.Single(g => g.GuestId == 19).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 19).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 19).Name
                },
                new Review
                {
                    Text = "I’m not so batty from Trump Derangement Syndrome that I can’t objectively identify what a poor value the food is at Nicolo's Pizza. The only thing Chicagoans on the ground are missing is the spectacular view from occupied territory",
                    Stars = 3,
                    DishId = dishes.Single(d => d.DishName == "Breadsticks").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    ReviewId = 20,
                    DishName = "Breadsticks",
                    GuestId = guests.Single(g => g.GuestId == 20).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 20).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 20).Name
                },
                new Review
                {
                    Text = "To put it mildly, licking Plexiglas is more rewarding than some of the duds on the set menu",
                    Stars = 2,
                    DishId = dishes.Single(d => d.DishName == "Breadsticks").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId,
                    //TableId = tabels.Single(t => t.TableId == 4).TableId,
                    ReviewId = 21,
                    DishName = "Breadsticks",
                    GuestId = guests.Single(g => g.GuestId == 21).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 21).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 21).Name
                },
                new Review
                {
                    Text = "I'll rather have my own banana split then eat this",
                    Stars = 2,
                    DishId = dishes.Single(d => d.DishName == "Bananasplit").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    ReviewId = 22,
                    DishName = "Bananasplit",
                    GuestId = guests.Single(g => g.GuestId == 14).GuestId,
                    DateOfVisit = guests.Single(g => g.GuestId == 14).DateOfVisit,
                    ReviewerName = guests.Single(n => n.GuestId == 14).Name
                },
};
            foreach (Review rw in reviews)
            {
                context.Reviews.Add(rw);
            }
            context.SaveChanges();

            var reviewGuests = new ReviewGuest[]
            {
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Anders Andersen").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 1).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Hanne Hansen").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 2).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Christiane Christiansen").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 3).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Charlotte Charlottenborg").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 4).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Rasmus Rasmussen").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 5).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Nicolai Nicolajsen").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 6).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Jesper Jespersen").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 7).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Mette Metz").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 8).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Anna Antonsen").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 9).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "A.S. Muncher").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 10).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Anita Dick").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 11).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Ben Derhover").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 12).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Dixon B. Tweenerlegs").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 13).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Dixon Butts").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 14).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Harry Nutt").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 15).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Ivana Fuccu").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 16).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Ivanna B. Spanked").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 17).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Mike Hunt").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 18).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Phil McAvity").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 19).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Wilma Dickfit").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 20).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Don Al Trum").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 21).ReviewId,
                },
                new ReviewGuest
                {
                    GuestId = guests.Single(g => g.Name == "Dixon Butts").GuestId,
                    ReviewId = reviews.Single(r => r.ReviewId == 22).ReviewId,
                },
            };
            foreach (ReviewGuest rg in reviewGuests)
            {
                context.ReviewGuests.Add(rg);
            }
            context.SaveChanges();
        }
    }
}