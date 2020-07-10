/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800E3330-0x00000001800E33B0
	[Description] // 0x00000001800E3330-0x00000001800E33B0
	[Name] // 0x00000001800E3330-0x00000001800E33B0
	public class MecanimSetBool : ActionTask<Animator> // TypeDefIndex: 14204
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<bool> setTo; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018154FBA0-0x000000018154FC60 
	
		// Constructors
		public MecanimSetBool(); // 0x000000018154FB60-0x000000018154FBA0
	
		// Methods
		protected override void OnExecute(); // 0x000000018154FA10-0x000000018154FB60
	}
}
