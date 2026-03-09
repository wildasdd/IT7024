using NewsApplication.Services;
using NewsApplication.Models;
using System.Threading.Tasks;

namespace NewsApplication.Pages;

public partial class NewsDetailPage : ContentPage
{
    public List<Article> ArticleList;
    public NewsDetailPage(Article selectedArticle)
    {
        InitializeComponent();
        ArticleTitle.Text = selectedArticle.Title;
        ArticleContent.Text = selectedArticle.Content;
        ArticleImage.Source = selectedArticle.Image;
    }
    private void Back_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}