using SimpleTurnSystem;

namespace TurnPlayground;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
	private readonly ITurnManager _turnManager;

	public MainWindow()
	{
		InitializeComponent();
		_turnManager = TurnManager.Create();
		_turnManager.Hello();
	}

	protected override void OnClosed(EventArgs e)
	{
		base.OnClosed(e);
		_turnManager.Dispose();
	}
}