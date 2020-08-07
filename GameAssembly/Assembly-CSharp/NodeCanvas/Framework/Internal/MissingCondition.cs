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
	[Description] // 0x00000001802320B0-0x00000001802320F0
	[DoNotList] // 0x00000001802320B0-0x00000001802320F0
	public class MissingCondition : ConditionTask, IMissingRecoverable // TypeDefIndex: 15781
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _missingType; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _recoveryState; // 0x70
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x00000001803765E0-0x00000001803765F0 0x00000001804ADAC0-0x00000001804ADAD0
		string IMissingRecoverable.recoveryState { get; set; } // 0x0000000180418980-0x0000000180418990 0x00000001804C61A0-0x00000001804C61B0
		protected override string info { get; } // 0x0000000180CCB590-0x0000000180CCB610 
	
		// Constructors
		public MissingCondition(); // 0x0000000180792480-0x0000000180792490
	}
}
