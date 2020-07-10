/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public struct ControllerPollingInfo // TypeDefIndex: 5727
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
		public bool success { get; internal set; } // 0x000000018000A660-0x000000018000A670 0x000000018000A690-0x000000018000A6A0
		public int playerId { get; internal set; } // 0x0000000180002FD0-0x0000000180003310 0x0000000180004CC0-0x0000000180004CD0
		public int controllerId { get; internal set; } // 0x0000000180004AB0-0x0000000180004AC0 0x0000000180004C50-0x0000000180004C60
		public string controllerName { get; internal set; } // 0x0000000180003C20-0x0000000180003C30 0x0000000180011060-0x0000000180011150
		public ControllerType controllerType { get; internal set; } // 0x000000018000A140-0x000000018000A150 0x000000018000A210-0x000000018000A220
		public ControllerElementType elementType { get; internal set; } // 0x000000018000A130-0x000000018000A140 0x000000018000A200-0x000000018000A210
		public int elementIndex { get; internal set; } // 0x00000001800064C0-0x00000001800064D0 0x000000018000A1C0-0x000000018000A1D0
		public Pole axisPole { get; internal set; } // 0x000000018000A160-0x000000018000A170 0x000000018000A230-0x000000018000A240
		public string elementIdentifierName { get; internal set; } // 0x0000000180003C30-0x0000000180003C40 0x0000000180006F20-0x0000000180006F30
		public int elementIdentifierId { get; internal set; } // 0x000000018000A110-0x000000018000A120 0x000000018000A1B0-0x000000018000A1C0
		public KeyCode keyboardKey { get; internal set; } // 0x0000000180017640-0x0000000180017650 0x0000000180017790-0x0000000180017920
		public Player player { get; } // 0x0000000180017650-0x0000000180017790 
		public Controller controller { get; } // 0x0000000180017560-0x0000000180017570 
		public ControllerElementIdentifier elementIdentifier { get; } // 0x0000000180017570-0x0000000180017640 
	
		// Constructors
		internal ControllerPollingInfo(bool success, int playerId, int controllerId, string controllerName, ControllerType controllerType, ControllerElementType elementType, int elementIndex, Pole axisPole, string elementIdentifierName, int elementIdentifierId, KeyCode keyboardKey); // 0x0000000180017510-0x0000000180017560
		internal ControllerPollingInfo(ControllerPollingInfo source); // 0x0000000180017480-0x0000000180017510
	
		// Methods
		internal static ControllerPollingInfo gNxCchOTUzuzPyuitQKmhCkgenGj(); // 0x0000000180A07E20-0x0000000180A07F80
	}
}
