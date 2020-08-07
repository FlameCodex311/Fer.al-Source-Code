/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework.Internal
{
	public class MissingBBParameterType : BBParameter<object>, IMissingRecoverable // TypeDefIndex: 15786
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _missingType; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _recoveryState; // 0x58
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x0000000180378320-0x0000000180378330 0x00000001803F7B90-0x00000001803F7BA0
		string IMissingRecoverable.recoveryState { get; set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
	
		// Constructors
		public MissingBBParameterType(); // 0x0000000180CCB550-0x0000000180CCB590
	}
}
