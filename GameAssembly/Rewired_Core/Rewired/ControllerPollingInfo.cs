/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public struct ControllerPollingInfo // TypeDefIndex: 5886
	{
		// Fields
		private bool mAeAxJMgtDfAMbKWGFWYTqXibome; // 0x00
		private int qInCCRhldamcdoUHmMSlSCAIgFUz; // 0x04
		private int tiHDqwuWnAypLNJNoTzBctdWRZt; // 0x08
		private string UxNiwDodslXPCdFqWLGOVfaTniS; // 0x10
		private ControllerType jVRvmdSGLvngKifezJIAQbIZrmi; // 0x18
		private ControllerElementType qpRMJmJvNOAvIcQCpUijnRuXokN; // 0x1C
		private int cIpzjPbNKhTxYBMDvNEwhaGcpst; // 0x20
		private Pole TOQhdYxYmfEZSXsPdVlMgGmNBCfD; // 0x24
		private string oOMORlOrxgmdGBHNEgbnhrIAoCGC; // 0x28
		private int ilJvqPoikRsmduZhwvvUegWxsnI; // 0x30
		private KeyCode thHapmgLdrcZZoySVPpCrGMvXDJL; // 0x34
	
		// Properties
		public bool success { get; internal set; } // 0x00000001800A1FA0-0x00000001800A2000 0x00000001800A2E00-0x00000001800A2E10
		public int playerId { get; internal set; } // 0x0000000180003CA0-0x0000000180003FD0 0x00000001800215B0-0x00000001800215C0
		public int controllerId { get; internal set; } // 0x00000001800213D0-0x00000001800213E0 0x0000000180021560-0x0000000180021590
		public string controllerName { get; internal set; } // 0x000000018001A8E0-0x000000018001A8F0 0x000000018001A910-0x000000018001AA00
		public ControllerType controllerType { get; internal set; } // 0x0000000180091C10-0x0000000180091C20 0x00000001800A2950-0x00000001800A2960
		public ControllerElementType elementType { get; internal set; } // 0x00000001800A2890-0x00000001800A28A0 0x00000001800A2940-0x00000001800A2950
		public int elementIndex { get; internal set; } // 0x00000001800A2880-0x00000001800A2890 0x00000001800A2900-0x00000001800A2910
		public Pole axisPole { get; internal set; } // 0x00000001800A28B0-0x00000001800A28C0 0x00000001800A2970-0x00000001800A2A40
		public string elementIdentifierName { get; internal set; } // 0x000000018001AA00-0x000000018001AA10 0x000000018005C120-0x000000018005C130
		public int elementIdentifierId { get; internal set; } // 0x00000001800A2870-0x00000001800A2880 0x00000001800A28F0-0x00000001800A2900
		public KeyCode keyboardKey { get; internal set; } // 0x00000001800C2C40-0x00000001800C2C50 0x00000001800C2D90-0x00000001800C2EE0
		public Player player { get; } // 0x00000001800C2C50-0x00000001800C2D90 
		public Controller controller { get; } // 0x00000001800C2B60-0x00000001800C2B70 
		public ControllerElementIdentifier elementIdentifier { get; } // 0x00000001800C2B70-0x00000001800C2C40 
	
		// Constructors
		internal ControllerPollingInfo(bool success, int playerId, int controllerId, string controllerName, ControllerType controllerType, ControllerElementType elementType, int elementIndex, Pole axisPole, string elementIdentifierName, int elementIdentifierId, KeyCode keyboardKey); // 0x00000001800C2B10-0x00000001800C2B60
		internal ControllerPollingInfo(ControllerPollingInfo source); // 0x00000001800C2A80-0x00000001800C2B10
	
		// Methods
		internal static ControllerPollingInfo gNxCchOTUzuzPyuitQKmhCkgenGj(); // 0x00000001814A73C0-0x00000001814A7520
	}
}
