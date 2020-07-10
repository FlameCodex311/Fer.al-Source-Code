/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[CreateAssetMenu] // 0x000000018014D5D0-0x000000018014D610
public class BoosterShapeData : ScriptableObject // TypeDefIndex: 12936
{
	// Fields
	public BoosterType boosterType; // 0x18
	public List<BoosterMatchOffsetList> variations; // 0x20

	// Nested types
	[Serializable]
	public class BoosterMatchOffsetList // TypeDefIndex: 12937
	{
		// Fields
		public List<Vector2Int> offsets; // 0x10

		// Constructors
		public BoosterMatchOffsetList(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public BoosterShapeData(); // 0x00000001803A2BB0-0x00000001803A2BC0
}

