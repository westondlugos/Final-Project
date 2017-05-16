using UnityEngine;
using System.Collections;

public class Chest : MonoBehaviour {
	public enum State{
		open,
		closed,
		between,
	}

	public State state;

	void Start () {
		state = Chest.State.closed;
	}


	void Update (){
		
	}


	public void OnMouseEnter(){
		Debug.Log ("Enter");
	}


	public void OnMouseExit(){
		Debug.Log("Exit");
	}


	public void OnMouseUp(){
		Debug.Log("Up");
		if (State == Chest.State.closed)
			Open ();
		else
			Close ();

	}
	private void Open(){
	Animation.Play("Open");
	state = Chest.State.open;
	
}
	private void Close(){
	Animation.Play("Close");
	state = Chest.State.closed;
	
}

}
