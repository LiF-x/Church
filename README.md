# Church

 The Church from LIF:MMO recreated for LIF:YO

[Download here](https://github.com/LiF-x/Church/releases/latest)

### Installation instructions

1. Download the latest package from the above link.
2. Extract the contents of the zip to a local folder
3. Remove older versions of the mod from your server
4. Upload the contents of mods to the server
5. Edit skill_types.xml on the server, add "2485" to the id list inside <ent_req type="object_type_id" parent="1"> of Praise the God! ability. (Normally on line# 5574)
6. Edit cm_objects.xml in the data folder on the server and add the contents from the data/church.xml file at the end, before </objects>
7. Use LiFx Server framework v3.0.0 or newer with $LiFx::createDataXMLS set to true in AutoloadConfig.cs to create objects_types.xml, recipe.xml and recipe_requirement.xml on the server and start the server.
8. Copy objects_types.xml, recipe.xml and recipe_requirement.xml from the server to your extracted "data" folder.
9. Download the edited cm_objects.xml overwriting cm_objects in your local data folder.
10. Ensure you have 7zip installed on your computer [Download here](https://7zip.dev/en/download/)
11. Ensure all you need is in the pack and insert files into the yo launcher folder that you need for your server, ensuring you do not overwrite the mod files
12. Run the "createModpack.bat" included in this pack to generate a mod pack to upload to [Yo Launcher](https://www.yolauncher.app/)
13. Upload to Yo Launcher as normal 
14. Enjoy


 
