/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;
using Iss;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Iss.Handlers
{
	public class SysHandler : IMessageHandler // TypeDefIndex: 16012
	{
		// Fields
		private IssClient sfs; // 0x10
	
		// Constructors
		public SysHandler(IssClient sfs); // 0x000000018037D3F0-0x000000018037D420
	
		// Methods
		public void HandleMessage(object msgObj, IssClient.XtMsgType type); // 0x0000000180F6CAF0-0x0000000180F6D190
		public void HandleApiOK(XmlNode xml); // 0x0000000180F6C650-0x0000000180F6C750
		public void HandleApiKO(XmlNode xml); // 0x0000000180F6C540-0x0000000180F6C650
		public void HandleLoginOk(XmlNode xml); // 0x0000000180F6C890-0x0000000180F6CA60
		public void HandleLoginKo(XmlNode xml); // 0x0000000180F6C750-0x0000000180F6C890
		public void HandleLogout(XmlNode xml); // 0x0000000180F6CA60-0x0000000180F6CAF0
		public void HandlePublicMessage(XmlNode xml); // 0x0000000180F6D190-0x0000000180F6D380
		private void HandleRandomKey(XmlNode xml); // 0x0000000180F6D380-0x0000000180F6D490
		public void DispatchDisconnection(); // 0x0000000180F6C4D0-0x0000000180F6C540
	}
}
