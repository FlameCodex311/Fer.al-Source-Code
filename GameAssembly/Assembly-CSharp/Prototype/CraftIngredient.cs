/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prototype.QuickGames;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype
{
	public class CraftIngredient : Interactable // TypeDefIndex: 16062
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private MeshRenderer _meshRenderer; // 0x1A0
		private string _ingredientDefId; // 0x1A8
		private QuickGamesBase _quickGame; // 0x1B0
		private BaseDef _ingredientDef; // 0x1B8
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public string texturePath; // 0x1C0
		private static CraftIngredient _craftIngredient; // 0x00
	
		// Properties
		public BaseDef ingredientDef { get; } // 0x000000018139D610-0x000000018139D6C0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <GetTextureRoutine>d__12 : IEnumerator<object> // TypeDefIndex: 16063
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CraftIngredient <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <GetTextureRoutine>d__12(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813A8E40-0x00000001813A9070
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813A9070-0x00000001813A90C0
		}
	
		// Constructors
		public CraftIngredient(); // 0x0000000180F5D120-0x0000000180F5D130
	
		// Methods
		public static CraftIngredient Get(); // 0x000000018139D300-0x000000018139D3A0
		public void Setup(string inIngredientDefId, QuickGamesBase inGame); // 0x000000018139D440-0x000000018139D5A0
		public void CollectFromQuickGame(string inDefId, int inCount = 1 /* Metadata: 0x007853EC */, int inEmberCount = 0 /* Metadata: 0x007853F0 */); // 0x000000018139CFA0-0x000000018139D030
		public void Collect(); // 0x000000018139D030-0x000000018139D2A0
		[IteratorStateMachine] // 0x00000001800F9360-0x00000001800F93B0
		private IEnumerator GetTextureRoutine(); // 0x000000018139D2A0-0x000000018139D300
		private new void OnDrawGizmosSelected(); // 0x000000018139D3A0-0x000000018139D440
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <GetTextureRoutine>b__12_0(Texture loadedAsset); // 0x000000018139D5A0-0x000000018139D610
	}
}
