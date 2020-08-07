/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001802849A0-0x0000000180284A00
	[Description] // 0x00000001802849A0-0x0000000180284A00
	public class NetworkObjectAskReponse : ActionTask<NetworkedObjectInfo> // TypeDefIndex: 15496
	{
		// Fields
		public EAskResponse askResponse; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000180BBA880-0x0000000180BBAA20 
	
		// Nested types
		public enum EAskResponse // TypeDefIndex: 15497
		{
			yes = 0,
			no = 1
		}
	
		// Constructors
		public NetworkObjectAskReponse(); // 0x0000000180BBA840-0x0000000180BBA880
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BBA7A0-0x0000000180BBA840
	}
}
