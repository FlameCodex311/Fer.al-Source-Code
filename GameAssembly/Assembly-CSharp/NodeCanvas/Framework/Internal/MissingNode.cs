/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework.Internal
{
	[Description] // 0x000000018022FFA0-0x000000018022FFE0
	[DoNotList] // 0x000000018022FFA0-0x000000018022FFE0
	public sealed class MissingNode : Node, IMissingRecoverable // TypeDefIndex: 15762
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _missingType; // 0x88
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _recoveryState; // 0x90
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x0000000180476CE0-0x0000000180476CF0 0x00000001804794C0-0x00000001804794D0
		string IMissingRecoverable.recoveryState { get; set; } // 0x00000001803D6D80-0x00000001803D6D90 0x000000018072D660-0x000000018072D670
		public override string name { get; } // 0x0000000180CCB610-0x0000000180CCB660 
		public override Type outConnectionType { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override int maxInConnections { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override int maxOutConnections { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override bool allowAsPrime { get; } // 0x0000000180380950-0x0000000180380960 
		public override bool canSelfConnect { get; } // 0x0000000180380950-0x0000000180380960 
		public override Alignment2x2 commentsAlignment { get; } // 0x0000000180411150-0x0000000180411160 
		public override Alignment2x2 iconAlignment { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
		// Constructors
		public MissingNode(); // 0x00000001807C41B0-0x00000001807C41C0
	}
}
