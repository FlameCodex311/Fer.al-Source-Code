/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	[ExecuteInEditMode] // 0x00000001800B36B0-0x00000001800B36C0
	public class GlobalBlackboard : Blackboard // TypeDefIndex: 14605
	{
		// Fields
		public static List<GlobalBlackboard> allGlobals; // 0x00
		public bool dontDestroy; // 0x50
	
		// Properties
		public new string name { get; set; } // 0x0000000181752710-0x0000000181752720 0x0000000181752720-0x00000001817527D0
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 14606
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <Find>b__0(GlobalBlackboard b); // 0x0000000181761300-0x0000000181761340
			internal bool <Find>b__1(GlobalBlackboard b); // 0x0000000181761300-0x0000000181761340
			internal bool <Find>b__2(GlobalBlackboard b); // 0x0000000181761300-0x0000000181761340
		}
	
		// Constructors
		public GlobalBlackboard(); // 0x0000000181752700-0x0000000181752710
		static GlobalBlackboard(); // 0x00000001817526A0-0x0000000181752700
	
		// Methods
		public static GlobalBlackboard Create(); // 0x00000001817520D0-0x00000001817521F0
		public static GlobalBlackboard Find(string name); // 0x00000001817521F0-0x0000000181752480
		protected override void Awake(); // 0x0000000181751EB0-0x00000001817520D0
		private void OnDestroy(); // 0x0000000181752570-0x00000001817525F0
		private bool IsUnique(); // 0x0000000181752480-0x0000000181752570
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsUnique>b__9_0(GlobalBlackboard b); // 0x00000001817525F0-0x00000001817526A0
	}
}
