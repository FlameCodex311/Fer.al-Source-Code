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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework.Internal
{
	[Description] // 0x000000018016AE50-0x000000018016AE90
	[DoNotList] // 0x000000018016AE50-0x000000018016AE90
	public sealed class MissingNode : Node, IMissingRecoverable // TypeDefIndex: 14621
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _missingType; // 0x78
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _recoveryState; // 0x80
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x0000000180369C70-0x0000000180369C80 0x00000001803D8EF0-0x00000001803D8F00
		string IMissingRecoverable.recoveryState { get; set; } // 0x000000018035FCB0-0x000000018035FCC0 0x00000001803D8ED0-0x00000001803D8EE0
		public override string name { get; } // 0x0000000181759F20-0x0000000181759F50 
		public override Type outConnectionType { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public override int maxInConnections { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public override int maxOutConnections { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public override bool allowAsPrime { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public override Alignment2x2 commentsAlignment { get; } // 0x0000000180362180-0x0000000180362190 
		public override Alignment2x2 iconAlignment { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
		// Constructors
		public MissingNode(); // 0x000000018155E370-0x000000018155E380
	}
}
