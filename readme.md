# Stardew Valley Mod Template

A template for Stardew Valley mods using SMAPI v3

## Usage
- Set your namespace in `SMAPI.Template.csproj` 
- Set your mods name and entrypoint in `manifest.json`
- Add your mods logic to the `Entry` function in the `ModEntry` class

## Publishing mods
- Set or bump the version in `manifest.json`
- Build the project via Visual Studio or the dotnet CLI
- Zip the `/release` directory and upload to the Nexus portal
- Done!


## Resources

See the Stardew Valley wiki for SMAPI usage:

https://stardewvalleywiki.com/Modding:Index#Creating_mods
