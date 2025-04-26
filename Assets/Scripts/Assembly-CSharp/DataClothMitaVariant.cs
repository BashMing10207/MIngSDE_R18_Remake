using System;
using UnityEngine;

[Serializable]
public class DataClothMitaVariant
{
	public Color color1;

	public Color color2;

	public Sprite colorSprite;

	[Space(40f)]
	public Texture2D[] bodyTextures;

	public Material[] bodyMaterials;

	[Space(20f)]
	public Texture2D[] attributeTextures;

	public Material[] attributeMaterials;

	[Space(20f)]
	public Texture2D[] pantyhoseTextures;

	public Material[] pantyhoseMaterials;

	[Space(20f)]
	public Texture2D[] shoesTextures;

	public Material[] shoesMaterials;

	[Space(20f)]
	public Texture2D[] skirtTextures;

	public Material[] skirtMaterials;

	[Space(20f)]
	public Texture2D[] sweaterTextures;

	public Material[] sweaterMaterials;

	[HideInInspector]
	public Texture2D textureSadMitaBody;

	[HideInInspector]
	public Texture2D textureSadMitaCloth;

	[HideInInspector]
	public Texture2D textureSadMitaFace;

	[HideInInspector]
	public Texture2D textureSadMitaHair;

	[Header("Дополнения")]
	public DataClothMitaVariantAddon[] addon;
}
