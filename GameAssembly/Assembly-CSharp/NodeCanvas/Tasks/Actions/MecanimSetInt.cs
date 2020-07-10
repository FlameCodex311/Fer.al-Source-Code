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
	[Category] // 0x00000001800E44D0-0x00000001800E4550
	[Description] // 0x00000001800E44D0-0x00000001800E4550
	[Name] // 0x00000001800E44D0-0x00000001800E4550
	public class MecanimSetInt : ActionTask<Animator> // TypeDefIndex: 14207
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<int> setTo; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001815506E0-0x00000001815507A0 
	
		// Constructors
		public MecanimSetInt(); // 0x00000001815506A0-0x00000001815506E0
	
		// Methods
		protected override void OnExecute(); // 0x0000000181550550-0x00000001815506A0
	}
}
