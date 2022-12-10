singleton Material(PineBark_Cart_Rope) 
{
   mapTo = "Rope_2_diff_mat";
   diffuseMap[0] = "art/Textures/TextureLib/Rope_2_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Rope_2_normal.dds";
   normal3DC="1";
   alphaTest = "1";
   alphaRef = "100";
   doubleSided = "1";
   skinned = true;
   materialTag0 = "LiF";
};

singleton Material(MapleBark_Diffuse_Cart)
{
   mapTo = "MapleBark_cart";
   diffuseMap[0] = "art/models/3d/environment/trees/maple/textures/maplebark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/maple/textures/maplebark_normal.dds";
};

singleton Material(MapleTree_Cart) // клен
{
   mapTo = "MapleTree_cart";
   diffuseMap[0] = "art/models/3d/environment/trees/maple/textures/mapletree_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/maple/textures/mapletree_normal.dds";
};

singleton Material(OakTree_Cart) // дуб
{
   mapTo = "OakTree_Diffuse_cart";
   diffuseMap[0] = "art/models/3d/environment/trees/oak/textures/oaktree_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/oak/textures/oaktree_normal.dds";
};

singleton Material(OakBark01_Cart) // дуб ствол
{
   mapTo = "OakBark01_cart";
   diffuseMap[0] = "art/models/3d/environment/trees/oak/textures/oakbark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/oak/textures/oakbark_normal.dds";
};

singleton Material(BirchTree_Cart) // береза
{
   mapTo = "BirchTree_cart";
   diffuseMap[0] = "art/models/3d/environment/trees/birch/textures/birchtree_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/birch/textures/birchtree_normal.dds";
};

singleton Material(BirchBark_Cart) // береза ствол
{
   mapTo = "BirchBark_cart";
   diffuseMap[0] = "art/models/3d/environment/trees/birch/textures/birchbark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/birch/textures/birchbark_normal.dds";
};

singleton Material(PineTree_Cart) // сосна
{
   mapTo = "PineTree_cart";
   diffuseMap[0] = "art/models/3d/environment/trees/pine/textures/pinetree_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/pine/textures/pinetree_normal.dds";
};

singleton Material(PineBark_Cart) // сосна ствол
{
   mapTo = "PineBark_cart";
   diffuseMap[0] = "art/models/3d/environment/trees/pine/textures/pinebark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/pine/textures/pinebark_normal.dds";
};