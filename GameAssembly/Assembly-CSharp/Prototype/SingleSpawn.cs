/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prototype.QuickGames;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype
{
	public class SingleSpawn : ManagedBehaviour // TypeDefIndex: 16083
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private InspirationDetails _inspirationDetails; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private IngredientDetails _ingredientDetails; // 0x58
	
		// Nested types
		[Serializable]
		public class InspirationDetails // TypeDefIndex: 16084
		{
			// Fields
			[RootSelector] // 0x00000001800FF170-0x00000001800FF1D0
			public string defId; // 0x10
	
			// Constructors
			public InspirationDetails(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[Serializable]
		public class IngredientDetails // TypeDefIndex: 16085
		{
			// Fields
			[RootSelector] // 0x00000001800FF420-0x00000001800FF480
			public string defId; // 0x10
			public QuickGamesBase quickGame; // 0x18
	
			// Constructors
			public IngredientDetails(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		// Constructors
		public SingleSpawn(); // 0x00000001816003B0-0x0000000181600410
	
		// Methods
		public override void MStart(); // 0x0000000181600110-0x00000001816003B0
		private void OnDrawGizmos(); // 0x000000018139D8F0-0x000000018139D990
	}
}
