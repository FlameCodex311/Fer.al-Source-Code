/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CoreLocalSaveManager // TypeDefIndex: 11130
{
	// Fields
	private static CoreLocalSaveManager _instance; // 0x00
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <deviceID>k__BackingField; // 0x10

	// Properties
	public static CoreLocalSaveManager instance { get; } // 0x0000000180A6FC00-0x0000000180A6FD70 
	public string deviceID { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30

	// Constructors
	public CoreLocalSaveManager(); // 0x0000000180A6FB60-0x0000000180A6FC00
	static CoreLocalSaveManager(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	public void SaveNonPrefs(string inFilename, int inValue); // 0x0000000180A6F350-0x0000000180A6F390
	public void SaveNonPrefs(string inFilename, string inValue); // 0x0000000180A6F390-0x0000000180A6F4F0
	public int LoadNonPrefsInt(string inFilename); // 0x0000000180A6F1F0-0x0000000180A6F2B0
	public string LoadNonPrefsString(string inFilename); // 0x0000000180A6F2B0-0x0000000180A6F350
	public void DeleteNonPrefs(string inFilename); // 0x0000000180A6E5F0-0x0000000180A6E660
	private void SavesAlterationDetected(); // 0x0000000180A6F550-0x0000000180A6F600
	public void DeleteAll(); // 0x0000000180A6E4A0-0x0000000180A6E560
	public bool HasKey(string inKey, bool inUseUserID); // 0x0000000180A6F160-0x0000000180A6F1F0
	public void DeleteKey(string inKey, bool inUseUserID); // 0x0000000180A6E560-0x0000000180A6E5F0
	public void SetInt(string inKey, ObscuredInt inValue, bool inUseUserID, bool inSaveNow = true /* Metadata: 0x0077C7EE */); // 0x0000000180A6F820-0x0000000180A6F920
	public ObscuredInt GetInt(string inKey, bool inUseUserID); // 0x0000000180A6EA40-0x0000000180A6EB40
	public ObscuredInt GetInt(string inKey, ObscuredInt inDefault, bool inUseUserID); // 0x0000000180A6EB40-0x0000000180A6EC20
	public void SetFloat(string inKey, ObscuredFloat inValue, bool inUseUserID, bool inSaveNow = true /* Metadata: 0x0077C7EF */); // 0x0000000180A6F710-0x0000000180A6F820
	public ObscuredFloat GetFloat(string inKey, bool inUseUserID); // 0x0000000180A6E930-0x0000000180A6EA40
	public ObscuredFloat GetFloat(string inKey, ObscuredFloat inDefault, bool inUseUserID); // 0x0000000180A6E840-0x0000000180A6E930
	public void SetBool(string inKey, ObscuredBool inValue, bool inUseUserID, bool inSaveNow = true /* Metadata: 0x0077C7F0 */); // 0x0000000180A6F600-0x0000000180A6F710
	public ObscuredBool GetBool(string inKey, bool inUseUserID); // 0x0000000180A6E740-0x0000000180A6E840
	public ObscuredBool GetBool(string inKey, ObscuredBool inDefault, bool inUseUserID); // 0x0000000180A6E660-0x0000000180A6E740
	public void SetString(string inKey, ObscuredString inValue, bool inUseUserID, bool inSaveNow = true /* Metadata: 0x0077C7F1 */); // 0x0000000180A6F920-0x0000000180A6FA10
	public ObscuredString GetString(string inKey, bool inUseUserID); // 0x0000000180A6ED30-0x0000000180A6EE10
	public ObscuredString GetString(string inKey, ObscuredString inDefault, bool inUseUserID); // 0x0000000180A6EC80-0x0000000180A6ED30
	public void SetVector3(string inKey, ObscuredVector3 inValue, bool inUseUserID, bool inSaveNow = true /* Metadata: 0x0077C7F2 */); // 0x0000000180A6FA10-0x0000000180A6FB60
	public ObscuredVector3 GetVector3(string inKey, bool inUseUserID); // 0x0000000180A6EE10-0x0000000180A6F010
	public ObscuredVector3 GetVector3(string inKey, ObscuredVector3 inDefault, bool inUseUserID); // 0x0000000180A6F010-0x0000000180A6F160
	protected virtual string GetKey(string inKey, bool inUseUserID); // 0x0000000180A6EC20-0x0000000180A6EC80
	public void Save(bool inSaveNow = true /* Metadata: 0x0077C7F3 */); // 0x0000000180A6F4F0-0x0000000180A6F550
}

