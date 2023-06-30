
                                     // Task.1
List<string> words = new List<string> { "apple", "banana", "orange", "grape", "mango" };
Console.WriteLine(words.OrderByDescending(w => w.Length).FirstOrDefault());

