using API.Entities;

namespace API.Data;

public static class DbInitializer
{
  public static void Initialize(StoreContext context)
  {
    if (context.Products.Any()) return;

    var products = new List<Product>
        {
            new Product
            {
                Name = "Angular Speedster Board 2000",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 20000,
                PictureUrl = "http://picsum.photos/200?random=1",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Green Angular Board 3000",
                Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                Price = 15000,
                PictureUrl = "http://picsum.photos/200?random=2",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Core Board Speed Rush 3",
                Description =
                    "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 18000,
                PictureUrl = "http://picsum.photos/200?random=3",
                Brand = "NetCore",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Net Core Super Board",
                Description =
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                Price = 30000,
                PictureUrl = "http://picsum.photos/200?random=4",
                Brand = "NetCore",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "React Board Super Whizzy Fast",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 25000,
                PictureUrl = "http://picsum.photos/200?random=5",
                Brand = "React",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Typescript Entry Board",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 12000,
                PictureUrl = "http://picsum.photos/200?random=6",
                Brand = "TypeScript",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Core Blue Hat",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1000,
                PictureUrl = "http://picsum.photos/200?random=7",
                Brand = "NetCore",
                Type = "Hats",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Green React Woolen Hat",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 8000,
                PictureUrl = "http://picsum.photos/200?random=8",
                Brand = "React",
                Type = "Hats",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Purple React Woolen Hat",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1500,
                PictureUrl = "http://picsum.photos/200?random=9",
                Brand = "React",
                Type = "Hats",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Blue Code Gloves",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1800,
                PictureUrl = "http://picsum.photos/200?random=10",
                Brand = "VS Code",
                Type = "Gloves",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Green Code Gloves",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1500,
                PictureUrl = "http://picsum.photos/200?random=11",
                Brand = "VS Code",
                Type = "Gloves",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Purple React Gloves",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1600,
                PictureUrl = "http://picsum.photos/200?random=12",
                Brand = "React",
                Type = "Gloves",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Green React Gloves",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1400,
                PictureUrl = "http://picsum.photos/200?random=13",
                Brand = "React",
                Type = "Gloves",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Redis Red Boots",
                Description =
                    "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 25000,
                PictureUrl = "http://picsum.photos/200?random=14",
                Brand = "Redis",
                Type = "Boots",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Core Red Boots",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 18999,
                PictureUrl = "http://picsum.photos/200?random=15",
                Brand = "NetCore",
                Type = "Boots",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Core Purple Boots",
                Description =
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                Price = 19999,
                PictureUrl = "http://picsum.photos/200?random=16",
                Brand = "NetCore",
                Type = "Boots",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Angular Purple Boots",
                Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                Price = 15000,
                PictureUrl = "http://picsum.photos/200?random=17",
                Brand = "Angular",
                Type = "Boots",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Angular Blue Boots",
                Description =
                    "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 18000,
                PictureUrl = "http://picsum.photos/200?random=18",
                Brand = "Angular",
                Type = "Boots",
                QuantityInStock = 100
            },
        };

    foreach (var product in products)
    {
      context.Products.Add(product);
    }

    context.SaveChanges();
  }
}
