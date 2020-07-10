/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018011A0F0-0x000000018011A150
	[Description] // 0x000000018011A0F0-0x000000018011A150
	public class NetworkObjectSetState : NetworkActionTask<NetworkedObjectInfo> // TypeDefIndex: 14395
	{
		// Fields
		public ESetType setType; // 0x68
		[ShowIf] // 0x000000018011A310-0x000000018011A340
		public BBParameter<int> setValue; // 0x70
		public EActionObjects actionObjects; // 0x78
		[ShowIf] // 0x000000018010DF70-0x000000018010DFA0
		public List<BBParameter<NetworkedObjectInfo>> networkedObjectInfos; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001815546D0-0x0000000181554C70 
	
		// Nested types
		public enum ESetType // TypeDefIndex: 14396
		{
			equalTo = 0,
			add_1 = 1,
			subtract_1 = 2
		}
	
		public enum EActionObjects // TypeDefIndex: 14397
		{
			single = 0,
			multiple = 1
		}
	
		// Constructors
		public NetworkObjectSetState(); // 0x0000000181554650-0x00000001815546D0
	}
}
