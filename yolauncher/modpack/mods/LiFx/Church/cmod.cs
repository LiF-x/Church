/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>Bear Knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxChurch))
{
    new ScriptObject(LiFxChurch)
    {
    };
}
package LiFxChurch
{
  function LiFxChurch::setup() {
    LiFx::registerCallback($LiFx::hooks::onMaterialsLoad, Registerdecmaterials, LiFxChurch);

  }
  function LiFxChurch::Registerdecmaterials() {
    LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/Church", "ChurchMats.cs");
    LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/Church", "ChurchSounds.cs");
  }
  function LiFxKnoolPack::path() {
    return $Con::File;
  }
};
activatePackage(LiFxChurch);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxChurch);