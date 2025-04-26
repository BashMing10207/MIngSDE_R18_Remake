using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ConsoleMain : MonoBehaviour
{
	public static bool active;

	public static bool cameraFly;

	public static bool debugUnity;

	public static string[] console_lastCodes;

	public static int console_iLastCode;

	public static bool dev;

	public static string language;

	public static EventSystem eventSystem;

	public static bool hideInterface;

	public static bool liteVersion;

	public static string codeEnter;

	public static UnityEvent eventEnter;

	public static string consoleText;

	public static string consoleText2;

	public static bool NoLite()
	{
		return false;
	}

	public static void ConsolePrintGame(string text)
	{
	}

	public static void ConsolePrintGameAdd(string text)
	{
	}

	public static void ConsolePrintWarning(string text)
	{
	}

	public static void ConsolePrintWarningAdd(string text)
	{
	}

	public static void ConsolePrintCheat(string text)
	{
	}

	public static void ConsolePrintCheatAdd(string text)
	{
	}

	public static void ConsolePrint(string text)
	{
	}

	public static void ConsolePrintAdd(string text)
	{
	}

	public static void ConsoleAddFix(string text)
	{
	}

	private static string ConsoleGetTime()
	{
		return null;
	}
}
