/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace GaiaCommon1.Localization
{
	public class LanguagePack // TypeDefIndex: 8990
	{
		// Fields
		private static IDictionary<string, LanguagePack> ms_loadedPacks; // 0x00
		public const string VERSION = "1"; // Metadata: 0x00743F89
		public string Version; // 0x10
		public double LastUpdated; // 0x18
		public List<LocalizationCategory> Categories; // 0x20
		public IDictionary<string, LocalizationItem> Items; // 0x28
		private string m_path; // 0x30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action OnChange; // 0x38
	
		// Events
		private event Action OnChange {
			add; // 0x0000000181BFA2E0-0x0000000181BFA380
			remove; // 0x0000000181BFAEA0-0x0000000181BFAF40
		}
	
		// Constructors
		public LanguagePack(); // 0x0000000181BFAFA0-0x0000000181BFB040
		public LanguagePack(LocalizationItem[] items); // 0x0000000181BFB040-0x0000000181BFB390
		public LanguagePack(LocalizationCategory[] categories); // 0x0000000181BFB390-0x0000000181BFB630
		static LanguagePack(); // 0x0000000181BFAF40-0x0000000181BFAFA0
	
		// Methods
		public static LanguagePack Load(string path); // 0x0000000181BFA770-0x0000000181BFAC50
		public void ReLoad(); // 0x0000000181BFAC50-0x0000000181BFAEA0
		private void LoadV1(BinaryFormatter formatter, Stream stream); // 0x0000000181BFA380-0x0000000181BFA770
		[Conditional] // 0x00000001800C0AC0-0x00000001800C0AF0
		public void Validate(); // 0x0000000180626E80-0x0000000180626EA0
		[Conditional] // 0x00000001800C0AC0-0x00000001800C0AF0
		public void AddOnChangeAction(Action action); // 0x0000000181BFA2E0-0x0000000181BFA380
		[Conditional] // 0x00000001800C0AC0-0x00000001800C0AF0
		public void RemoveOnChangeAction(Action action); // 0x0000000181BFAEA0-0x0000000181BFAF40
	}
}
