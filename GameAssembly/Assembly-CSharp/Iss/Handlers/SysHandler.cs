/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;
using Iss;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Iss.Handlers
{
	public class SysHandler : IMessageHandler // TypeDefIndex: 14399
	{
		// Fields
		private IssClient sfs; // 0x10
	
		// Constructors
		public SysHandler(IssClient sfs); // 0x0000000180400150-0x0000000180400180
	
		// Methods
		public void HandleMessage(object msgObj, IssClient.XtMsgType type); // 0x0000000180882600-0x0000000180882CA0
		public void HandleApiOK(XmlNode xml); // 0x0000000180882160-0x0000000180882260
		public void HandleApiKO(XmlNode xml); // 0x0000000180882050-0x0000000180882160
		public void HandleLoginOk(XmlNode xml); // 0x00000001808823A0-0x0000000180882570
		public void HandleLoginKo(XmlNode xml); // 0x0000000180882260-0x00000001808823A0
		public void HandleLogout(XmlNode xml); // 0x0000000180882570-0x0000000180882600
		public void HandlePublicMessage(XmlNode xml); // 0x0000000180882CA0-0x0000000180882E80
		private void HandleRandomKey(XmlNode xml); // 0x0000000180882E80-0x0000000180883840
		public void DispatchDisconnection(); // 0x0000000180881FE0-0x0000000180882050
	}
}
