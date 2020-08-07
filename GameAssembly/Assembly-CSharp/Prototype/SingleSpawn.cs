/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prototype.QuickGames;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype
{
	public class SingleSpawn : ManagedBehaviour // TypeDefIndex: 14822
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private InspirationDetails _inspirationDetails; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IngredientDetails _ingredientDetails; // 0x58
	
		// Nested types
		[Serializable]
		public class InspirationDetails // TypeDefIndex: 14823
		{
			// Fields
			[RootSelector] // 0x000000018021B540-0x000000018021B5A0
			public string defId; // 0x10
	
			// Constructors
			public InspirationDetails(); // 0x0000000180373240-0x0000000180373250
		}
	
		[Serializable]
		public class IngredientDetails // TypeDefIndex: 14824
		{
			// Fields
			[RootSelector] // 0x000000018021B930-0x000000018021B990
			public string defId; // 0x10
			public QuickGamesBase quickGame; // 0x18
	
			// Constructors
			public IngredientDetails(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		public SingleSpawn(); // 0x0000000180A3D080-0x0000000180A3D0E0
	
		// Methods
		public override void MStart(); // 0x0000000180A3CD50-0x0000000180A3CFE0
		private void OnDrawGizmos(); // 0x0000000180A3CFE0-0x0000000180A3D080
	}
}
