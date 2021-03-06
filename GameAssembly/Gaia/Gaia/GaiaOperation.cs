﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	[Serializable]
	public class GaiaOperation // TypeDefIndex: 9220
	{
		// Fields
		public string m_description; // 0x10
		public OperationType m_operationType; // 0x18
		public bool m_isActive; // 0x1C
		public string m_generatedByName; // 0x20
		public string m_generatedByID; // 0x28
		public string m_generatedByType; // 0x30
		public string m_operationDateTime; // 0x38
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string[] m_operationDataJson; // 0x40
		public bool m_isFoldedOut; // 0x48
	
		// Nested types
		public enum OperationType // TypeDefIndex: 9221
		{
			CreateTerrain = 0,
			FlattenTerrain = 1,
			SmoothTerrain = 2,
			ClearDetails = 3,
			ClearTrees = 4,
			Stamp = 5,
			StampUndo = 6,
			StampRedo = 7,
			Spawn = 8,
			SpawnReset = 9
		}
	
		// Constructors
		public GaiaOperation(); // 0x0000000180E3E8C0-0x0000000180E3E950
	}
}
