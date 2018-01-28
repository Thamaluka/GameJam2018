using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid_controller : MonoBehaviour {

	public List<GameObject> sources;

	public int numberOfPieces = 3;
	public float minScale = 0.7f;
	public float maxScale = 1.3f;
	public float maxSlide = 0.5f;
	public float maxAxisSpeed = 0.5f;
	public float maxRotationSpeed = 0.2f;
	private float rotationSpeed = 0.0f;
	private float xSpeed = 0.0f;
	private float ySpeed = 0.0f;

	private List<GameObject> childs;

	// Use this for initialization
	void Start () {
		childs = new List<GameObject> ();
		for (int i = 0; i < numberOfPieces; i++) {
			GameObject piece = sources [(int)(Random.value * sources.Count)];
			Vector3 position = new Vector3 ();
			position.z = -1.0f;
			position.x = Random.value * maxSlide * (Random.value < 0.5f ? -1.0f : 1.0f);
			position.y = Random.value * maxSlide * (Random.value < 0.5f ? -1.0f : 1.0f);

			Quaternion rotation = Quaternion.Euler (0, 0, Random.value * 360);

			GameObject obj = Instantiate (piece, new Vector3(), Quaternion.identity);
			obj.transform.localScale = new Vector3 ((maxScale * Random.value+minScale)*obj.transform.localScale.x, (maxScale * Random.value+minScale)*obj.transform.localScale.y, 1.0f);
			obj.transform.SetParent (transform);
			obj.transform.localPosition = position;
			obj.transform.localRotation = rotation;
			childs.Add (obj);
		}

		rotationSpeed = Random.value * maxRotationSpeed * (Random.value < 0.5f ? -1.0f : 1.0f);
		xSpeed = Random.value * maxAxisSpeed * (Random.value < 0.5f ? -1.0f : 1.0f);
		ySpeed = Random.value * maxAxisSpeed * (Random.value < 0.5f ? -1.0f : 1.0f);

	}
	
	// Update is called once per frame
	void Update () {
		float deltaT = Time.deltaTime;

		transform.Rotate(0,0, deltaT*rotationSpeed);
		transform.Translate (xSpeed * deltaT, ySpeed * deltaT, 0.0f, Space.World);

	}

	void OnDestroy() {
		foreach (GameObject obj in childs) {
			Destroy (obj);
		}
	}
}
