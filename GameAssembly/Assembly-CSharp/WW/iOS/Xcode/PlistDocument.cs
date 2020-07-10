/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode
{
	public class PlistDocument // TypeDefIndex: 15765
	{
		// Fields
		public PlistElementDict root; // 0x10
		public string version; // 0x18
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15766
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<XText, string> <>9__5_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180FF6AD0-0x0000000180FF6EA0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string <GetText>b__5_0(XText x); // 0x0000000180E51EA0-0x0000000180E51EC0
		}
	
		// Constructors
		public PlistDocument(); // 0x0000000180FE80E0-0x0000000180FE8190
	
		// Methods
		internal static XDocument ParseXmlNoDtd(string text); // 0x0000000180FE6EB0-0x0000000180FE6F90
		internal static string CleanDtdToString(XDocument doc); // 0x0000000180FE6760-0x0000000180FE6D20
		private static string GetText(XElement xml); // 0x0000000180FE6D60-0x0000000180FE6EB0
		private static PlistElement ReadElement(XElement xml); // 0x0000000180FE6F90-0x0000000180FE74C0
		public void Create(); // 0x0000000180FE6D20-0x0000000180FE6D60
		public void ReadFromFile(string path); // 0x0000000180FE74C0-0x0000000180FE74F0
		public void ReadFromStream(TextReader tr); // 0x0000000180FE74F0-0x0000000180FE7530
		public void ReadFromString(string text); // 0x0000000180FE7530-0x0000000180FE7760
		private static XElement WriteElement(PlistElement el); // 0x0000000180FE7760-0x0000000180FE7EC0
		public void WriteToFile(string path); // 0x0000000180FE7EC0-0x0000000180FE7F40
		public void WriteToStream(TextWriter tw); // 0x0000000180FE7F40-0x0000000180FE7F80
		public string WriteToString(); // 0x0000000180FE7F80-0x0000000180FE80E0
	}
}
