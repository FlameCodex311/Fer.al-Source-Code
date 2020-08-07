/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public sealed class InputMapper // TypeDefIndex: 6698
	{
		// Fields
		private static InputMapper DqYmGHECTlrDVQmfbrCSLOJGmsK; // 0x00
		private static int opOBHHseJkiuPTdqFxSPSFfBWwf; // 0x08
		private readonly int FeoFxBhvrqWrLlBecgmLnkpVHMiD; // 0x10
		private readonly bool LjPoycpcPSUbvwRTdkQajYjpFii; // 0x14
		private readonly tFToRgKlKSlWZGnYNcaZgcDXmAB FUdqWTUGhUBvKdECFktkLieEvKa; // 0x18
		private Options UkVnIfKaisHxULJaXHVDCMWuCPK; // 0x20
		private readonly Dictionary<MlZDdRIGUtZScPcHMvprNBhQCkt, SafeDelegate> dRHDBhOgBmQfHvZJblYfKVxrObH; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> oYBpUPtIotQpZlmyBzHgqIPdpVq; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> GmIYhGBcpMMCirEvOkwMHZBRaFg; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> nYlBBJwwcVkZtIQVFuIuqjeIcsK; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> CWjBcSiUYzmlMwepxVNqomArHSvB; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> gTLlTiQHUPsbMkAVANpjXDMPLlI; // 0x30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> TjGEBsHFMVCHUCaUrhTtAyNgOuoQ; // 0x38
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Exception> MTpUSWdtwFfJQssYigamHIUInVb; // 0x40
	
		// Properties
		public static InputMapper Default { get; } // 0x00000001809A3C90-0x00000001809A3D40 
		public Options options { get; set; } // 0x00000001809A3D80-0x00000001809A3F20 0x00000001803F70C0-0x00000001803F70D0
		public Context mappingContext { get; } // 0x00000001809A3D40-0x00000001809A3D80 
		public Status status { get; } // 0x00000001809A3F20-0x00000001809A3F40 
		public float timeRemaining { get; } // 0x00000001809A3F40-0x00000001809A3F60 
		internal int id { get; } // 0x0000000180387590-0x0000000180387930 
	
		// Events
		public event Action<InputMappedEventData> InputMappedEvent {
			add; // 0x00000001809A3900-0x00000001809A39F0
			remove; // 0x00000001809A42D0-0x00000001809A43D0
		}
		public event Action<ErrorEventData> ErrorEvent {
			add; // 0x00000001809A3820-0x00000001809A3900
			remove; // 0x00000001809A41C0-0x00000001809A42D0
		}
		public event Action<CanceledEventData> CanceledEvent {
			add; // 0x00000001809A3670-0x00000001809A3760
			remove; // 0x00000001809A4020-0x00000001809A4100
		}
		public event Action<TimedOutEventData> TimedOutEvent {
			add; // 0x00000001809A3B70-0x00000001809A3C30
			remove; // 0x00000001809A4550-0x00000001809A4610
		}
		public event Action<StartedEventData> StartedEvent {
			add; // 0x00000001809A39F0-0x00000001809A3AB0
			remove; // 0x00000001809A43D0-0x00000001809A4490
		}
		public event Action<StoppedEventData> StoppedEvent {
			add; // 0x00000001809A3AB0-0x00000001809A3B70
			remove; // 0x00000001809A4490-0x00000001809A4550
		}
		public event Action<ConflictFoundEventData> ConflictFoundEvent {
			add; // 0x00000001809A3760-0x00000001809A3820
			remove; // 0x00000001809A4100-0x00000001809A41C0
		}
	
		// Nested types
		public class Context // TypeDefIndex: 6699
		{
			// Fields
			private int cjzdzLwOcjfmOCBkTzQRGkafOqG; // 0x10
			private ControllerMap RNrniZeIkGmMkeqZsCLNgsdrTfDu; // 0x18
			private ActionElementMap qBdQEHneVxyZRHnVzEDsbnVpgmaK; // 0x20
			private AxisRange SxOrufySjIQLzwPpmoMtAANjBBz; // 0x28
			private bool wKnBnddjnLGpvWTmfpNbnnIJgPbb; // 0x2C
	
			// Properties
			public int actionId { get; set; } // 0x0000000180387590-0x0000000180387930 0x0000000180997D70-0x0000000180997DF0
			public string actionName { get; set; } // 0x0000000180997C70-0x0000000180997D00 0x0000000180997DF0-0x0000000180997F40
			public ControllerMap controllerMap { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180997FA0-0x0000000180998000
			public ActionElementMap actionElementMapToReplace { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x0000000180997D10-0x0000000180997D70
			public AxisRange actionRange { get; set; } // 0x000000018043C680-0x000000018043C690 0x0000000180997F40-0x0000000180997FA0
	
			// Constructors
			public Context(); // 0x0000000180997C00-0x0000000180997C20
			private Context(Context source); // 0x0000000180997B10-0x0000000180997C00
	
			// Methods
			public Context Clone(); // 0x0000000180997910-0x0000000180997A20
			internal void jYXfovrYDfhplaJjSKFtvcyiTsg(); // 0x0000000180997D00-0x0000000180997D10
			private bool gFugBsBBwnwfRrzPDrRopxyxMahP(); // 0x0000000180997C20-0x0000000180997C70
			public static void Copy(Context source, Context destination); // 0x0000000180997A20-0x0000000180997B10
		}
	
		public enum ConflictResponse // TypeDefIndex: 6700
		{
			Cancel = 0,
			Replace = 1,
			Add = 2,
			Ignore = 3
		}
	
		public abstract class EventData // TypeDefIndex: 6701
		{
			// Fields
			public readonly InputMapper inputMapper; // 0x10
	
			// Constructors
			internal EventData(InputMapper inputMapper); // 0x0000000180400150-0x0000000180400180
		}
	
		public class InputMappedEventData : EventData // TypeDefIndex: 6702
		{
			// Fields
			public readonly ActionElementMap actionElementMap; // 0x18
	
			// Constructors
			internal InputMappedEventData(InputMapper mapper, ActionElementMap actionElementMap); // 0x0000000180372010-0x00000001803720F0
		}
	
		public class CanceledEventData : EventData // TypeDefIndex: 6703
		{
			// Fields
			public readonly string message; // 0x18
	
			// Constructors
			internal CanceledEventData(InputMapper mapper, string message); // 0x0000000180372010-0x00000001803720F0
		}
	
		public class ErrorEventData : EventData // TypeDefIndex: 6704
		{
			// Fields
			public readonly string message; // 0x18
	
			// Constructors
			internal ErrorEventData(InputMapper mapper, string message); // 0x0000000180372010-0x00000001803720F0
		}
	
		public class TimedOutEventData : EventData // TypeDefIndex: 6705
		{
			// Constructors
			internal TimedOutEventData(InputMapper mapper); // 0x0000000180400150-0x0000000180400180
		}
	
		public class StartedEventData : EventData // TypeDefIndex: 6706
		{
			// Constructors
			internal StartedEventData(InputMapper mapper); // 0x0000000180400150-0x0000000180400180
		}
	
		public class StoppedEventData : EventData // TypeDefIndex: 6707
		{
			// Constructors
			internal StoppedEventData(InputMapper mapper); // 0x0000000180400150-0x0000000180400180
		}
	
		public class ConflictFoundEventData : EventData // TypeDefIndex: 6708
		{
			// Fields
			public readonly Action<ConflictResponse> responseCallback; // 0x18
			public readonly ElementAssignmentInfo assignment; // 0x20
			public readonly IList<ElementAssignmentConflictInfo> conflicts; // 0x28
			public readonly bool isProtected; // 0x30
	
			// Constructors
			internal ConflictFoundEventData(InputMapper mapper, Action<ConflictResponse> responseCallback, ElementAssignmentInfo assignment, IList<ElementAssignmentConflictInfo> conflicts, bool isProtected); // 0x00000001809978B0-0x0000000180997910
		}
	
		private enum MlZDdRIGUtZScPcHMvprNBhQCkt // TypeDefIndex: 6709
		{
			MmEFZJFHhQmcfXTDlVABkcOvmDn = 0,
			LfFbocAeTPRcdZLjKOHnxAMWEpJ = 1,
			iuOmxwSnbPjkYshIfUaDBvyBuLR = 2,
			XGRLZJxEbyYzsbRmapNzHgvRSFG = 3,
			UorMiexUoWrChVbOGBGhEftqiTOF = 4,
			AlwcgMEgFOTFNGrnSoqhtNYSAqg = 5,
			ZFrqZOtROcJuhlJAujNyNnNLDJtg = 6
		}
	
		public enum Status // TypeDefIndex: 6710
		{
			Idle = 0,
			Listening = 1,
			AwaitingResponse = 2
		}
	
		private class tFToRgKlKSlWZGnYNcaZgcDXmAB // TypeDefIndex: 6711
		{
			// Fields
			private readonly InputMapper PdhGYsFKOBEfRexHgTcxFTVoRup; // 0x10
			private readonly Options UkVnIfKaisHxULJaXHVDCMWuCPK; // 0x18
			private readonly AjAhIGttduGHijjBoUQQJwNFSNF qAWBfCUylfvjpaBoYORwHWHtEur; // 0x20
			private readonly Dictionary<MlZDdRIGUtZScPcHMvprNBhQCkt, SafeDelegate> dRHDBhOgBmQfHvZJblYfKVxrObH; // 0x28
			private readonly Dictionary<string, SafeDelegate> rcwrnwEzBvUpkFVZeEhnWqpZSss; // 0x30
			private Status egZseKiVnPHgfhjbzgKjgszxdwnb; // 0x38
			private nuURDKnoeWYysAiGUcCuhZwMnTc TBbkMvJcaPDFWtbduTqYMGmhYMo; // 0x3C
			private float hiNQNqdOtHYBhVZibpwRUsJJyGU; // 0x40
			private bool JuOFjzRkYuDstIuGjgxZUqWRewOV; // 0x44
			private List<Player> NdqRcsJwjlNcXDhcYrMhgdVRrvt; // 0x48
			private readonly List<ControllerPollingInfo> mAvILkJZgIwXlLPpNPjnIExbUpCH; // 0x50
			private ElementAssignment DEqzNNYBhMsQUneRKbXtqEOOaaO; // 0x58
	
			// Properties
			public Status PCFpBFutvFenwXMFHSFlIQYKAfm { get; } // 0x000000018057D1C0-0x000000018057D1D0 
			public float OjnboEIXbCOMoOgaEBCLSbywdqms { get; } // 0x00000001809B0610-0x00000001809B0700 
			public Context DyxnimTkCxFztDAUeUGvaOsoNvGM { get; } // 0x00000001809B05E0-0x00000001809B0610 
			private bool UKzpgnOXNRhJuQfRRZjPKwlWGyz { get; } // 0x00000001809B05A0-0x00000001809B05E0 
	
			// Nested types
			private enum QVHCAulbBuKwohfufSTKbINweVi // TypeDefIndex: 6712
			{
				nnsHcHBOuBtpDqLdPuYxiGpucPB = 0,
				tRNhuUCDPvFMtZcovsMapbJzmCO = 1
			}
	
			private enum nuURDKnoeWYysAiGUcCuhZwMnTc // TypeDefIndex: 6713
			{
				PoBZZNoYGVGuWkUBxQqhGBhFqWy = 0,
				zJJaNpvrPQFECsQsivwBcHccLmz = 1
			}
	
			private class AjAhIGttduGHijjBoUQQJwNFSNF // TypeDefIndex: 6714
			{
				// Fields
				private Player ynTKxtAzNzOSGMpUVXFSwhkyvv; // 0x10
				private int cjzdzLwOcjfmOCBkTzQRGkafOqG; // 0x18
				private Context zIsDmpBbtAbGtEngJIcXXYXltMWp; // 0x20
				private ControllerType jVRvmdSGLvngKifezJIAQbIZrmi; // 0x28
				private int tiHDqwuWnAypLNJNoTzBctdWRZt; // 0x2C
				private ControllerPollingInfo zYudegFGYpfRFbJPhkwZmJNayQuC; // 0x30
				private ModifierKeyFlags WyYzmoHdRbnuKAzTWBtVuJIIols; // 0x68
	
				// Properties
				public Player yHWXapLnjMXUYBDESFaAUIdnziK { get; } // 0x0000000180372440-0x0000000180372450 
				public int OQcyWgBmnPWCLAcqVAqEsHoBwiC { get; } // 0x00000001803F46B0-0x00000001803F46C0 
				public Context QNycFmvnKcoUfGYDAghVcKMXHuQ { get; } // 0x0000000180374AF0-0x0000000180374B00 
				public ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH { get; } // 0x000000018043C680-0x000000018043C690 
				public int AkkOxeFFauQvLEuBcHkzXcxVDoLa { get; } // 0x000000018043C670-0x000000018043C680 
				public ControllerPollingInfo PJEAaAfwsJsBxlCAaiKyfPkkDXV { get; } // 0x00000001809977A0-0x00000001809977D0 
				public ModifierKeyFlags RgontomKqhXdwuPoWxcvUvVwbRm { get; } // 0x00000001806F4980-0x00000001806F4990 
				public AxisRange AxikYLhruiOSODJDsEJYTOGYrus { get; } // 0x0000000180997450-0x0000000180997520 
				public string OEBQtXdKPjceipvIJipFBPbMcniS { get; } // 0x0000000180997520-0x00000001809977A0 
	
				// Constructors
				public AjAhIGttduGHijjBoUQQJwNFSNF(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public void ItdhavHGXcUkAhyjaCFbIXENJheh(Player param_0000dee8, Context param_0000dee9); // 0x00000001809970F0-0x0000000180997290
				public void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x00000001809977D0-0x0000000180997830
				public ElementAssignment JMPRkrDiidDTjuwUjIXdRGHFjPb(ControllerPollingInfo param_0000deea); // 0x0000000180997290-0x00000001809972F0
				public ElementAssignment JMPRkrDiidDTjuwUjIXdRGHFjPb(ControllerPollingInfo param_0000deeb, ModifierKeyFlags param_0000deec); // 0x00000001809973F0-0x0000000180997450
				public ElementAssignment JMPRkrDiidDTjuwUjIXdRGHFjPb(); // 0x00000001809972F0-0x00000001809973F0
			}
	
			// Constructors
			public tFToRgKlKSlWZGnYNcaZgcDXmAB(InputMapper parent, Dictionary<MlZDdRIGUtZScPcHMvprNBhQCkt, SafeDelegate> events); // 0x00000001809AFB70-0x00000001809AFCD0
	
			// Methods
			~tFToRgKlKSlWZGnYNcaZgcDXmAB(); // 0x00000001809AD030-0x00000001809AD0C0
			public void JHzUZUsFQTvSmWjmIewXSnYsiSq(Context param_0000deb1, Options param_0000deb2); // 0x00000001809AD1B0-0x00000001809AD840
			public void BXLwvwEIiTSSpiqsTXeFeyiNydA(string param_0000deb3); // 0x00000001809AC9E0-0x00000001809AC9F0
			private void MrPMknIMZzaXDjcXZFUzCeTcWDAs(UpdateLoopType param_0000deb4); // 0x00000001809AE350-0x00000001809AE8C0
			private void AGASRXthoscAbPvuERLUlyaRAws(); // 0x00000001809AC970-0x00000001809AC9E0
			private void UoMHNaNPthiGlAUrLPIFatCuFSe(); // 0x00000001809AF180-0x00000001809AF270
			private QVHCAulbBuKwohfufSTKbINweVi bCkYPKTEYQDjkrBzXZPrDsSzfAc(out ElementAssignment param_0000deb5); // 0x00000001809AFD90-0x00000001809B0350
			private bool lngezBDAJNlfbLzscckekTIvgzL(out IEnumerable<ControllerPollingInfo> param_0000deb6, out ModifierKeyFlags param_0000deb7); // 0x00000001809B0790-0x00000001809B0D80
			private IEnumerable<ControllerPollingInfo> mTXQvVovaHOXSeEVaPnffwDSYHR(out ModifierKeyFlags param_0000deb8); // 0x00000001809B1140-0x00000001809B1330
			private ControllerPollingInfo MlzjzvauDzOhkqLXNkyNGgHNkHt(Options param_0000deb9, out ModifierKeyFlags param_0000deba); // 0x00000001809AD8C0-0x00000001809AD9E0
			private static ControllerPollingInfo MlzjzvauDzOhkqLXNkyNGgHNkHt(Options param_0000debb, out bool param_0000debc, out ModifierKeyFlags param_0000debd, out string param_0000debe); // 0x00000001809AD9E0-0x00000001809AE350
			private static bool TGkGTNQktnilNAwOqlKPzrkLKZb(ControllerPollingInfo param_0000debf, Options param_0000dec0); // 0x00000001809AEFB0-0x00000001809AF180
			private static bool GUraTFbTKHxLGQDLARPJPNBUMJCF(AjAhIGttduGHijjBoUQQJwNFSNF param_0000dec1, ControllerPollingInfo param_0000dec2, Options param_0000dec3); // 0x00000001809AD0C0-0x00000001809AD110
			private void qdAikkZAMUWXkqTDfjmZdqdoZFK(); // 0x00000001809B18D0-0x00000001809B1D20
			private QVHCAulbBuKwohfufSTKbINweVi yJOokDABwVxGMjhSkEEdQJFCCeT(ElementAssignment param_0000dec4); // 0x00000001809B1F70-0x00000001809B2280
			private static bool CuUMVeEBqxETUGMohBNXVaBfkfnp(AjAhIGttduGHijjBoUQQJwNFSNF param_0000dec5, ElementAssignment param_0000dec6, List<Player> param_0000dec7); // 0x00000001809ACBA0-0x00000001809ACE30
			private static bool oNQVtQiiPOrqxGHJMEOqKQuZjiPo(AjAhIGttduGHijjBoUQQJwNFSNF param_0000dec8, ElementAssignment param_0000dec9, List<Player> param_0000deca); // 0x00000001809B13D0-0x00000001809B18D0
			private static IList<ElementAssignmentConflictInfo> ZYEfQbSEthQoQFglHyoEjZrtuqp(AjAhIGttduGHijjBoUQQJwNFSNF param_0000decb, ElementAssignment param_0000decc, List<Player> param_0000decd); // 0x00000001809AF6F0-0x00000001809AFB70
			private static bool cmTmXsPdDggToIjzpjYTbYHBjAMX(AjAhIGttduGHijjBoUQQJwNFSNF param_0000dece, ElementAssignment param_0000decf, out ElementAssignmentConflictCheck param_0000ded0); // 0x00000001809B0350-0x00000001809B04F0
			private static void WjCYeZhDvSvxKcQpcKOBJaKPtus(AjAhIGttduGHijjBoUQQJwNFSNF param_0000ded1, ElementAssignment param_0000ded2, List<Player> param_0000ded3); // 0x00000001809AF2E0-0x00000001809AF530
			private void YBGnhLIAfSlHZLSMzgJcpbRSkFl(); // 0x00000001809AF530-0x00000001809AF5F0
			private void inCcrRExDshyOoYwBZiFDCTZGBy(); // 0x00000001809B0700-0x00000001809B0790
			private bool JuSaAYLuCkHqOlFCoIySHSjofunY(MlZDdRIGUtZScPcHMvprNBhQCkt param_0000ded4); // 0x00000001809AD840-0x00000001809AD8C0
			private void eKfLtIQtyipducYocpkuFFglmiz<T>(MlZDdRIGUtZScPcHMvprNBhQCkt param_0000ded5, T param_0000ded6);
			private void VRkInhuBwWwrNrPgyGHyDVpyDuxR(); // 0x00000001809AF270-0x00000001809AF2E0
			private void RBtjWbgEfvMJJdmuOZnqKPNoFNS(); // 0x00000001809AEE60-0x00000001809AEE70
			private void YVGcgXCZEeEEezSjyHHOlijcbjR(ActionElementMap param_0000ded7); // 0x00000001809AF5F0-0x00000001809AF6F0
			private void DBCCivHLhpUwCdvqiZeXKhMdLWh(string param_0000ded8); // 0x00000001809ACE30-0x00000001809ACF30
			private QVHCAulbBuKwohfufSTKbINweVi mJEMSDEOqJelIdAckQxbWWyuDyfN(ElementAssignment param_0000ded9); // 0x00000001809B0D80-0x00000001809B1140
			private QVHCAulbBuKwohfufSTKbINweVi OIWKurDixFFcRGSNGtidEQekOdKs(ConflictResponse param_0000deda, ElementAssignment param_0000dedb); // 0x00000001809AE990-0x00000001809AEA20
			private QVHCAulbBuKwohfufSTKbINweVi OIWKurDixFFcRGSNGtidEQekOdKs(ConflictResponse param_0000dedc, ElementAssignment param_0000dedd, bool param_0000dede); // 0x00000001809AEA20-0x00000001809AEDC0
			private void yudbcuSIhPYLFjYWcLVKoiphvTM(); // 0x00000001809B2280-0x00000001809B23A0
			private void DigEICdNKFcLQcMMQnNuGyVyaubk(string param_0000dedf); // 0x00000001809ACF30-0x00000001809AD030
			private void ODzuiatjXuCuviZpfFNOOIZGprvE(); // 0x00000001809AE8C0-0x00000001809AE990
			private void RUDfCgekHcgAputZrzNabpnpHzxD(); // 0x00000001809AEE70-0x00000001809AEEF0
			private void BqBsVfEMnomqLAGoeIRtkzKfwVn(ElementAssignment param_0000dee0); // 0x00000001809AC9F0-0x00000001809ACBA0
			private void oKkDKXTQvvZYpRkUeWWEcdWNIOs(ActionElementMap param_0000dee1); // 0x00000001809B1330-0x00000001809B13D0
			private void apVnrkjNwYgcGKFCtgHQGtkSMDle(); // 0x00000001809AFCD0-0x00000001809AFD90
			private void HCJvJuZHNEBfhsXRocWIPFjHzLV(string param_0000dee2); // 0x00000001809AD110-0x00000001809AD1B0
			private void dYxWzvsVguaVfgDIpqCWNUBZcID(string param_0000dee3); // 0x00000001809B04F0-0x00000001809B05A0
			private void rTirlZRigFaTrfkbyjBkmJsCdGAE(ElementAssignmentInfo param_0000dee4, IList<ElementAssignmentConflictInfo> param_0000dee5, bool param_0000dee6); // 0x00000001809B1D20-0x00000001809B1E10
			private void RXBxalwWJsFQzWPVwCHxQUnmHdT(); // 0x00000001809AEEF0-0x00000001809AEFB0
			private void QYLfScPgOIyybiJNApxsvnKGOKQ(); // 0x00000001809AEDC0-0x00000001809AEE60
			public void vhjXagDioNFESXUfrXwAinEVHrX(ConflictResponse param_0000dee7); // 0x00000001809B1E10-0x00000001809B1F70
		}
	
		public class Options // TypeDefIndex: 6715
		{
			// Fields
			internal const string YNhaUZiTfaIgKxuhFAoHGXsBpJEK = "isElementAllowed"; // Metadata: 0x00764E79
			private bool dBasdtrcRywCygDiKJdCIpJBheoE; // 0x10
			private bool pktXvsiXxgjqdTXHyEpNoWoVHwJ; // 0x11
			private bool vggTxHfUufioTxNKdkOguryKdls; // 0x12
			private float KsihvWHnqPQVTsmmnFSDGGFjaXnu; // 0x14
			private bool xyLNXfKogTABXLuIpSdaRxvzakg; // 0x18
			private bool JOtFskeeZGJUjwWgQxOTvvrFhSXo; // 0x19
			private bool TqtsDXuSKFVoErDnCsKLgNfZVWt; // 0x1A
			private bool DNlEOnmIIryoZlfFFamkJIPhlCbE; // 0x1B
			private int[] ZxbwCzpHUJgnmrVTitCQOyGqjBh; // 0x20
			private ConflictResponse zFhvHzyCBpEiEqfQPUgudcerDAhB; // 0x28
			private bool ekRBSgGDWDcGmufdTAmsrrVIZYne; // 0x2C
			private bool OaNmsCmqtCWUzqKbZKnkbTxbinS; // 0x2D
			private bool AxpxodXqCsfvjeLtTxlBLBYSAHzv; // 0x2E
			private bool ZzJmBsgtNUYwyOXByZhyTVeVMRF; // 0x2F
			private float ulugqHJvrxAbqcJfRGljEPtdSmnJ; // 0x30
			private readonly Dictionary<string, SafeDelegate> rcwrnwEzBvUpkFVZeEhnWqpZSss; // 0x38
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static Action<Exception> USlXdSBXnlfvXVVTMURFbvmMbBc; // 0x00
	
			// Properties
			public bool allowAxes { get; set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
			public bool allowButtons { get; set; } // 0x0000000180400120-0x0000000180400130 0x0000000180400130-0x0000000180400140
			public bool allowButtonsOnFullAxisAssignment { get; set; } // 0x000000018041B680-0x000000018041B690 0x000000018041B750-0x000000018041B760
			public float timeout { get; set; } // 0x000000018094A320-0x000000018094A330 0x00000001809A6330-0x00000001809A6350
			public bool checkForConflicts { get; set; } // 0x00000001803F6D30-0x00000001803F6D40 0x00000001803F6D40-0x00000001803F6D50
			public bool checkForConflictsWithAllPlayers { get; set; } // 0x0000000180690340-0x0000000180690350 0x0000000180878500-0x0000000180878510
			public bool checkForConflictsWithSelf { get; set; } // 0x0000000180592780-0x0000000180592790 0x00000001809A61F0-0x00000001809A6200
			public bool checkForConflictsWithSystemPlayer { get; set; } // 0x00000001809A6100-0x00000001809A6110 0x00000001809A6200-0x00000001809A6210
			public int[] checkForConflictsWithPlayerIds { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
			public ConflictResponse defaultActionWhenConflictFound { get; set; } // 0x000000018043C680-0x000000018043C690 0x000000018041A3A0-0x000000018041A3B0
			public bool ignoreMouseXAxis { get; set; } // 0x0000000180626230-0x0000000180626240 0x0000000180626250-0x0000000180626260
			public bool ignoreMouseYAxis { get; set; } // 0x00000001809A6110-0x00000001809A6120 0x00000001809A6230-0x00000001809A6240
			public bool allowKeyboardKeysWithModifiers { get; set; } // 0x00000001809A60E0-0x00000001809A60F0 0x00000001809A61D0-0x00000001809A61E0
			public bool allowKeyboardModifierKeyAsPrimary { get; set; } // 0x00000001809A60F0-0x00000001809A6100 0x00000001809A61E0-0x00000001809A61F0
			public float holdDurationToMapKeyboardModifierKeyAsPrimary { get; set; } // 0x00000001806757B0-0x00000001806757C0 0x00000001809A6210-0x00000001809A6230
			public Predicate<ControllerPollingInfo> isElementAllowedCallback { get; set; } // 0x00000001809A6120-0x00000001809A61D0 0x00000001809A6240-0x00000001809A6330
	
			// Constructors
			public Options(); // 0x00000001809A6020-0x00000001809A60E0
			private Options(Options source); // 0x00000001809A5F20-0x00000001809A6020
	
			// Methods
			internal T lRkegFMlGRwRJBayxACmeEBUdsJ<T>(string param_0000defd)
				where T : SafeDelegate;
			public Options Clone(); // 0x00000001809A5540-0x00000001809A5670
			public override string ToString(); // 0x00000001809A5A20-0x00000001809A5F20
			internal void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x00000001809A6350-0x00000001809A6650
			public static void Copy(Options source, Options destination); // 0x00000001809A5670-0x00000001809A59C0
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private static void HIWENDmrdRdtEplYoZrJumOqLPa(Exception param_0000df01); // 0x00000001809A59C0-0x00000001809A5A20
		}
	
		// Constructors
		public InputMapper(); // 0x00000001809A34F0-0x00000001809A3670
		private InputMapper(bool isDefault); // 0x00000001809A2D20-0x00000001809A34F0
		static InputMapper(); // 0x00000001809A2CE0-0x00000001809A2D20
	
		// Methods
		private static int whuCWRHtUuaRrnNGmdillFWWQzKa(); // 0x00000001809A46D0-0x00000001809A47C0
		public void RemoveEventListeners(object listenerOrParent); // 0x00000001809A29F0-0x00000001809A2B90
		public void RemoveAllEventListeners(); // 0x00000001809A2880-0x00000001809A29F0
		internal void xVDRaZExjvXwxInuklypmYiqskE(object param_0000de8d); // 0x00000001803774A0-0x00000001803774B0
		internal void RNkBwBdsVZpQPGrdBoekxOOmLqBx(); // 0x00000001803774A0-0x00000001803774B0
		public bool Start(Context mappingContext); // 0x00000001809A2B90-0x00000001809A2C20
		public void Stop(); // 0x00000001809A2C20-0x00000001809A2C80
		public void Clear(); // 0x00000001809A25C0-0x00000001809A2650
		private bool JHzUZUsFQTvSmWjmIewXSnYsiSq(Context param_0000de8f, Options param_0000de90); // 0x00000001809A2650-0x00000001809A2820
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void nKBfZOoSRNcWGVmXsGDbjHqfeFdg(Exception param_0000de91); // 0x00000001809A3F60-0x00000001809A3FC0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void QCnBhbrcMfEzZgtusefqogRXgSm(Exception param_0000de92); // 0x00000001809A2820-0x00000001809A2880
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void duLhsEnrjkGDDwuCgfSCCWjnKgSn(Exception param_0000de93); // 0x00000001809A3C30-0x00000001809A3C90
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void WAUAEupZrGtxBDFwxBMrGLgbpheC(Exception param_0000de94); // 0x00000001809A2C80-0x00000001809A2CE0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void qFokFxPuLlKEeQtuzioYbpTyKhQ(Exception param_0000de95); // 0x00000001809A3FC0-0x00000001809A4020
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void uSEzyJAsfYEgkEIIZypMIYItiji(Exception param_0000de96); // 0x00000001809A4670-0x00000001809A46D0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void sHLnowayslNERUCHckPNeNeJjCXd(Exception param_0000de97); // 0x00000001809A4610-0x00000001809A4670
	}
}
