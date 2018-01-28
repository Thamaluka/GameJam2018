using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_controller : MonoBehaviour {



	private float deltaT;


	private bool[][] spawnLayout;

	public bool run = true;

	public List<GameObject> obstacles;
	public List<GameObject> caveFrames;

	private List<GameObject> instances;
	private List<GameObject> topFrames;
	private List<GameObject> botFrames;
	public int X = 10;
	public int Y = 10;
	public float minX = -15.5f;
	public float maxX = 15.5f;
	public float minY = -6.5f;
	public float maxY = 6.5f;
	public float minTop = 4.0f;
	public float maxTop = 6.0f;
	public float minBot = -7.0f;
	public float maxBot = -6.0f;
	public float frameMinScale = 0.3f;
	public float frameMaxScale = 1.5f;

	public int obstaclesNumberOfPieces = 5;
	public float obstaclesMinScale = 0.7f;
	public float obstaclesMaxScale = 1.3f;
	public float obstaclesMaxSlide = 0.2f;
	public float obstaclesMaxAxisSpeed = 0.2f;
	public float obstaclesMaxRotationSpeed = 90.0f;


	public int difficulty = 1;
	public float gameSpeed = 0.01f;
	float topSize;
	float botSize;

	float createFrame (List<GameObject> frames, float max, float min, float size)
	{
		GameObject reference = caveFrames [(int)(Random.value * caveFrames.Count)];
		float frameSize = reference.GetComponent<Renderer> ().bounds.size.x;
		bool flip = Random.value < 0.5f;
		float xScaleSignal = 1.0f;
		if (flip)
			xScaleSignal = -1.0f;
		
		Vector3 position = new Vector3 (size - (frameSize / 2), (max - min) * Random.value + min, 1.0f);

		Quaternion rotation = Quaternion.identity;

		GameObject obj = Instantiate (reference, position, rotation);

		obj.transform.localScale = new Vector3 ((1.0f+Random.value * 2.0f)*xScaleSignal, Random.value * (frameMaxScale - frameMinScale) + frameMinScale, 1.0f);

		size += frameSize;

		frames.Add (obj);
		return size;
	}

	void generateFrames ()
	{
		while (true) {
			if (topSize < maxX) {
				topSize = createFrame (topFrames, maxTop, minTop, topSize);
//				print ("topSize:" + topSize + " maxX:" + maxX);
			}
			if (botSize < maxX) {
				botSize = createFrame (botFrames, maxBot, minBot, botSize);
//				print ("botSize:" + botSize + " maxX:" + maxX);
			}
			if (topSize >= maxX && botSize >= maxX)
				break;
		}
	}
		

	void generateGrid ()
	{
		bool[, ] spawnLayout = new bool[X, Y];
		

		for (int x = 0; x < X; x++) {
			for (int y = 0; y < Y; y++) {
				spawnLayout [y, x] = true;
			}
		}

		int count = X*Y;
		float rate = 1.0f-(difficulty / (float)count);
		print ("rate:" + rate);

		int drillSize = (int)(rate * Y);
		if (drillSize == 0)
			drillSize = 1;
		
//		print ("drill size:" + drillSize);

		int maxSlide = Y - drillSize;
//		print ("max slide:" + maxSlide);

		for (int x = 0, y = (int)(Random.value*maxSlide)+1; x < X; x++) {
			float rand = Random.value;
			int slide = rand < 0.33f ? -1 : (rand >= 0.66f ? 1 : 0);
			y += slide;
			if (y > maxSlide)
				y--;

			if (y < 0)
				y++;
//			print ("drilling y:" + y);
			for (int p = 0; p < drillSize; p++) {
				spawnLayout [y+p, x] = false;
//				print ("drilled:" + (y + p));
				count--;
			}
		}
//		print ("count:" + count);

		string lines = "";
		for (int y = 0; y < Y; y++) {
			string line = "";
			for (int x = 0; x < X; x++) {
				
				if (Random.value < rate)
					spawnLayout [y, x] = false;
				
				if (spawnLayout [y, x] == true) {
					line+="1";
					GameObject obstacle = obstacles [(int)(Random.value * obstacles.Count)];
//					Vector3 position = obstacle.transform.position;
					Vector3 position = new Vector3 ();
					position.z = -1.0f;
					float xFactor = x / (float)X;
					float yFactor = y / (float)Y;
					position.x = (maxX - minX) * xFactor + maxX;
					position.y = (maxY - minY) * yFactor + minY ;
					GameObject obj = Instantiate (obstacle, Vector3.zero, Quaternion.identity);
					obj.transform.Translate (position);
					instances.Add (obj);

					asteroid_controller objScript = obj.GetComponent<asteroid_controller> ();
					objScript.numberOfPieces = obstaclesNumberOfPieces;
					objScript.minScale = obstaclesMinScale;
					objScript.maxScale = obstaclesMaxScale;
					objScript.maxSlide = obstaclesMaxSlide;
					objScript.maxAxisSpeed = obstaclesMaxAxisSpeed;
					objScript.maxRotationSpeed = obstaclesMaxRotationSpeed;

				}
				else
					line+="0";

			}
			line += "\n";

			lines += line;
		}
//		print (lines);
		
	}

	// Use this for initialization
	void Start () {

		instances = new List<GameObject> ();
		topFrames = new List<GameObject> ();
		botFrames = new List<GameObject> ();
		topSize = minX;
		botSize = minX;

		generateFrames ();
		generateGrid ();

		

	}
	
	// Update is called once per frame
	void Update () {
		deltaT = Time.deltaTime;

		if (gameSpeed <= 0)
			throw new UnityException ("Game speed must be bigger than ZERO");

		if (instances.Count > 0) {
			Move (instances, 0, true);
		} else
			generateGrid ();

		topSize = Move (topFrames, topSize, false);
		botSize = Move (botFrames, botSize, false);
		generateFrames ();

		
	}

	float Move (List<GameObject> source, float size, bool yTest)
	{
		List<GameObject> toRemove = new List<GameObject> ();
		foreach (GameObject obj in source) {
			obj.transform.Translate (Vector3.right*-gameSpeed * deltaT, Space.World);
//			obj.transform.Translate (Vector3.right*-gameSpeed * deltaT);
			if (obj.transform.position.x < minX || (yTest && (obj.transform.position.y < minY || obj.transform.position.y > maxY))) {
				toRemove.Add (obj);
			}
		}
		foreach (GameObject obj in toRemove) {
			source.Remove (obj);

			obj.transform.localScale = new Vector3 (1.0f, 1.0f, 1.0f);
			Renderer renderer = obj.GetComponent<Renderer> ();
			if(renderer != null)
				size -= renderer.bounds.size.x;
			Destroy (obj);
		}

		return size;
	}
}
