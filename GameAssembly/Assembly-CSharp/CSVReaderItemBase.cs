/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class CSVReaderItemBase // TypeDefIndex: 13378
{
	// Fields
	private Dictionary<string, int> columnNameIndex; // 0x10
	private string[] dataArray; // 0x18
	[NonSerialized]
	public string sheetKey; // 0x20

	// Constructors
	public CSVReaderItemBase(); // 0x0000000181022680-0x00000001810226C0

	// Methods
	public void Init(Dictionary<string, int> inColumnNameIndex, string[] inDataArray); // 0x0000000180C50EA0-0x0000000180C50EB0
	public virtual void LoadEntry(); // 0x00000001803581E0-0x00000001803581F0
	public string LoadString(string inCategory, string defaultValue = "Missing" /* Metadata: 0x00783BEE */); // 0x0000000181021D80-0x0000000181021E50
	public long LoadDate(string inCategory); // 0x0000000181021770-0x0000000181021890
	public List<string> LoadStringList(string inCategory, bool isDynamic = false /* Metadata: 0x00783BF9 */); // 0x0000000181021D50-0x0000000181021D80
	public List<string> LoadStringList(string inCategory, char inSeperator, bool isDynamic = false /* Metadata: 0x00783BFA */); // 0x0000000181021B90-0x0000000181021D50
	public List<T> LoadGenericDefList<T>(string inChartName, string inCategory)
		where T : BaseDef;
	public List<T> LoadGenericDynamicDefList<T>(string inCategory)
		where T : BaseDef;
	public List<List<string>> LoadColorRefList(string inCategory); // 0x0000000181021300-0x0000000181021660
	public Color LoadColor(string inCategory); // 0x0000000181021660-0x0000000181021770
	public Color LoadColorAsString(string inString); // 0x0000000181021070-0x0000000181021300
	public Vector2 LoadVector2(string inCategory); // 0x0000000181021E50-0x00000001810221F0
	public Vector3 LoadVector3(string inCategory); // 0x00000001810221F0-0x0000000181022680
	public float LoadFloat(string inCategory); // 0x0000000181021890-0x0000000181021960
	public int LoadInt(string inCategory); // 0x0000000181021960-0x0000000181021AC0
	public long LoadLong(string inCategory); // 0x0000000181021AC0-0x0000000181021B90
	public bool LoadBool(string inCategory, bool inDefault = false /* Metadata: 0x00783BFB */); // 0x0000000181020F90-0x0000000181021070
}

