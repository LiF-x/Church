/**
* <author>Warped ibun</author>
* <email></email>
* <url></url>
* <credits></credits>
* <description>Church from LiF:MMO textured and LiFx and YoLauncher ready</description>
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