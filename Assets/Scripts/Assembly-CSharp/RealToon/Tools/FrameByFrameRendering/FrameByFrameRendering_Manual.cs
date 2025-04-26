using System.IO;
using UnityEngine;

namespace RealToon.Tools.FrameByFrameRendering
{
	[AddComponentMenu("RealToon/Tools/Frame By Frame Rendering/Frame By Frame Rendering (Manual)")]
	public class FrameByFrameRendering_Manual : MonoBehaviour
	{
		[Space(20f)]
		[Header("(Frame By Frame Rendering V1.0.0)")]
		[Header("Click 'Play' & 'Render' button to start render one by one.")]
		[Tooltip("Current Frame Number")]
		public int FrameNumber;

		[Space(5f)]
		[Tooltip("Start Render")]
		public bool Render;

		[Header("==============================")]
		[Header("(Settings)")]
		[Tooltip("Example Path: C:/TheNameOfTheFolder (Default folder name is Rendered Files and it will be created to your unity root project folder if this set to empty.")]
		[Space(5f)]
		public string PathFolder;

		[Tooltip("PNG File Name")]
		public string PNGFileName;

		[Space(15f)]
		[Tooltip("Render single frame or single image only, For Illustration or Art use.")]
		public bool PictureMode;

		[Tooltip("Display the information of the operation or rendering. (Display Only)")]
		[Space(5f)]
		[Header("(Information [Display Only] )")]
		[Header("==============================")]
		public int LastRenderedFrame;

		public string info;

		private string CurrentRenderedFile;

		private string PathFolderCont;

		private string PNGFileNameCont;

		private int FrameNumberCont;

		private bool PictureModeCont;

		private bool PreventRender;

		private DirectoryInfo DirInfo;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
