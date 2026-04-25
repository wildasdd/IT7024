
namespace wildasdd_it7024_final_introspect;

public partial class Submission : ContentPage
{
    int introspection_score;
    private readonly LocalDBService _dbService;

    public Submission(int introspection_score, LocalDBService dbService)
    {

        InitializeComponent();
        this.introspection_score = introspection_score;
        LblResults.Text = introspection_score.ToString();
        _dbService = dbService;
    }

    private async void Submit_Home_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage(_dbService));

    } 
}