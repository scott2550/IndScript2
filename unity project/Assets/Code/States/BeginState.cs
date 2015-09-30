using UnityEngine;
using System.Collections;

namespace Assets.Code.States
{
	public class BeginState : IStateBase{
		private StateManager manager;
		private float futureTime = 0;
		private int counDown = 0;
		private float screenDuration =8;
		public BeginState (StateMangaer managerRef)//contructor
		{
			manager = managerRef;
			futureTime = screenDuration + Time.realtimeSinceStartup;
			Time.timeScale = 0;
			Debug.Log("Constructing BeginState");
		}
		public void StateUpdate()
		{
			float rightNow = Time.realtimeSinceStartup;
			CountdDown = (int)futureTime - (int)rightNow;
		}
		public void ShowIt()
		{
		}

		countDown = (int)funtureTime - (int)rightNow;
		if(Input.GetButtonUp("jump") || countDown <= 0) {
			switch();
		}  public void ShowIt() {
		if(GUI.Button(new Rect(10,10,150,100), "Press to Play")) {
			switch();
		}
			GUI.Box (new Rect (Screen.width - 60,10,50,25), countDown.ToString());
	}
	void switch() {
		Time.timeScale = 1;
			Application.LoadLevel("Scene1");

		manager.SwithcState(new PlayState(manager));
	}


} public void StateUpdate()
{
	if (Input.GetKeyUp (KeyCod
}