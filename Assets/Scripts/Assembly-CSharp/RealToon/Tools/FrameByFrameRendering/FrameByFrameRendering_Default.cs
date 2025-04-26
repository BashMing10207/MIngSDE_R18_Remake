using System.IO;
using UnityEngine;

namespace RealToon.Tools.FrameByFrameRendering
{
	[AddComponentMenu("RealToon/Tools/Frame By Frame Rendering/Frame By Frame Rendering (Default)")]
	public class FrameByFrameRendering_Default : MonoBehaviour
	{
		[Header("Click 'Play' button to start render.")]
		[Tooltip("Example Path: C:/TheNameOfTheFolder (Default folder name is Rendered Files and it will be created to your unity root project folder if this set to empty.")]
		[Space(5f)]
		[Header("(Settings)")]
		[Header("==============================")]
		[Header("(Frame By Frame Rendering V1.0.0)")]
		[Space(20f)]
		public string PathFolder;

		[Tooltip("PNG File Name")]
		public string PNGFileName;

		[Tooltip("Frame Rate (Set this to 24 if you want Film Style framerate.")]
		[Space(15f)]
		public int FrameRate;

		[Tooltip("Start frame to start rendering.")]
		public int StartFrame;

		[Tooltip("End frame to end rendering.")]
		public int EndFrame;

		[Space(15f)]
		[Tooltip("Render single frame or single image only, For Illustration or Art use.")]
		public bool SingleFrameRenderingMode;

		[Space(5f)]
		[Tooltip("Display the current frame of your scene/play. (Display Only)")]
		[Header("(Information [Display Only] )")]
		[Header("==============================")]
		public int CurrentFrame;

		[Tooltip("Display the information of the operation or rendering. (Display Only)")]
		public string info;

		private bool StartRendering;

		private bool StartFrameCheck;

		private string CurrentRenderedFile;

		private int StartFrameCont;

		private int EndFrameCont;

		private int FrameRateCont;

		private string PathFolderCont;

		private string PNGFileNameCont;

		private bool SingleFrameRenderingCont;

		private DirectoryInfo DirInfo;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
