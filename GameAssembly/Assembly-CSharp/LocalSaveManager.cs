/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class LocalSaveManager : CoreLocalSaveManager // TypeDefIndex: 11816
{
	// Properties
	public static new CoreLocalSaveManager instance { get; } // 0x00000001804ED940-0x00000001804ED990 

	// Nested types
	private static class SaveKey // TypeDefIndex: 11817
	{
		// Properties
		public static string SAVED_ACCOUNTS { get; } // 0x0000000180505F20-0x0000000180505F50 
	}

	[Serializable]
	public class SavedAccountDataList // TypeDefIndex: 11818
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<SavedAccountData> <Accounts>k__BackingField; // 0x10

		// Properties
		public List<SavedAccountData> Accounts { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30

		// Constructors
		public SavedAccountDataList(List<SavedAccountData> accounts); // 0x0000000180400150-0x0000000180400180
	}

	// Constructors
	public LocalSaveManager(); // 0x00000001804ED8E0-0x00000001804ED940

	// Methods
	public static List<SavedAccountData> GetSavedAccounts(SavedAccountData.SortOrder sorting = SavedAccountData.SortOrder.LastPlayed /* Metadata: 0x007B928D */); // 0x00000001804ED680-0x00000001804ED7F0
	public static void SaveAccountData(List<SavedAccountData> accounts); // 0x00000001804ED7F0-0x00000001804ED8E0
	public static SavedAccountData GetLastPlayedSavedAccount(); // 0x00000001804ED530-0x00000001804ED680
}

