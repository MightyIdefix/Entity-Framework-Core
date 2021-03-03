using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using DAB_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using DAB_Assignment_2.RelationshipClasses;

namespace DAB_Assignment_2.Data
{
    class InsertData
    {
        public void InsertRestaurant(AppDbContext context)
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine(); 

            Console.WriteLine("Enter Type");
            string type = Console.ReadLine();

            Restaurant restaurant = new Restaurant()
            {
                    Name = name,
                    Address = address,
                    AverageRating = 0,
                    Type = type,
            };

            context.Add(restaurant);
            context.SaveChanges();
        }

        public void InsertReview(AppDbContext context)
        {
            Console.WriteLine("Enter your name");
            string nameOfReviewer = Console.ReadLine();

            Console.WriteLine("Enter name of dish");
            string dishName = Console.ReadLine();

            Console.WriteLine("Enter text for review");
            string text = Console.ReadLine();

            Console.WriteLine("Enter Stars");
            int stars = Convert.ToInt32(Console.ReadLine());

            Review review = new Review()
            {
                Text = text,
                Stars = stars,
                DishName = dishName,
                DateOfVisit = DateTime.Now,
                ReviewerName = nameOfReviewer,
            };

            context.Add(review);
            context.SaveChanges();
        }

    }
}
