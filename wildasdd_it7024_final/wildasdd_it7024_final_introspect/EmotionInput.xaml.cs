namespace wildasdd_it7024_final_introspect;

public partial class EmotionInput : ContentPage
{
    DateTime date_selected;
    private readonly LocalDBService _dbService;
    public EmotionInput(DateTime date_selected, LocalDBService dBService)
	{
        this.date_selected = date_selected;
		InitializeComponent();
        _dbService = dBService;
	}

    private void Emotion_Home_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
    private async void Self_Clicked(object sender, EventArgs e)
    {
        int emotion1 = 0;
        int emotion2 = 0;
        int emotion3 = 0;
        int emotion4 = 0;
        int emotion_score = 0;

        if (Emotion1_StrongD.IsChecked == true) emotion1 = 1;
        if (Emotion1_SomewhatD.IsChecked == true) emotion1 = 2;
        if (Emotion1_Neutral.IsChecked == true) emotion1 = 3;
        if (Emotion1_SomewhatA.IsChecked == true) emotion1 = 4;
        if (Emotion1_StrongA.IsChecked == true) emotion1 = 5;

        if (Emotion2_StrongD.IsChecked == true) emotion2 = 1;
        if (Emotion2_SomewhatD.IsChecked == true) emotion2 = 2;
        if (Emotion2_Neutral.IsChecked == true) emotion2 = 3;
        if (Emotion2_SomewhatA.IsChecked == true) emotion2 = 4;
        if (Emotion2_StrongA.IsChecked == true) emotion2 = 5;

        if (Emotion3_StrongD.IsChecked == true) emotion3 = 1;
        if (Emotion3_SomewhatD.IsChecked == true) emotion3 = 2;
        if (Emotion3_Neutral.IsChecked == true) emotion3 = 3;
        if (Emotion3_SomewhatA.IsChecked == true) emotion3 = 4;
        if (Emotion3_StrongA.IsChecked == true) emotion3 = 5;

        if (Emotion4_StrongD.IsChecked == true) emotion4 = 1;
        if (Emotion4_SomewhatD.IsChecked == true) emotion4 = 2;
        if (Emotion4_Neutral.IsChecked == true) emotion4 = 3;
        if (Emotion4_SomewhatA.IsChecked == true) emotion4 = 4;
        if (Emotion4_StrongA.IsChecked == true) emotion4 = 5;

        emotion_score = emotion1 + emotion2 + emotion3 + emotion4;

        await Navigation.PushAsync(new SelfInput(emotion_score, date_selected, _dbService));
    }
}