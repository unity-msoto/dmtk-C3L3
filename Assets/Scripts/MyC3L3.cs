using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyC3L3 : MonoBehaviour
{
	// Public Properties will have a capital letter at the start
	public int MyInteger = 5;
	public float MyFloat = 3.5f;
	public bool MyBoolean = true;
	public string MyString = "Hello World";
	public int[] MyArrayOfInts;

	// Private Properties will NOT have a capital letter at the start
	private int myPrivateInteger = 10;
	float myPrivateFloat = -5.0f;


    // Start is called before the first frame update
    void Start()
    {
		// Operators
		// Math operators: +, -, *, /, %
		// Last operator is "module", it returns the rest of a division
		Debug.Log("let's sum 10 to myInteger. Right now its value is " + MyInteger);
		MyInteger += 10;
		Debug.Log("After the sum the value is " + MyInteger);

		// Calling a function
		IsEven(MyInteger);

		// Calling inside an if
		if (IsEven(MyInteger)) {
			MyDebug("myInteger is even!!!");
		} else {
			MyDebug("myInteger is odd!!");
		}

		// Comparisons
		// Operators ==, >, <, >=, <= (equal to, greather than, less than, greather or equal to, less or equal to)
		if (MyFloat >= 2f) {
			MyDebug("myFloat is greather or equal than 2");
		}
		if (myPrivateFloat < -1f)
		{
			MyDebug("myPrivateFloat is less than -1");
		}

		// Besides, we can combine comparisons
		if (IsEven(myPrivateInteger) && myPrivateInteger == 10) { // Operator AND
			MyDebug("myPrivateInteger is 10!!");
		}

		if (IsEven(MyInteger) || IsEven(myPrivateInteger)) { // Operator OR
			MyDebug("At least one of the two variables is even. That's ok to me and want to execute some code");
		}

		// Flow control
		for (int i = 0; i < 10; i++) {
			Debug.Log("Counting 10 iterations: " + i); // Print numbers from 0 to 9 (check i < 10, never 10)
		}

		for (int i = 0; i < MyArrayOfInts.Length; i++) {
			Debug.Log("Array Item #" + (i+1) + " is " + MyArrayOfInts[i]); // Print array's content, array[i] takes the content in that index (i) from the array
		}

		// Unity's utilities in programming!

		// Get a component from THIS object
		SpriteRenderer mySpriteRenderer = GetComponent<SpriteRenderer>(); // This can be null and the game can crash!

		if (mySpriteRenderer != null) {
			MyDebug("I can use mySpriteRenderer");
		} else {
			MyDebug("The game will crash if you try to use the component!");
		}

		// Find object in the scene
		GameObject anObjectWithSpriteRenderer = FindObjectOfType<SpriteRenderer>().gameObject;

		// Remember to change Tag Property on the Inspector for the Player Sprite
		GameObject anObjectWithTag = GameObject.FindWithTag("Player");

		// Always verify the object is not null
		if (anObjectWithTag != null) {
			Debug.Log("X Position of Player Object: " + anObjectWithTag.GetComponent<Transform>().position.x);
		}

		// This is slow, try to not do it this way
		GameObject anObjectWithName = GameObject.Find("Whatever name you know");

		// Enable or disable components
		if (mySpriteRenderer != null) {
			mySpriteRenderer.enabled = false; // true
		}

		// Enable disable gameobjects
		if (anObjectWithName != null) {
			anObjectWithName.SetActive(false); // true
		}
	}

	// Update is called once per frame
	void Update()
    {
		if(MyBoolean && MyInteger != 0)
        {
            _ = MyInteger > 0 ? MyInteger-- : MyInteger++;
			Debug.Log("My Integer is not 0 let's bring it closer: " + MyInteger);
		}
	}

	// Funciones privadas

	bool IsEven(int num)
	{
		if (num % 2 == 0) {
			return true;
		} else {
			return false;
		}
	}

	void MyDebug(string message)
	{
		if (message != null)
		{
            // Debug a message
            Debug.Log(message);
		}
    }
}
