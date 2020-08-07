/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[CreateAssetMenu] // 0x000000018022E0F0-0x000000018022E130
public class BoosterShapeData : ScriptableObject // TypeDefIndex: 10601
{
	// Fields
	public BoosterType boosterType; // 0x18
	public List<BoosterMatchOffsetList> variations; // 0x20

	// Nested types
	[Serializable]
	public class BoosterMatchOffsetList // TypeDefIndex: 10602
	{
		// Fields
		public List<Vector2Int> offsets; // 0x10

		// Constructors
		public BoosterMatchOffsetList(); // 0x0000000180373240-0x0000000180373250
	}

	// Constructors
	public BoosterShapeData(); // 0x00000001803FEC00-0x00000001803FEC10
}

