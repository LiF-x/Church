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
      
      
      // Register new objects
      LiFx::registerObjectsTypes(LiFxChurch::ObjectsTypesChurch(), LiFxChurch);

      // Register new recipes
      LiFx::registerRecipe(LiFxChurch::RecipeChurch(), LiFxChurch);

    }
    function LiFxChurch::version() {
        return "1.0.1";
    }

  function LiFxChurch::ObjectsTypesChurch() {
    return new ScriptObject(ObjectsTypesChurch : ObjectsTypes)
    {
        id = 2485; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
        ObjectName = "MMO Church";
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
  function LiFxChurch::RecipeChurch() {
    %recipe = new ScriptObject(RecipeChurch : Recipes)
    {
        RecipeName = "MMO Church";
        Description = "A Beautiful Church similar to one seen in godenland whilst fighting the great knool wars";
        StartingToolsID = NULL;
        SkillTypeID = 62;
        SkillLvl = 0;
        ResultObjectTypeID = 2485;
        SkillDepends = 10;
        Quantity = 1;
        Autorepeat = 0;
        isBluePrint = 0;
        ImagePath = "yolauncher/modpack/mods/LiFx/Church/art/2D/Recipies/Church.png";
        Requirements = JettisonArray("RecipeChurchRequirements");
    };
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements)
    {
        MaterialObjectTypeID = 233;
        Quality = 0;
        Influence = 10;
        Quantity = 250;
        IsRegionalItemRequired = 0;
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements)
    {
        MaterialObjectTypeID = 269;
        Quality = 0;
        Influence = 30;
        Quantity = 350;
        IsRegionalItemRequired = 0;
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements)
    {
        MaterialObjectTypeID = 272;
        Quality = 0;
        Influence = 10;
        Quantity = 250;
        IsRegionalItemRequired = 0;
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements)
    {
        MaterialObjectTypeID = 271;
        Quality = 0;
        Influence = 30;
        Quantity = 650;
        IsRegionalItemRequired = 0;
    });
    %recipe.Requirements.Push(RecipeRequirements, new ScriptObject("" : RecipeRequirements)
    {
        MaterialObjectTypeID = 326;
        Quality = 0;
        Influence = 10;
        Quantity = 650;
        IsRegionalItemRequired = 0;
    });
    return %recipe;
  }


};
activatePackage(LiFxChurch);