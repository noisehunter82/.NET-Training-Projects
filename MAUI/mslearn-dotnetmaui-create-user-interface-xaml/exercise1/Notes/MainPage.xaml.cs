namespace Notes;

public partial class MainPage : ContentPage
{
    private readonly string _fileName = Path.Combine(FileSystem.Current.AppDataDirectory, "notes.txt");

    public MainPage()
    {
        InitializeComponent();

        editor.Text = File.Exists(_fileName) ? File.ReadAllText(_fileName) : string.Empty;
    }

    private void OnSaveButtonClicked(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, editor.Text);
        Console.WriteLine(_fileName);
    }

    private void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        if (File.Exists(_fileName))
        {
            File.Delete(_fileName);
        }
        editor.Text = string.Empty;
    }
}

