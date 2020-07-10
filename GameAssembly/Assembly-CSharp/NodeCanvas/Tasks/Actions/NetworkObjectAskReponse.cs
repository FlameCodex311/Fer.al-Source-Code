/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180119800-0x0000000180119860
	[Description] // 0x0000000180119800-0x0000000180119860
	public class NetworkObjectAskReponse : ActionTask<NetworkedObjectInfo> // TypeDefIndex: 14391
	{
		// Fields
		public EAskResponse askResponse; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181554310-0x00000001815544B0 
	
		// Nested types
		public enum EAskResponse // TypeDefIndex: 14392
		{
			yes = 0,
			no = 1
		}
	
		// Constructors
		public NetworkObjectAskReponse(); // 0x00000001815542D0-0x0000000181554310
	
		// Methods
		protected override void OnExecute(); // 0x0000000181554230-0x00000001815542D0
	}
}
