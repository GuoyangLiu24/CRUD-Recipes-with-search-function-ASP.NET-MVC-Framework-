using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Recipes.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                    new Recipe
                    {
                        
                        Name = "Açaí Bowl",
                        MainIngredients = "Banana,Blueberries",
                        Ingredients = "3 (3.5-ounce) frozen açaí packs,2 medium bananas,1 c. frozen blueberries,1 1/2 c. almond milk,Pinch of kosher salt",
                        Steps = "Combine frozen açaí with bananas, blueberries, almond milk, and salt in a blender.Blend until smooth then divide evenly between two bowls.Top with fresh fruit and coconut topping. ",
                        Yields = 2,
                        Minutes = 15
                    },
                    new Recipe
                    {

                    Name = "Strawberry Smoothie",
                        MainIngredients = "strawberries, avocado",
                        Ingredients = "160g ripe strawberries,160g baby spinach,1 small avocado",
                        Steps = "Put all the ingredients in a blender,drop of chilled water then blitz again,Pour the mixture into two glasses to serve.",
                        Yields = 2,
                        Minutes = 5
                    },
                    new Recipe
                    {

                        Name = "Breakfast smoothie",
                        MainIngredients = "Banana",
                        Ingredients = "1 banana,1 tbsp porridge oats,80g soft fruit,150ml milk",
                        Steps = "Put all the ingredients in a blender and whizz for 1 min until smooth.",
                        Yields = 2,
                        Minutes = 5
                    },
                    new Recipe
                    {

                        Name = "Sunshine smoothie",
                        MainIngredients = "carrot",
                        Ingredients = "500ml carrot juice,200g pineapple,2 bananas",
                        Steps = "Put the ingredients in a blender and whizz until smooth. Drink straight away or pour into a bottle to drink on the go",
                        Yields = 2,
                        Minutes = 5
                    },
                    new Recipe
                    {

                        Name = "Kale smoothie",
                        MainIngredients = "carrot",
                        Ingredients = "2 handfuls kale,½ avocado,½ lime,1 tbsp cashew nuts",
                        Steps = "Put all of the ingredients into a bullet or smoothie maker, add a large splash of water and blitz. Add more water until you have the desired consistency.",
                        Yields = 2,
                        Minutes = 5
                    },
                    new Recipe
                    {

                        Name = "Coconut & banana smoothie",
                        MainIngredients = "carrot",
                        Ingredients = "100g coconut yogurt,3 tbsp milk,2 tsp baobab powder,1 small ripe banana",
                        Steps = "Add the coconut yogurt and milk to a high-speed blender then add the turmeric, fresh ginger and baobab powder",
                        Yields = 2,
                        Minutes = 5
                    },
                    new Recipe
                    {

                        Name = "Turmeric smoothie bowl",
                        MainIngredients = "turmeric",
                        Ingredients = "10cm/4in fresh turmeric,3 tbsp coconut milk yogurt,2 bananas",
                        Steps = "Peel the turmeric root, if using, and grate. Put all ingredients in a blender with 600ml water and blend until smooth.",
                        Yields = 2,
                        Minutes = 5
                    },
                    new Recipe
                    {

                        Name = "Cantaloupe Breakfast Bowls",
                        MainIngredients = "Raspberries",
                        Ingredients = "1 cantaloupe, halved,1 1/2 c. almond milk,1 c. frozen raspberries,1 banana, sliced into coin,1/2 c. frozen pineapple",
                        Steps = " Using a spoon, remove and discard seeds from cantaloupe. Use a spoon to widen hole in the center, leaving a 1 border at the edges. Pour smoothie into cantaloupe bowls and garnish with raspberries, granola.",
                        Yields = 2,
                        Minutes = 20
                    },
                    new Recipe
                    {

                        Name = "Green breakfast smoothie",
                        MainIngredients = "Spinach",
                        Ingredients = "1 handful spinach,100g broccoli floret,1 banana",
                        Steps = " Whizz 300ml water and the ingredients in a blender until smooth",
                        Yields = 2,
                        Minutes = 20
                    },
                    new Recipe
                    {

                        Name = "Vegan smoothie",
                        MainIngredients = "Spinach",
                        Ingredients = "100ml (¼ tall glass) cherry,1 cherry soya yogurt,2 tbsp porridge oat",
                        Steps = " Measure all the ingredients exactly or use a tall glass and your empty yogurt pot for speed",
                        Yields = 2,
                        Minutes = 20
                    },
                    new Recipe
                    {

                        Name = "Creamy mango & coconut smoothie",
                        MainIngredients = "Mango, coconut",
                        Ingredients = "200ml (½ tall glass) coconut milk,1 banana",
                        Steps = " Measure all the ingredients or use a tall glass for speed – they don’t have to be exact. Put them into a blender and blitz until smooth.",
                        Yields = 2,
                        Minutes = 20
                    },
                new Recipe
                {

                    Name = "Elise's Green Smoothie Bowl",
                    MainIngredients = "Green tea",
                    Ingredients = "½ cup almond milk,1 banana frozen,1 Medjool date pitted,1 tablespoon almond butter",
                    Steps = "Combine all of the ingredients in a blender (I used my Vitamix).Blend until smooth + garnish with freeze-dried bananas, flax seeds, almond butter, berries of choice."
                         ,
                    Yields = 1,
                    Minutes = 10
                },
                new Recipe
                {

                    Name = "Vanilla Chai Superfood Smoothie Bowl",
                    MainIngredients = "Vanilla",
                    Ingredients = "½ cup almond milk,1 banana frozen,1 Medjool date pitted,1 tablespoon almond butter",
                    Steps = "Combine all of the ingredients in a blender (I used my Vitamix).Blend until smooth + garnish with freeze-dried bananas, flax seeds, almond butter, berries of choice."
                         ,
                    Yields = 1,
                    Minutes = 10
                },
                new Recipe
                {

                    Name = "Detox Protein Smoothie Bowl",
                    MainIngredients = "Protein",
                    Ingredients = "½ cup almond milk,1 banana frozen,1 Medjool date pitted,1 tablespoon almond butter",
                    Steps = "Combine all of the ingredients in a blender (I used my Vitamix).Blend until smooth + garnish with freeze-dried bananas, flax seeds, almond butter, berries of choice."
                         ,
                    Yields = 1,
                    Minutes = 10
                },
                new Recipe
                {

                    Name = "Carrot Oatmeal Smoothie Bowl",
                    MainIngredients = "Carrot",
                    Ingredients = "½ cup almond milk,1 banana frozen,1 Medjool date pitted,1 tablespoon almond butter",
                    Steps = "Combine all of the ingredients in a blender (I used my Vitamix).Blend until smooth + garnish with freeze-dried bananas, flax seeds, almond butter, berries of choice."
                         ,
                    Yields = 1,
                    Minutes = 10
                },
                new Recipe
                {

                    Name = "Dark Chocolate Peanut Butter Smoothie Bowl",
                    MainIngredients = "Chocolate, Peanut",
                    Ingredients = "½ cup almond milk,1 banana frozen,1 Medjool date pitted,1 tablespoon almond butter",
                    Steps = "Combine all of the ingredients in a blender (I used my Vitamix).Blend until smooth + garnish with freeze-dried bananas, flax seeds, almond butter, berries of choice."
                         ,
                    Yields = 1,
                    Minutes = 10
                }
                );


                context.SaveChanges();

            }
        }
    }
}
