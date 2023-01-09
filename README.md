<img src="https://img.shields.io/badge/LiFx%20Server%20-%3Ev3.0.0-green" title="Requires LiFx server framework minimum v3.0.0" /><img src="https://img.shields.io/badge/MariaDB%20-%3Ev5.5.49-green" title="Tested with MariaDB v5.5.49" />
# Church

 The Church from LIF:MMO recreated for LIF:YO

[Download here](https://github.com/LiF-x/Church/releases/latest)

### Installation instructions

1. Download the latest package from the above link.
2. Extract the contents of the zip to a local folder
3. Remove older versions of the mod from your server
4. Upload the contents of the folder "mods" to the server
5. Upload the contents of the folder "yolauncher"  to the server
5. Edit skill_types.xml on the server, 
 - add "2485" to the id list inside <ent_req type="object_type_id" parent="1"> of "Praise the God!" ability. (Normally on line# 5574)
 - add "2485" to the id list inside <ent_req type="object_type_id"> of "Open/Close Door" ability. (Normally on line# 6019)
 - add "2485" to the id list inside <ent_req type="object_type_id"> of "as Your Home" ability. (Normally on line# 6036)
 - add "2485" to the id list inside <ent_req type="object_type_id"> of "Toll" ability. (Normally on line# 7098)
 - add "2485" to the id list inside <ent_req type="object_type_id"> of "Expel the Intruders." (Normally on line# 7537)
6. Edit cm_objects.xml in the data folder on the server and add the contents from the data/church.xml file at the end, before \</objects>
7. Use LiFx Server framework v3.0.0 or newer with $LiFx::createDataXMLS set to true in AutoloadConfig.cs to create objects_types.xml, recipe.xml and recipe_requirement.xml on the server and start the server.
8. Stop the server and copy files on the server from /LiFx/dbexport to your servers /data folder
8. Download cm_objects.xml, objects_types.xml, recipe.xml, skill_types.xml and recipe_requirement.xml from the servers to your extracted "yolauncher/modpack/data" folder.
9. Ensure you have 7zip installed on your computer [Download here](https://7zip.dev/en/download/)
10. Ensure all you need is in the pack and insert files into the yo launcher folder that you need for your server, ensuring you do not overwrite the mod files
11. Run the "createModpack.bat" included in this pack to generate a mod pack to upload to [Yo Launcher](https://www.yolauncher.app/)
12. Upload to Yo Launcher as normal 
13. Enjoy


 
