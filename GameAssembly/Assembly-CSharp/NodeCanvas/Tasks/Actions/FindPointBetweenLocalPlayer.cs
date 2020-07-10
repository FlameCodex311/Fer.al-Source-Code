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
	[Category] // 0x000000018010E790-0x000000018010E7F0
	[Description] // 0x000000018010E790-0x000000018010E7F0
	public class FindPointBetweenLocalPlayer : ActionTask<Transform> // TypeDefIndex: 14360
	{
		// Fields
		[SliderField] // 0x000000018010EA50-0x000000018010EA70
		public BBParameter<float> scaler; // 0x68
		public BBParameter<Vector3> resultPoint; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181546340-0x0000000181546410 
	
		// Constructors
		public FindPointBetweenLocalPlayer(); // 0x00000001815462F0-0x0000000181546340
	
		// Methods
		protected override void OnExecute(); // 0x0000000181546130-0x00000001815462F0
	}
}
