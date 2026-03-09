using NewsApplication.Models;
using NewsApplication.Services;
using System.Threading.Tasks;

namespace NewsApplication.Pages;

public partial class NewsListPage : ContentPage
{
    public List<Article> ArticleList;
    public List<Category> CategoryList;
    
    public string selectedCategory;
    public NewsListPage(Category selectedCategory)
    {   
        InitializeComponent();
        var selected = selectedCategory.Name as string;
        GetCategoryNews(selected);
        ArticleList = new List<Article>();
        CategoryList = new List<Category>();

    }

    private async Task GetCategoryNews(string selectedCategory)
    { 
        var apiService = new ApiService();
        var newsResult = await apiService.GetNews(selectedCategory);
        foreach (var article in newsResult.Articles)
        {
            ArticleList.Add(article);
        }
        CategoryNews.ItemsSource = ArticleList;
    }
    private void Home_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
    private void SelectedArticle(object sender, SelectedItemChangedEventArgs e)
    {
        var selectedArticle = e.SelectedItem as Article;
        if (selectedArticle == null) return;
        Navigation.PushAsync(new NewsDetailPage(selectedArticle));
    }


}