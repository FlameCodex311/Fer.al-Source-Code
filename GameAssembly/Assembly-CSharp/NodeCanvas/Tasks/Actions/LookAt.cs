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
	[Category] // 0x00000001800CAE50-0x00000001800CAE80
	public class LookAt : ActionTask<Transform> // TypeDefIndex: 14275
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> lookTarget; // 0x68
		public bool repeat; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018154F5A0-0x000000018154F5E0 
	
		// Constructors
		public LookAt(); // 0x000000018154F560-0x000000018154F5A0
	
		// Methods
		protected override void OnExecute(); // 0x000000018154F550-0x000000018154F560
		protected override void OnUpdate(); // 0x000000018154F550-0x000000018154F560
		private void DoLook(); // 0x000000018154F420-0x000000018154F550
	}
}
