using UnityEngine;
using System.Collections;

namespace Assets.Code.States

{
	public class LostState : IStateBase{
		private StateManager manager;
		public LostState (StateMangaer managerRef)//contructor
		{
			manager = managerRef;
			Debug.Log("Constructing BeginState");
		}
		public void StateUpdate()
		{
			if (Input.GetKeyUp (KeyCode.Space)) 
		{
			manager.SwitchState (new PlayState (managerRef));
		}

			if (Input.GetKeyUp (KeyCode.Space)) 
			{
				manager.SwitchState (new WonState (managerRef));
			}

			if (Input.GetKeyUp (KeyCode.Space)) 
			{
				manager.SwitchState (new BeginState (managerRef));
			}

			if (Input.GetKeyUp (KeyCode.Space)) 
			{
				manager.SwitchState (new BeginState (managerRef));
			}


		}
		public void ShowIt()
		{

		}
	}
}