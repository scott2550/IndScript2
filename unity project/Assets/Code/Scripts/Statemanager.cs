using UnityEngine;
using Assets.Code.Innterfaces;
public class StateManager : MonoBehaviour{

	private IStateBase activeState;

	private static StateManager instanceRef;
	void Awake ()
	{
		if (instanceRef == null)
		{ 
						instanceRef = this;
						DontDestroyOnLoad (gameOject);
		} 
		else 
		{
			DestroyImmediate(gameObject);
		}

	void Start ()
	{
		activeState = new BeginnState(this);
	}
	void update()
	{
		if (activeState != null)
			activeState.StateUpdate();
	}
	public void SwitchState(IStateBase newState);
	{
		activeState = newState;
	}
	//this method is colled every frame.
	void OnGUI()
	
	{
		if(activeStae != null)
			activeState.ShowIt();
	}
	}
}
