using System.Collections.ObjectModel;
using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Baclground.MVVM.Models;

namespace Baclground.MVVM.ViewModels;

public partial class DashboardViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<CategoryModel> categories = new();

    public DashboardViewModel()
    {
        LoadFromJson();
    }

    private void LoadFromJson()
    {
        // Make sure dashboard.json is marked as Content + Copy if newer
        var json = File.ReadAllText("dashboard.json");
        var model = JsonSerializer.Deserialize<DashboardModel>(json);
        if (model != null)
            Categories = model.Categories;
    }

    [RelayCommand]
    public void AddWidget(CategoryModel category)
    {
        category.Widgets.Add(new WidgetModel
        {
            Id = Guid.NewGuid().ToString(),
            Title = "New Widget",
            Text = "Random Text"
        });
    }

    [RelayCommand]
    public void RemoveWidget(WidgetModel widget)
    {
        var category = Categories.FirstOrDefault(c => c.Widgets.Contains(widget));
        if (category != null)
        {
            category.Widgets.Remove(widget);
        }
    }
}
