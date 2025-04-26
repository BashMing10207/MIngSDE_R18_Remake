using UnityEngine;

namespace RootMotion
{
	public class AvatarUtility
	{
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}
	}
}
