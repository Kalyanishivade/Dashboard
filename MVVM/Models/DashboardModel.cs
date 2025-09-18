using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baclground.MVVM.Models
{
    
        public class WidgetModel
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string Text { get; set; }
        }

        public class CategoryModel
        {
            public string Name { get; set; }
            public ObservableCollection<WidgetModel> Widgets { get; set; } = new();
        }

        public class DashboardModel
        {
            public ObservableCollection<CategoryModel> Categories { get; set; } = new();
        }
    }
