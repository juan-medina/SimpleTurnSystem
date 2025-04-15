using SimpleTurnSystem;

namespace TurnPlayground;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        var turnManager = new TurnManager();
        turnManager.Hello();
    }
}