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
	[Category] // 0x000000018025D290-0x000000018025D2F0
	[Obsolete] // 0x000000018025D290-0x000000018025D2F0
	public class GetGameObjectPosition : ActionTask<Transform> // TypeDefIndex: 15374
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Vector3> saveAs; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000180BAE370-0x0000000180BAE540 
	
		// Constructors
		public GetGameObjectPosition(); // 0x0000000180BAE330-0x0000000180BAE370
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BAE290-0x0000000180BAE330
	}
}
