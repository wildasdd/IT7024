namespace wildasdd_it7024_final_introspect;

public partial class HomePage : ContentPage
{
	private readonly LocalDBService _dbService;
	
	
	public HomePage(LocalDBService dbService)
	{
		InitializeComponent();
		_dbService = dbService;
		
		
    }
	private async void Date_Selected(object sender, DateChangedEventArgs e)
	{
		var score = await _dbService.GetByDate(Date_Picker.Date);
		if (score != null)
		{
			LblScoreDate.Text = score.IntrospectScore.ToString();
		}
		else
		{
			LblScoreDate.Text = "No Score Submitted for day.";
		}
	}

	
	private async void Emotion_Clicked(object sender, EventArgs e)
	{
		DateTime date_selected = Date_Picker.Date;
		await Navigation.PushAsync(new EmotionInput(date_selected, _dbService));
	}
}