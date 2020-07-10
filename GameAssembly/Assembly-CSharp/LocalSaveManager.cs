/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class LocalSaveManager : CoreLocalSaveManager // TypeDefIndex: 10326
{
	// Properties
	public static new CoreLocalSaveManager instance { get; } // 0x00000001811E6D80-0x00000001811E6DD0 

	// Nested types
	private static class SaveKey // TypeDefIndex: 10327
	{
		// Properties
		public static string SAVED_ACCOUNTS { get; } // 0x00000001811F0780-0x00000001811F07B0 
	}

	[Serializable]
	public class SavedAccountDataList // TypeDefIndex: 10328
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private List<SavedAccountData> <Accounts>k__BackingField; // 0x10

		// Properties
		public List<SavedAccountData> Accounts { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0

		// Constructors
		public SavedAccountDataList(List<SavedAccountData> accounts); // 0x000000018037D3F0-0x000000018037D420
	}

	// Constructors
	public LocalSaveManager(); // 0x00000001811E6D20-0x00000001811E6D80

	// Methods
	public static List<SavedAccountData> GetSavedAccounts(SavedAccountData.SortOrder sorting = SavedAccountData.SortOrder.LastPlayed /* Metadata: 0x00781BF2 */); // 0x00000001811E6AC0-0x00000001811E6C30
	public static void SaveAccountData(List<SavedAccountData> accounts); // 0x00000001811E6C30-0x00000001811E6D20
	public static SavedAccountData GetLastPlayedSavedAccount(); // 0x00000001811E6960-0x00000001811E6AC0
}

