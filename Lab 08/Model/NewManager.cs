using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08.Model
{
   public class NewManager

    {
        public static void GetNew(
            string category,
            ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewItems();

            var filteredNewsItems = allItems
                .Where(p => p.Category == category)
                .ToList();
            newsItems.Clear();
            filteredNewsItems.ForEach(p => newsItems.Add(p));
                }
        private static List<NewsItem> getNewItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Lorem ip" });
            items.Add(new NewsItem() { Id = 2, Category = "Financial", Headline = "Etiam ac" });
            items.Add(new NewsItem() { Id = 3, Category = "Financial", Headline = "Integer" });
            items.Add(new NewsItem() { Id = 4, Category = "Financial", Headline = "Proin ser" });
            items.Add(new NewsItem() { Id = 5, Category = "Financial", Headline = "Mauris" });


            items.Add(new NewsItem() { Id = 6, Category = "Food", Headline = "Lorem ip" });
            items.Add(new NewsItem() { Id = 7, Category = "Food", Headline = "Etiam ac" });
            items.Add(new NewsItem() { Id = 8, Category = "Food", Headline = "Integer" });
            items.Add(new NewsItem() { Id = 9, Category = "Food", Headline = "Proin ser" });
            items.Add(new NewsItem() { Id = 10, Category = "Food", Headline = "Mauris" });

            return items;
        }
    }
}
