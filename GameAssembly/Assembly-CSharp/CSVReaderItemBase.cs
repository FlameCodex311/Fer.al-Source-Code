/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class CSVReaderItemBase // TypeDefIndex: 10969
{
	// Fields
	private Dictionary<string, int> columnNameIndex; // 0x10
	private string[] dataArray; // 0x18
	[NonSerialized]
	public string sheetKey; // 0x20

	// Constructors
	public CSVReaderItemBase(); // 0x000000018049AF90-0x000000018049AFD0

	// Methods
	public void Init(Dictionary<string, int> inColumnNameIndex, string[] inDataArray); // 0x00000001804997D0-0x00000001804997E0
	public virtual void LoadEntry(); // 0x00000001803774A0-0x00000001803774B0
	public string LoadString(string inCategory, string defaultValue = "Missing" /* Metadata: 0x0077C5E9 */); // 0x000000018049A6D0-0x000000018049A7A0
	public long LoadDate(string inCategory); // 0x0000000180499F70-0x000000018049A090
	public List<string> LoadStringList(string inCategory, bool isDynamic = false /* Metadata: 0x0077C5F4 */); // 0x000000018049A530-0x000000018049A6D0
	public List<string> LoadStringList(string inCategory, char inSeperator, bool isDynamic = false /* Metadata: 0x0077C5F5 */); // 0x000000018049A380-0x000000018049A530
	public List<T> LoadGenericDefList<T>(string inChartName, string inCategory)
		where T : BaseDef;
	public List<T> LoadGenericDynamicDefList<T>(string inCategory)
		where T : BaseDef;
	public List<List<string>> LoadColorRefList(string inCategory); // 0x0000000180499B30-0x0000000180499E70
	public Color LoadColor(string inCategory); // 0x0000000180499E70-0x0000000180499F70
	public Color LoadColorAsString(string inString); // 0x00000001804998C0-0x0000000180499B30
	public Vector2 LoadVector2(string inCategory); // 0x000000018049A7A0-0x000000018049AB20
	public Vector3 LoadVector3(string inCategory); // 0x000000018049AB20-0x000000018049AF90
	public float LoadFloat(string inCategory); // 0x000000018049A090-0x000000018049A160
	public int LoadInt(string inCategory); // 0x000000018049A160-0x000000018049A2B0
	public long LoadLong(string inCategory); // 0x000000018049A2B0-0x000000018049A380
	public bool LoadBool(string inCategory, bool inDefault = false /* Metadata: 0x0077C5F6 */); // 0x00000001804997E0-0x00000001804998C0
}

