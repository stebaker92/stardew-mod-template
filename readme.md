# Stardew Valley Mod Template

A template for Stardew Valley mods using SMAPI v4

## Usage
- Set the mod name & author in `manifest.json`
- Add your mods logic to the `Entry` function within the `ModEntry` class
- Update the `GamePath` property within `Stardew.ModTemplate.csproj`

## Publishing mods
- Set the version in `manifest.json`
- Build the project via Visual Studio or the dotnet CLI
- Find the generated `.zip` file located in the `bin/Debug/` directory
- Upload the zip file to the Nexus portal
- Done!


## Resources

See the Stardew Valley wiki for SMAPI usage:

https://stardewvalleywiki.com/Modding:Index#Creating_mods
