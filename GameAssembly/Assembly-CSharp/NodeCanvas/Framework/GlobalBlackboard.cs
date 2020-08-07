/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	[DisallowMultipleComponent] // 0x00000001801CDDD0-0x00000001801CDE00
	[ExecuteInEditMode] // 0x00000001801CDDD0-0x00000001801CDE00
	public class GlobalBlackboard : Blackboard, IGlobalBlackboard // TypeDefIndex: 15741
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _UID; // 0x90
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _identifier; // 0x98
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _dontDestroyOnLoad; // 0xA0
		private static List<GlobalBlackboard> _allGlobals; // 0x00
	
		// Properties
		public string identifier { get; } // 0x0000000180418990-0x00000001804189A0 
		public string UID { get; } // 0x00000001803D6D80-0x00000001803D6D90 
		public new string name { get; } // 0x0000000180418990-0x00000001804189A0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass12_0 // TypeDefIndex: 15742
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public <>c__DisplayClass12_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <Find>b__0(GlobalBlackboard b); // 0x00000001808B76A0-0x00000001808B76D0
		}
	
		// Constructors
		public GlobalBlackboard(); // 0x00000001808A87B0-0x00000001808A88A0
		static GlobalBlackboard(); // 0x00000001808A8750-0x00000001808A87B0
	
		// Methods
		public static IEnumerable<GlobalBlackboard> GetAll(); // 0x00000001808A8290-0x00000001808A82F0
		public static GlobalBlackboard Create(); // 0x00000001808A8130-0x00000001808A81B0
		public static GlobalBlackboard Find(string name); // 0x00000001808A81B0-0x00000001808A8290
		public override void MOnEnable(); // 0x00000001808A8370-0x00000001808A8570
		public override void MOnDestroy(); // 0x00000001808A82F0-0x00000001808A8370
		protected override void OnValidate(); // 0x00000001808A8570-0x00000001808A8750
		public override string ToString(); // 0x0000000180418990-0x00000001804189A0
		private bool IsPrefabAsset(); // 0x0000000180380950-0x0000000180380960
	}
}
