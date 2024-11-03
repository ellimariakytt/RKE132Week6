string[] snacks = { "sushi", "pizza", "burger", "fries", "salad" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);


Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");