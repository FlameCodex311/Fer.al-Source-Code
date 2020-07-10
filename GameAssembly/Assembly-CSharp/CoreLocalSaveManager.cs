/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CoreLocalSaveManager // TypeDefIndex: 13459
{
	// Fields
	private static CoreLocalSaveManager _instance; // 0x00
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <deviceID>k__BackingField; // 0x10

	// Properties
	public static CoreLocalSaveManager instance { get; } // 0x00000001813156A0-0x0000000181315810 
	public string deviceID { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0

	// Constructors
	public CoreLocalSaveManager(); // 0x0000000181315600-0x00000001813156A0
	static CoreLocalSaveManager(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	public void SaveNonPrefs(string inFilename, int inValue); // 0x0000000181314DE0-0x0000000181314E20
	public void SaveNonPrefs(string inFilename, string inValue); // 0x0000000181314E20-0x0000000181314F90
	public int LoadNonPrefsInt(string inFilename); // 0x0000000181314C80-0x0000000181314D40
	public string LoadNonPrefsString(string inFilename); // 0x0000000181314D40-0x0000000181314DE0
	public void DeleteNonPrefs(string inFilename); // 0x0000000181314080-0x00000001813140F0
	private void SavesAlterationDetected(); // 0x0000000181314FF0-0x00000001813150A0
	public void DeleteAll(); // 0x0000000181313F30-0x0000000181313FF0
	public bool HasKey(string inKey, bool inUseUserID); // 0x0000000181314BF0-0x0000000181314C80
	public void DeleteKey(string inKey, bool inUseUserID); // 0x0000000181313FF0-0x0000000181314080
	public void SetInt(string inKey, ObscuredInt inValue, bool inUseUserID, bool inSaveNow = true /* Metadata: 0x00783D2F */); // 0x00000001813152C0-0x00000001813153C0
	public ObscuredInt GetInt(string inKey, bool inUseUserID); // 0x00000001813144D0-0x00000001813145D0
	public ObscuredInt GetInt(string inKey, ObscuredInt inDefault, bool inUseUserID); // 0x00000001813145D0-0x00000001813146B0
	public void SetFloat(string inKey, ObscuredFloat inValue, bool inUseUserID, bool inSaveNow = true /* Metadata: 0x00783D30 */); // 0x00000001813151B0-0x00000001813152C0
	public ObscuredFloat GetFloat(string inKey, bool inUseUserID); // 0x00000001813143C0-0x00000001813144D0
	public ObscuredFloat GetFloat(string inKey, ObscuredFloat inDefault, bool inUseUserID); // 0x00000001813142D0-0x00000001813143C0
	public void SetBool(string inKey, ObscuredBool inValue, bool inUseUserID, bool inSaveNow = true /* Metadata: 0x00783D31 */); // 0x00000001813150A0-0x00000001813151B0
	public ObscuredBool GetBool(string inKey, bool inUseUserID); // 0x00000001813141D0-0x00000001813142D0
	public ObscuredBool GetBool(string inKey, ObscuredBool inDefault, bool inUseUserID); // 0x00000001813140F0-0x00000001813141D0
	public void SetString(string inKey, ObscuredString inValue, bool inUseUserID, bool inSaveNow = true /* Metadata: 0x00783D32 */); // 0x00000001813153C0-0x00000001813154B0
	public ObscuredString GetString(string inKey, bool inUseUserID); // 0x00000001813147C0-0x00000001813148A0
	public ObscuredString GetString(string inKey, ObscuredString inDefault, bool inUseUserID); // 0x0000000181314710-0x00000001813147C0
	public void SetVector3(string inKey, ObscuredVector3 inValue, bool inUseUserID, bool inSaveNow = true /* Metadata: 0x00783D33 */); // 0x00000001813154B0-0x0000000181315600
	public ObscuredVector3 GetVector3(string inKey, bool inUseUserID); // 0x00000001813148A0-0x0000000181314AA0
	public ObscuredVector3 GetVector3(string inKey, ObscuredVector3 inDefault, bool inUseUserID); // 0x0000000181314AA0-0x0000000181314BF0
	protected virtual string GetKey(string inKey, bool inUseUserID); // 0x00000001813146B0-0x0000000181314710
	public void Save(bool inSaveNow = true /* Metadata: 0x00783D34 */); // 0x0000000181314F90-0x0000000181314FF0
}

