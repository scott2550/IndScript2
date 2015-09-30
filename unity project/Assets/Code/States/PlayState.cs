using UnityEngine;
using System.Collections;

namespace Assets.Code.States
{
	public class PlayState : IStateBase{
		private StateManager manager;
		public PlayState (StateManager managerRef)//contructor
		{
			manager = managerRef;
			Debug.Log("Constructing BeginState");
		}
		public void StateUpdate()
		{
			if(iPhoneUtils.GetButtonUp("jump"))

				manager.SwitchState
		}
		public void ShowIt()
		{
		}
	}
}