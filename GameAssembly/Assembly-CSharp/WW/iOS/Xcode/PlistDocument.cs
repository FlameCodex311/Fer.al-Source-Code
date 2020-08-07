/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode
{
	public class PlistDocument // TypeDefIndex: 16145
	{
		// Fields
		public PlistElementDict root; // 0x10
		public string version; // 0x18
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 16146
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<XText, string> <>9__5_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001814D1030-0x00000001814D1090
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string <GetText>b__5_0(XText x); // 0x000000018038AD60-0x000000018038AD80
		}
	
		// Constructors
		public PlistDocument(); // 0x00000001814CE860-0x00000001814CE8D0
	
		// Methods
		internal static XDocument ParseXmlNoDtd(string text); // 0x00000001814CD670-0x00000001814CD750
		internal static string CleanDtdToString(XDocument doc); // 0x00000001814CCF60-0x00000001814CD4E0
		private static string GetText(XElement xml); // 0x00000001814CD520-0x00000001814CD670
		private static PlistElement ReadElement(XElement xml); // 0x00000001814CD750-0x00000001814CDC60
		public void Create(); // 0x00000001814CD4E0-0x00000001814CD520
		public void ReadFromFile(string path); // 0x00000001814CDC60-0x00000001814CDC90
		public void ReadFromStream(TextReader tr); // 0x00000001814CDC90-0x00000001814CDCD0
		public void ReadFromString(string text); // 0x00000001814CDCD0-0x00000001814CDF00
		private static XElement WriteElement(PlistElement el); // 0x00000001814CDF00-0x00000001814CE650
		public void WriteToFile(string path); // 0x00000001814CE650-0x00000001814CE6D0
		public void WriteToStream(TextWriter tw); // 0x00000001814CE6D0-0x00000001814CE710
		public string WriteToString(); // 0x00000001814CE710-0x00000001814CE860
	}
}
