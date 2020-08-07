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
	[Category] // 0x000000018022E850-0x000000018022E880
	public class GetDistance : ActionTask<Transform> // TypeDefIndex: 15373
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> target; // 0x68
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BADCD0-0x0000000180BADD30 
	
		// Constructors
		public GetDistance(); // 0x0000000180BADC90-0x0000000180BADCD0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BADB30-0x0000000180BADC90
	}
}
