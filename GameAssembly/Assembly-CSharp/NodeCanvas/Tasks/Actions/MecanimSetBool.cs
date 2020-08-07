/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180247050-0x00000001802470D0
	[Description] // 0x0000000180247050-0x00000001802470D0
	[Name] // 0x0000000180247050-0x00000001802470D0
	public class MecanimSetBool : ActionTask<Animator> // TypeDefIndex: 15304
	{
		// Fields
		public BBParameter<string> parameter; // 0x68
		public BBParameter<int> parameterHashID; // 0x70
		public BBParameter<bool> setTo; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180BB5930-0x0000000180BB59F0 
	
		// Constructors
		public MecanimSetBool(); // 0x0000000180BB58F0-0x0000000180BB5930
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB57A0-0x0000000180BB58F0
	}
}
