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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype
{
	public class CraftIngredient : Interactable // TypeDefIndex: 14801
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private MeshRenderer _meshRenderer; // 0x1A0
		private string _ingredientDefId; // 0x1A8
		private QuickGamesBase _quickGame; // 0x1B0
		private BaseDef _ingredientDef; // 0x1B8
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string texturePath; // 0x1C0
		private static CraftIngredient _craftIngredient; // 0x00
	
		// Properties
		public BaseDef ingredientDef { get; } // 0x0000000180D94870-0x0000000180D94920 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <GetTextureRoutine>d__12 : IEnumerator<object> // TypeDefIndex: 14802
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CraftIngredient <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <GetTextureRoutine>d__12(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180DA4AD0-0x0000000180DA4CF0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180DA4CF0-0x0000000180DA4D40
		}
	
		// Constructors
		public CraftIngredient(); // 0x00000001804EF080-0x00000001804EF090
	
		// Methods
		public static CraftIngredient Get(); // 0x0000000180D94560-0x0000000180D94600
		public void Setup(string inIngredientDefId, QuickGamesBase inGame); // 0x0000000180D946A0-0x0000000180D94800
		public void CollectFromQuickGame(string inDefId, int inCount = 1 /* Metadata: 0x007BAFDE */, int inEmberCount = 0 /* Metadata: 0x007BAFE2 */); // 0x0000000180D94220-0x0000000180D942B0
		public void Collect(); // 0x0000000180D942B0-0x0000000180D94500
		[IteratorStateMachine] // 0x0000000180214850-0x00000001802148A0
		private IEnumerator GetTextureRoutine(); // 0x0000000180D94500-0x0000000180D94560
		private new void OnDrawGizmosSelected(); // 0x0000000180D94600-0x0000000180D946A0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <GetTextureRoutine>b__12_0(Texture loadedAsset); // 0x0000000180D94800-0x0000000180D94870
	}
}
