/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace GaiaCommon1.Localization
{
	public class LanguagePack // TypeDefIndex: 9156
	{
		// Fields
		private static IDictionary<string, LanguagePack> ms_loadedPacks; // 0x00
		public const string VERSION = "1"; // Metadata: 0x00778C77
		public string Version; // 0x10
		public double LastUpdated; // 0x18
		public List<LocalizationCategory> Categories; // 0x20
		public IDictionary<string, LocalizationItem> Items; // 0x28
		private string m_path; // 0x30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action OnChange; // 0x38
	
		// Events
		private event Action OnChange {
			add; // 0x00000001816F0230-0x00000001816F02D0
			remove; // 0x00000001816F0DD0-0x00000001816F0E70
		}
	
		// Constructors
		public LanguagePack(); // 0x00000001816F0ED0-0x00000001816F0F70
		public LanguagePack(LocalizationItem[] items); // 0x00000001816F0F70-0x00000001816F12B0
		public LanguagePack(LocalizationCategory[] categories); // 0x00000001816F12B0-0x00000001816F1550
		static LanguagePack(); // 0x00000001816F0E70-0x00000001816F0ED0
	
		// Methods
		public static LanguagePack Load(string path); // 0x00000001816F06B0-0x00000001816F0B80
		public void ReLoad(); // 0x00000001816F0B80-0x00000001816F0DD0
		private void LoadV1(BinaryFormatter formatter, Stream stream); // 0x00000001816F02D0-0x00000001816F06B0
		[Conditional] // 0x00000001801D54F0-0x00000001801D5520
		public void Validate(); // 0x0000000180CD2E60-0x0000000180CD2E80
		[Conditional] // 0x00000001801D54F0-0x00000001801D5520
		public void AddOnChangeAction(Action action); // 0x00000001816F0230-0x00000001816F02D0
		[Conditional] // 0x00000001801D54F0-0x00000001801D5520
		public void RemoveOnChangeAction(Action action); // 0x00000001816F0DD0-0x00000001816F0E70
	}
}
