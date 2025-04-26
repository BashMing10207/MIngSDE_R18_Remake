using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DataClothMita
{
	[Header("Меню")]
	public int stringName;

	public string fileSave;

	public Sprite iconCloth;

	public Color colorCase1;

	public Color colorCase2;

	[Header("Меш и материалы")]
	public Mesh attributeMesh;

	public Mesh bodyMesh;

	public Mesh pantyhoseMesh;

	public Mesh shoesMesh;

	public Mesh skirtMesh;

	public Mesh sweaterMesh;

	public List<DataClothMitaVariant> variants;

	[Header("Для безумной Миты")]
	public Texture2D textureFace;

	public Texture2D textureHairs;

	[Header("Для кепки")]
	public Mesh sweaterMeshCap;

	public Mesh bodyMeshCap;

	public bool removeGloves;

	[Header("Кости и динамика")]
	public GameObject prefabFull;

	[Space(40f)]
	public string modNameCloth;
}
