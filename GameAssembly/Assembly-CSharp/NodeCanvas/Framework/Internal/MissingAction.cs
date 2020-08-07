/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework.Internal
{
	[Description] // 0x0000000180231B20-0x0000000180231B60
	[DoNotList] // 0x0000000180231B20-0x0000000180231B60
	public class MissingAction : ActionTask, IMissingRecoverable // TypeDefIndex: 15780
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _missingType; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _recoveryState; // 0x70
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x00000001803765E0-0x00000001803765F0 0x00000001804ADAC0-0x00000001804ADAD0
		string IMissingRecoverable.recoveryState { get; set; } // 0x0000000180418980-0x0000000180418990 0x00000001804C61A0-0x00000001804C61B0
		protected override string info { get; } // 0x0000000180CCB4D0-0x0000000180CCB550 
	
		// Constructors
		public MissingAction(); // 0x000000018079E240-0x000000018079E250
	}
}
