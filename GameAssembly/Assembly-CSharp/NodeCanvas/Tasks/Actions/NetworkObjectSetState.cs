/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180286520-0x0000000180286580
	[Description] // 0x0000000180286520-0x0000000180286580
	public class NetworkObjectSetState : NetworkActionTask<NetworkedObjectInfo> // TypeDefIndex: 15500
	{
		// Fields
		public ESetType setType; // 0x68
		[ShowIf] // 0x00000001802867D0-0x0000000180286800
		public BBParameter<int> setValue; // 0x70
		public EActionObjects actionObjects; // 0x78
		[ShowIf] // 0x000000018027B520-0x000000018027B550
		public List<BBParameter<NetworkedObjectInfo>> networkedObjectInfos; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180BBAC40-0x0000000180BBB1B0 
	
		// Nested types
		public enum ESetType // TypeDefIndex: 15501
		{
			equalTo = 0,
			add_1 = 1,
			subtract_1 = 2
		}
	
		public enum EActionObjects // TypeDefIndex: 15502
		{
			single = 0,
			multiple = 1
		}
	
		// Constructors
		public NetworkObjectSetState(); // 0x0000000180BBABC0-0x0000000180BBAC40
	}
}
