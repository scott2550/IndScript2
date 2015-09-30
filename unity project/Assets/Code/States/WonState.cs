using UnityEngine;
using System.Collections;

namespace Assets.Code.States
{
	public class WonState : IStateBase
	{
		private StateManager manager;
		public WonState (StateMangaer managerRef)//contructor
		{
			manager = managerRef;
			Debug.Log("Constructing BeginState");
		}
		public void StateUpdate()
		{
		}
		public void ShowIt()
		{
		}
	}
}