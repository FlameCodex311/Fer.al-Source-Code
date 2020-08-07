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
	[Description] // 0x000000018022FA70-0x000000018022FAB0
	[DoNotList] // 0x000000018022FA70-0x000000018022FAB0
	public sealed class MissingConnection : Connection, IMissingRecoverable // TypeDefIndex: 15761
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _missingType; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _recoveryState; // 0x38
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
		string IMissingRecoverable.recoveryState { get; set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
	
		// Constructors
		public MissingConnection(); // 0x00000001807C4290-0x00000001807C42A0
	}
}
