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
	[Category] // 0x000000018027BA90-0x000000018027BAF0
	[Description] // 0x000000018027BA90-0x000000018027BAF0
	public class FindPointBetweenLocalPlayer : ActionTask<Transform> // TypeDefIndex: 15463
	{
		// Fields
		[SliderField] // 0x000000018027BC50-0x000000018027BC70
		public BBParameter<float> scaler; // 0x68
		public BBParameter<Vector3> resultPoint; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BAC130-0x0000000180BAC1F0 
	
		// Constructors
		public FindPointBetweenLocalPlayer(); // 0x0000000180BAC0E0-0x0000000180BAC130
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BABF20-0x0000000180BAC0E0
	}
}
