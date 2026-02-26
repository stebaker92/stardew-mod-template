using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace Stardew.ModTemplate;

/// <summary>The mod entry point.</summary>
internal sealed class ModEntry : Mod
{
	/// <summary>The mod entry point, called after the mod is first loaded.</summary>
	public override void Entry(IModHelper helper)
	{
		helper.Events.Input.ButtonPressed += this.OnButtonPressed;
	}

	/// <summary>Raised after the player presses a button on the keyboard, controller, or mouse.</summary>
	private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
	{
		// Load a translation string from the i18n folder and show it in a HUD message
		var msg = Helper.Translation.Get("Message.Debug", new { name = Game1.player.Name, button = e.Button });

		// print button presses to the console window
		this.Monitor.Log(msg, LogLevel.Debug);
	}
}
