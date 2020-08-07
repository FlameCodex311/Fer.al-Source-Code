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
	public class LookAt : ActionTask<Transform> // TypeDefIndex: 15376
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> lookTarget; // 0x68
		public bool repeat; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BB5340-0x0000000180BB5380 
	
		// Constructors
		public LookAt(); // 0x0000000180BB5300-0x0000000180BB5340
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB52F0-0x0000000180BB5300
		protected override void OnUpdate(); // 0x0000000180BB52F0-0x0000000180BB5300
		private void DoLook(); // 0x0000000180BB51D0-0x0000000180BB52F0
	}
}
