using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAB_Assignment_2.Models;
using DAB_Assignment_2.RelationshipClasses;
using Microsoft.EntityFrameworkCore;

namespace DAB_Assignment_2.DAL
{
    public class Views
    {
        public void MethodA(string type, AppDbContext context)
        {
            foreach (var ting in context.Restaurants.Where(r => r.Type.Contains(type)))
            {
                var streng = context.Reviews.Where(r => r.RestaurantId == ting.RestaurantId).Select(r => r.Text).Take(5).AsNoTracking().ToList();
                Console.WriteLine($"{ting.Name} - Type: {ting.Type}");
                var rating =
                    from relevantRestaurant in context.Reviews
                    group relevantRestaurant by relevantRestaurant.RestaurantId into g
                    select new
                    {
                        g.Key,
                        arvgStar = g.Average(p => p.Stars)
                    };
                foreach (var rat in rating)
                {
                    if (ting.RestaurantId == rat.Key)
                    {
                        Console.Write("Average rating: {0:F1}\n", rat.arvgStar);
                    }
                }
                Console.WriteLine($"Latest five reviews: ");
                for (int i = 0; i < streng.Count; i++)
                {
                    Console.WriteLine($" \t Review {i + 1} {streng[i]}\n");
                }
            }
        }


        public void MethodB(string address, AppDbContext context)
        {
            foreach (var ting in context.Restaurants.Where(r => r.Address.Contains(address)))
            {
                Console.WriteLine("You have chosen the restaurant: ");
                Console.Write($"{ting.Name}\n");

                var rating1 =
                from relevantRestaurant in context.Reviews
                group relevantRestaurant by relevantRestaurant.RestaurantId into g
                select new
                {
                    g.Key,
                    arvgStar = g.Average(p => p.Stars)
                };
                foreach (var rat in rating1)
                {
                    if (ting.RestaurantId == rat.Key)
                    {
                        Console.Write("Average rating: {0:F1}\n", rat.arvgStar);
                    }
                }

                Console.WriteLine("The Menu consists of:");

                foreach (var dish in context.Dishes)
                {
                    foreach (var retDish in context.RestaurantDishes)
                    {
                        if (ting.RestaurantId == retDish.RestaurantId && dish.DishId == retDish.DishId)
                        {

                            Console.Write($"\t {dish.DishName} Price: {dish.Price}Kr");
                            var rating =
                                from relevantDish in context.Reviews
                                group relevantDish by relevantDish.DishId into g
                                select new
                                {
                                    g.Key,
                                    arvgStar = g.Average(p => p.Stars)
                                };

                            foreach (var rat in rating)
                            {
                                if (dish.DishId == rat.Key)
                                {
                                    Console.WriteLine("\n \t Rating: {0:F1}\n", rat.arvgStar);
                                }
                            }

                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public void MethodC(string address, AppDbContext context)
        {
            foreach (var rest in context.Restaurants.Where(r => r.Address.StartsWith(address)))
            {
                Console.WriteLine("You have chosen the restaurant: ");
                Console.WriteLine($"\n{rest.Name}");

                foreach (var table in context.Tables)
                {
                    if (table.RestaurantId == rest.RestaurantId)
                    {
                        Console.WriteLine($"Bord nr. {table.TableId}: ");
                        foreach (var review in context.Reviews)
                        {

                            foreach (var guest in context.Guests)
                            {
                                if (guest.Name == review.ReviewerName && review.RestaurantId == rest.RestaurantId && guest.TableId == table.TableId)
                                {
                                    Console.WriteLine($"Review by {review.ReviewerName} \nFor dish: {review.DishName} - Stars: {review.Stars} \n{review.Text} \n");
                                }
                            }

                        }
                    }

                }
            }
        }
    }
}
