namespace wildasdd_it7024_final_introspect;

public partial class ThoughtInput : ContentPage
{
    DateTime date_selected;
    int emotion_score;
    int Self_score;
    private readonly LocalDBService _dbService;
    private int _editScoreDate;
    public ThoughtInput(DateTime date_selected, int emotion_score, int Self_score, LocalDBService dbService)
	{
		InitializeComponent();
        this.date_selected = date_selected;
        this.emotion_score = emotion_score;
        this.Self_score = Self_score;
        _dbService = dbService;
	}

    private void Back_Thought_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
    private async void Submit_Scores_Clicked(object sender, EventArgs e)
    {
        try
        {
            int Thought1 = 0;
            int Thought2 = 0;
            int Thought3 = 0;
            int Thought4 = 0;
            int Thought_score = 0;
            int introspect_score = 0;

            if (Thought1_StrongD.IsChecked == true) Thought1 = 1;
            if (Thought1_SomewhatD.IsChecked == true) Thought1 = 2;
            if (Thought1_Neutral.IsChecked == true) Thought1 = 3;
            if (Thought1_SomewhatA.IsChecked == true) Thought1 = 4;
            if (Thought1_StrongA.IsChecked == true) Thought1 = 5;

            if (Thought2_StrongD.IsChecked == true) Thought2 = 1;
            if (Thought2_SomewhatD.IsChecked == true) Thought2 = 2;
            if (Thought2_Neutral.IsChecked == true) Thought2 = 3;
            if (Thought2_SomewhatA.IsChecked == true) Thought2 = 4;
            if (Thought2_StrongA.IsChecked == true) Thought2 = 5;

            if (Thought3_StrongD.IsChecked == true) Thought3 = 1;
            if (Thought3_SomewhatD.IsChecked == true) Thought3 = 2;
            if (Thought3_Neutral.IsChecked == true) Thought3 = 3;
            if (Thought3_SomewhatA.IsChecked == true) Thought3 = 4;
            if (Thought3_StrongA.IsChecked == true) Thought3 = 5;

            if (Thought4_StrongD.IsChecked == true) Thought4 = 1;
            if (Thought4_SomewhatD.IsChecked == true) Thought4 = 2;
            if (Thought4_Neutral.IsChecked == true) Thought4 = 3;
            if (Thought4_SomewhatA.IsChecked == true) Thought4 = 4;
            if (Thought4_StrongA.IsChecked == true) Thought4 = 5;

            Thought_score = Thought1 + Thought2 + Thought3 + Thought4;
            introspect_score = emotion_score + Self_score + Thought_score;

            var score = await _dbService.GetByDate(date_selected.Date);
            if (score != null)
            {
                await _dbService.Update(new Scores
                {
                    InputDate = date_selected.Date,
                    EmotionScore = emotion_score,
                    SelfScore = Self_score,
                    ThoughtScore = Thought_score,
                    IntrospectScore = introspect_score

                });

            }
            else
            {
                await _dbService.Create(new Scores
                {
                    InputDate = date_selected.Date,
                    EmotionScore = emotion_score,
                    SelfScore = Self_score,
                    ThoughtScore = Thought_score,
                    IntrospectScore = introspect_score

                });
            }
            await Navigation.PushAsync(new Submission(introspect_score, _dbService));
        }
        catch (Exception ex) {
            await DisplayAlert("error", ex.Message + "\n" + ex.StackTrace, "OK");
        }
    }
}