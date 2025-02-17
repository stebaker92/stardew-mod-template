using StardewModdingAPI.Events;
using StardewModdingAPI;
using StardewValley;

namespace Stardew.ModTemplate
{
	/// <summary>The mod entry point.</summary>
	internal sealed class ModEntry : Mod
	{
		/// <summary>The mod entry point, called after the mod is first loaded.</summary>
		/// <param name="helper">Provides simplified APIs for writing mods.</param>
		public override void Entry(IModHelper helper)
		{
			helper.Events.Input.ButtonPressed += this.OnButtonPressed;
		}

		/// <summary>Raised after the player presses a button on the keyboard, controller, or mouse.</summary>
		/// <param name="sender">The event sender.</param>
		/// <param name="e">The event data.</param>
		private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
		{
			// print button presses to the console window
			this.Monitor.Log($"{Game1.player.Name} pressed {e.Button}.", LogLevel.Debug);
		}
	}

}
