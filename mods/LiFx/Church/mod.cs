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
      LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, ChurchRecipe, LiFxChurch);
      
      // Register new objects
      LiFx::registerObjectsTypes(LiFxChurch::ObjectsTypesChurch(), LiFxChurch);

    }
    function LiFxChurch::version() {
        return "0.0.2";
    }

    function LiFxChurch::ObjectsTypesChurch() {
        return new ScriptObject(ObjectsTypesChurch : ObjectsTypes)
        {
            id = 2485; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "LiFx Church";
            ParentID = 61;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 1;
            IsPremium = 1;
            MaxContSize = 10000000;
            Length = 0; 
            MaxStackSize = 120;
            UnitWeight = 6000000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/LiFx/Church/art/2D/Recipies/Church.png";
            Description = "A Beautiful Church similar to one seen in godenland whilst fighting the great knool wars";
            BasePrice = 0;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }

  function LiFxChurch::ChurchRecipe() {
    ///////////////////////////////////////Recipe /////////////////////////////////////////////
    dbi.Select(LiFxChurch, "ChurchRequirements","SELECT MAX(ID)+1 as ID FROM `recipe`");
  }
  function LiFxChurch::ChurchRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
      dbi.Update("INSERT IGNORE `recipe` VALUES (" @ %lastInsert @ ", 'LiFx Church', 'A Beautiful Church similar to one seen in godenland whilst fighting the great knool wars.', NULL, 62, 0, 2485, 10, 1, 0, 0, 'yolauncher/modpack/mods/LiFx/Church/art/2D/Recipies/Church.png')");
      dbi.Update("INSERT IGNORE `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ", 233, 0, 10, 250, 0)"); // 250 x Logs
      dbi.Update("INSERT IGNORE `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ", 269, 0, 80, 350, 0)"); // 350 x Shaped Stone
      dbi.Update("INSERT IGNORE `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ", 272, 0, 10, 250, 0)"); // 250 x Glass
      dbi.Update("INSERT IGNORE `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ", 271, 0, 80, 650, 0)"); // 650 x Shaped Granite
      dbi.Update("INSERT IGNORE `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ", 326, 0, 10, 650, 0)"); // 650 x hardwood board
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
 }
     ///////////////////////////////////////Recipe Requirements /////////////////////////////////////////////

};
activatePackage(LiFxChurch);