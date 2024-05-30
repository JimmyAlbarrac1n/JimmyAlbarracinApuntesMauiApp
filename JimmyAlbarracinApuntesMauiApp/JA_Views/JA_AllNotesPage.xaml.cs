namespace JimmyAlbarracinApuntesMauiApp.JA_Views;

public partial class JA_AllNotesPage : ContentPage
{
	public JA_AllNotesPage()
	{
		InitializeComponent();
        BindingContext = new JA_Models.JA_AllNotes();
    }

    protected override void OnAppearing()
    {
        ((JA_Models.JA_AllNotes)BindingContext).LoadNotes();
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(JA_NotePage));
    }

    private async void notesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the note model
            var note = (JA_Models.JA_Note)e.CurrentSelection[0];

            // Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
            await Shell.Current.GoToAsync($"{nameof(JA_NotePage)}?{nameof(JA_NotePage.ItemId)}={note.Filename}");

            // Unselect the UI
            notesCollection.SelectedItem = null;
        }
    }
}