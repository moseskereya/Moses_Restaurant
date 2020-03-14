using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Restaurant.Models;

namespace Restaurant.Dal
{
    public class RestaurantInitializer : DropCreateDatabaseIfModelChanges<RestaurantContext>
    {
        protected override void Seed(RestaurantContext context)
        {
            var categories = new Category
            {
                   Name = "Cheese Cakes",
                   Description = "Cheesy all the way" 
            };

            var pies = new List<Pie>
            {
                   /*Pies*/
                new Pie
                {
                    Name = "Pecan Pie",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 29.39M,
                    ImgUrl = "https://img.grouponcdn.com/seocms/wTfQHKzEZLUy5KECEoSvRugcxqx/671x671_Pecan_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = " Pecans, corn syrup (or brown sugar, or both); considered a southern dish, but you’ll find it anywhere you find pies; especially popular as a dessert during Thanksgiving or Christmas; the pumpkin pie is its heated rival.",
                    ThumNail = "https://img.grouponcdn.com/seocms/wTfQHKzEZLUy5KECEoSvRugcxqx/671x671_Pecan_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },

                  new Pie
                {
                    Name = "Apple Pie",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 34.39M,

                    ImgUrl = "https://img.grouponcdn.com/seocms/2i7116adj14eoCiYBx8SQLUzXZrq/671x671_Apple_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = " Apples, sugar, and cinnamon, often served with vanilla ice cream on the side; as the Great American Pie, it’s sometimes grouped with baseball and hot dogs as a purely American symbol (though the English and the Dutch have been making pies with apples for centuries)",
                    ThumNail = "https://img.grouponcdn.com/seocms/2i7116adj14eoCiYBx8SQLUzXZrq/671x671_Apple_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },

                    new Pie
                {
                    Name = "Pecan Pie",
                    Price = 39.6M,

                    Category = categories,
                    Description = "Lorem Ipsum",
                    ImgUrl = "https://img.grouponcdn.com/seocms/3FNe2BxwrZMZrxP2GujcD6yjP69f/671x671_Pumpkin_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "Pumpkin-flavored custard, ginger, nutmeg; it’s a Thanksgiving classic, in part because you can use your leftover Halloween jack-o-lantern for its stuffing; the pecan pie is its heated",
                    ThumNail = "https://img.grouponcdn.com/seocms/3FNe2BxwrZMZrxP2GujcD6yjP69f/671x671_Pumpkin_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },


                new Pie
                {
                    Name = "Key Lime Pie",
                    Category = categories,
                    Price = 40.9M,
                    Description = "Lorem Ipsum",
                    ImgUrl = "https://img.grouponcdn.com/seocms/MAEqSGQhwmuZ7RsUXWdKF49prF9/671x671_Key_Lime_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "Lime juice (specifically one from a Key lime), meringue topping, and graham-cracker crust; naturally, the pie is heavily associate with the Florida Keys, and Key West holds a festival for the pie every 4th of July Weekend.",
                    ThumNail = "https://img.grouponcdn.com/seocms/MAEqSGQhwmuZ7RsUXWdKF49prF9/671x671_Key_Lime_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },

                new Pie

                {
                    Name = "Cherry Pie",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 42.94M,
                    ImgUrl = "https://img.grouponcdn.com/seocms/3K8rjwNK22DKVDZ3u4w7jHiGQpxJ/671x671_Cherry_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "Cherries, namely Montmorency cherries, which are tarter and more sour than your usual Bing cherry; a favorite during the 4th of July; namesake of the 1990 chart-topping hit from glam-rockers Warrant.",
                    ThumNail = "https://img.grouponcdn.com/seocms/3K8rjwNK22DKVDZ3u4w7jHiGQpxJ/671x671_Cherry_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },

                   new Pie
                {
                    Name = "Lemon Meringue Pie",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 100.49M,
                    ImgUrl = "https://img.grouponcdn.com/seocms/2mDcvU9LW2DbBuzT1nnTJ1Php6ag/671x671_Lemon_Meringue_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "Lemon custard with a meringue topping; this is that pie with the puffy, enlarged top that looks so soft and inviting, you kinda want to use it as a pillow; it’s also grandma’s favorite pie, often",
                    ThumNail = "https://img.grouponcdn.com/seocms/2mDcvU9LW2DbBuzT1nnTJ1Php6ag/671x671_Lemon_Meringue_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },

                 new Pie
                {
                    Name = "Cheesecake",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 49.92M,
                    ImgUrl = "https://img.grouponcdn.com/seocms/2nfr9xWRPv7VhgDzBQRqe2k5fWkK/671x671_Cheesecake_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "First off—yes, this is a pie, since it uses a graham-cracker crust that’s synonymous with pies. The other main ingredient is cream cheese or ricotta, which can be combined with myriad other flavors (mocha, Oreos, peanut butter, etc.)",
                    ThumNail = "https://img.grouponcdn.com/seocms/2nfr9xWRPv7VhgDzBQRqe2k5fWkK/671x671_Cheesecake_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },


                new Pie
                {
                    Name = "Rhubarb Pie",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 39.92M,

                    ImgUrl = "https://img.grouponcdn.com/seocms/3bMub5EFvv4UxLpZTuTYLaCi8Wea/671x671_Rhubarb_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "A whole lot of rhubarb, often paired with strawberries; one of the tartest pie flavors; a tempting treat for anyone on the “rhubarb diet” (yes, this is real).",
                    ThumNail = "https://img.grouponcdn.com/seocms/3bMub5EFvv4UxLpZTuTYLaCi8Wea/671x671_Rhubarb_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },

                new Pie

                {
                    Name = "Mixed Berry Pie",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 81.82M,

                    ImgUrl = "https://img.grouponcdn.com/seocms/2KSvzYyUjCiZnzSZmSEfcNVbpMDx/671x671_Mixed_Berry_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "A little bit of this, a little bit of that; these pies usually include two or three of the following: blueberries, raspberries, blackberries, strawberries; if you’re in the upper Atlantic Canadian provinces, this might be called a “bumbleberry pie,” which is just delightful, isn’t it?",
                    ThumNail = "https://img.grouponcdn.com/seocms/2KSvzYyUjCiZnzSZmSEfcNVbpMDx/671x671_Mixed_Berry_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },

                   new Pie
                {
                    Name = "Banoffee",
                    Category = categories,
                    Price = 29.0M,
                    Description = "Lorem Ipsum",
                    ImgUrl = "https://img.grouponcdn.com/seocms/2jdqtMMd7QGtqi7evED339iEmNrs/671x671_Banoffee_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "An almost exclusively English pie, Banoffee is one of the best-known versions of the banana cream pie; bananas and toffee are its two must-have ingredients (the name Banoffee is a combo of the two), but you might also find a good heaping of dulce de leche.  ",
                    ThumNail = "https://img.grouponcdn.com/seocms/2jdqtMMd7QGtqi7evED339iEmNrs/671x671_Banoffee_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },

                 new Pie
                {
                    Name = "French Silk Pie",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 30.36M,
                    ImgUrl = "https://img.grouponcdn.com/seocms/W7UMCtWuaC48JXawXhMTeY4rxgJ/671x671_French_Silk_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "It’s the chocolate pie: chocolate mousse, whipped cream, and bittersweet chocolate shavings; favorite pie of children at family reunions everywhere; despite its name, French Silk is a purely American invention, the winner of a 1951 Pillsbury competition.",
                    ThumNail = "https://img.grouponcdn.com/seocms/W7UMCtWuaC48JXawXhMTeY4rxgJ/671x671_French_Silk_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },


                new Pie
                {
                    Name = "Blueberry Pie",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 65.40M,
                    ImgUrl = "https://img.grouponcdn.com/seocms/npUsbmUGMRWZJBX93gCeubkekDj/671x671_Blueberry_PieBUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "The best blueberries you can find, plus cinnamon; official state dessert of Maine, but don’t sleep on blueberry pies from Michigan, Washington, Maryland, and Oregon—all high blueberry-producing states.",
                    ThumNail = "https://img.grouponcdn.com/seocms/npUsbmUGMRWZJBX93gCeubkekDj/671x671_Blueberry_PieBUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },

                new Pie

                {
                    Name = "Strawberry Pie",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 61.60M,

                    ImgUrl = "https://img.grouponcdn.com/seocms/pdRmvrk1DKLgKZK1p8kDrDNVZ4R/671x671_Strawberry_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_V2_jpg-671x671",
                    LongDescription = "Strawberries. Lots and lots and lots of strawberries (ideally fresh strawberries), often mixed with a strawberry gelatin. We recommend some whipped cream on top to cut some of the sweetness.",
                    ThumNail = "https://img.grouponcdn.com/seocms/pdRmvrk1DKLgKZK1p8kDrDNVZ4R/671x671_Strawberry_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_V2_jpg-671x671"
                },

                   new Pie
                {
                    Name = "Pecan Pie",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 62.70M,

                    ImgUrl = "https://img.grouponcdn.com/seocms/39wuSffRhMq7iood1y7Mn2DEx3yu/671x671_Coconut_Cream_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "The king of cream pies, it’s a messy conglomeration of coconut custard, whipped cream, and toasted coconut flakes; eat this and imagine you’re on some deserted tropical island with rows of coconut trees (and somehow you have access to pie-making supplies).",
                    ThumNail = "https://img.grouponcdn.com/seocms/39wuSffRhMq7iood1y7Mn2DEx3yu/671x671_Coconut_Cream_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },

                 new Pie
                {
                    Name = "Blackberry Pie",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 85.32M,

                    ImgUrl = "https://img.grouponcdn.com/seocms/2pQW6MPWdbFWnDkiaW8FoJNQXWQZ/671x671_Blackberry_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "",
                    ThumNail = "https://img.grouponcdn.com/seocms/2pQW6MPWdbFWnDkiaW8FoJNQXWQZ/671x671_Blackberry_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },


                new Pie
                {
                    Name = "Peach Pie",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 65.320M,

                    ImgUrl = "https://img.grouponcdn.com/seocms/4FmP5ZxL3yv9befZEwwPWQy789DR/671x671_Peach_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "Peaches, plus a sprinkling of nutmeg or cinnamon; it’s especially popular in peach-producing regions, like Georgia; some take their love of peach pie to the next level and create “peace pie moonshine” out of peach schnapps and grain alcohol.",
                    ThumNail ="https://img.grouponcdn.com/seocms/4FmP5ZxL3yv9befZEwwPWQy789DR/671x671_Peach_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },

                new Pie
                {
                    Name = "Pot Pie",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 60.45M,

                    ImgUrl = "https://img.grouponcdn.com/seocms/2skWA5yM6c8fQyqxrbC664hJm9A8/pot_pie_jpeg-671x671",
                    LongDescription = "The ultimate savory pie; gravy meets chicken, beef, or lamb (plus veggies), tucked inside a pie crust and served steaming hot; second only to chicken-noodle soup for best dishes to enjoy on a cold winter’s day, ideally from inside a log cabin while seated next to a roaring fire.",
                    ThumNail = "https://img.grouponcdn.com/seocms/2skWA5yM6c8fQyqxrbC664hJm9A8/pot_pie_jpeg-671x671"
                },

                   new Pie
                {
                    Name = "Sweet Potato Pie",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 75.43M,

                    ImgUrl = "https://img.grouponcdn.com/seocms/3xoCQpoQkEbKbHjNpH5vTgPHK7np/671x671_Sweet_Potato_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "Sweet potato filling, often with a dollop of whipped cream on top, sometimes topped with a layer of marshmallows instead; a staple of Southern soul food, especially during the holidays.  ",
                    ThumNail = "https://img.grouponcdn.com/seocms/3xoCQpoQkEbKbHjNpH5vTgPHK7np/671x671_Sweet_Potato_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },

                 new Pie
                {
                    Name = "Sugar Cream Pie",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 45.45M,
                    ImgUrl = "https://img.grouponcdn.com/seocms/4UjJMhDwFBf9NzG3ubfXoxs8PKne/671x671_Sugar_Cream_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "Brown sugar, butter, and cream; a simple treat, but one of the most addictive types of pies; popular in French and Quebecois cuisines, as well as the Midwest USA, where it is also called “Hoosier Pie” due to its association with Indiana.",
                    ThumNail = "https://img.grouponcdn.com/seocms/4UjJMhDwFBf9NzG3ubfXoxs8PKne/671x671_Sugar_Cream_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                 },
             
                 new Pie
                {
                    Name = "Apple Crumble",
                    Category = categories,
                    Description = "Lorem Ipsum",
                    Price = 65.50M,

                    ImgUrl = "https://img.grouponcdn.com/seocms/3zay8r1nSz4Fun8X2vyywvcMVFn4/671x671_Mississippi_Mud_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    LongDescription = "Chocolate filling, chocolate sauce drizzled on top, and—in case that wasn’t enough chocolate—a chocolate graham-cracker crust; it’s usually infused with other flavors (think coffee liqueur or butterscotch); as you might imagine, it’s a favorite in Mississippi.",
                    ThumNail = "https://img.grouponcdn.com/seocms/3zay8r1nSz4Fun8X2vyywvcMVFn4/671x671_Mississippi_Mud_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                },

                 new Pie
                 {
                     Name = "Mississippi Mud Pie",
                     Category = categories,
                     Description = "Lorem Ipsum",
                     Price = 77.77M,
                     ImgUrl = "https://images.pexels.com/photos/3859921/pexels-photo-3859921.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                     LongDescription = "Chocolate filling, chocolate sauce drizzled on top, and—in case that wasn’t enough chocolate—a chocolate graham-cracker crust; it’s usually infused with other flavors (think coffee liqueur or butterscotch); as you might imagine, it’s a favorite in Mississippi.",
                     ThumNail = "https://images.pexels.com/photos/3859921/pexels-photo-3859921.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"

                 }
               /*  end   of pies */
            };


            pies.ForEach(m => context.Pies.Add(m));

            context.SaveChanges();
        }
    }

}