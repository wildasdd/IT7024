namespace wildasdd_it7024_final_introspect;

public partial class SelfInput : ContentPage
{
    int emotion_score;
    DateTime date_selected;
    private readonly LocalDBService _dbService;
    public SelfInput(int emotion_score, DateTime date_selected, LocalDBService dbService)
    { 
        InitializeComponent();
        this.emotion_score = emotion_score;
        this.date_selected = date_selected;
        _dbService = dbService;
	}
    private void Back_Self_Clicked(object sender, EventArgs e)
    {

        Navigation.PopAsync();
    }
    private async void Thought_Clicked( object sender, EventArgs e)
    {
        int Self1 = 0;
        int Self2 = 0;
        int Self3 = 0;
        int Self4 = 0;
        int Self_score = 0;

        if (Self1_StrongD.IsChecked == true) Self1 = 1;
        if (Self1_SomewhatD.IsChecked == true) Self1 = 2;
        if (Self1_Neutral.IsChecked == true) Self1 = 3;
        if (Self1_SomewhatA.IsChecked == true) Self1 = 4;
        if (Self1_StrongA.IsChecked == true) Self1 = 5;

        if (Self2_StrongD.IsChecked == true) Self2 = 1;
        if (Self2_SomewhatD.IsChecked == true) Self2 = 2;
        if (Self2_Neutral.IsChecked == true) Self2 = 3;
        if (Self2_SomewhatA.IsChecked == true) Self2 = 4;
        if (Self2_StrongA.IsChecked == true) Self2 = 5;

        if (Self3_StrongD.IsChecked == true) Self3 = 1;
        if (Self3_SomewhatD.IsChecked == true) Self3 = 2;
        if (Self3_Neutral.IsChecked == true) Self3 = 3;
        if (Self3_SomewhatA.IsChecked == true) Self3 = 4;
        if (Self3_StrongA.IsChecked == true) Self3 = 5;

        if (Self4_StrongD.IsChecked == true) Self4 = 1;
        if (Self4_SomewhatD.IsChecked == true) Self4 = 2;
        if (Self4_Neutral.IsChecked == true) Self4 = 3;
        if (Self4_SomewhatA.IsChecked == true) Self4 = 4;
        if (Self4_StrongA.IsChecked == true) Self4 = 5;
        Self_score = Self1 + Self2 + Self3 + Self4;
       
        await Navigation.PushAsync(new ThoughtInput( date_selected, emotion_score, Self_score, _dbService));
    }
}