using Avalonia.Controls;

namespace RecreateMarkdownRenderErrors.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MarkdownViewer.Markdown = "Test";
    }
}
