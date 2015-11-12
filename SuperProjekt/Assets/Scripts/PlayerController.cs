using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;

    public float speed2;
	private Rigidbody rb;

    private CharacterController characterController;

	private int count;

	public Text countText;

	public Text winText;

    public InputField field;

    public GameObject cylinder;

    public GameObject wall;

    public Vector3 velocity;

    public bool CylinderIsCollider;
    void Start ()
	{
        cylinder = GameObject.Find("Cylinder");
        wall = GameObject.Find("Sout Wall");
        rb = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
		count = 0;
		setCountText ();
		winText.text = "";
        CylinderIsCollider = false;
	}
	
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

        //&& Input.GetKeyDown(KeyCode.Return)

        move();

        //Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        //rb.AddForce (movement*speed);

    }

    void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Pick up")) {
			other.gameObject.SetActive(false);
			count++;
			setCountText ();
		}

        if(other.gameObject.CompareTag("Cylinder"))
        {
            CylinderIsCollider = true;
        }

	}

	void setCountText()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 10) {
			winText.text = "YOU WIN";
		}
	}

    void move()
    {
        if (field.text == "naprzód")
        {
           //transform.position += Vector3.forward * Time.deltaTime;
           characterController.Move(Vector3.forward * Time.deltaTime);
        }

        if (field.text == "wstecz")
        {
            //transform.position += Vector3.back * Time.deltaTime;
            characterController.Move(Vector3.back * Time.deltaTime);
        }

        if (field.text == "prawo")
        {
            //transform.position += Vector3.right * Time.deltaTime;
            characterController.Move(Vector3.right * Time.deltaTime);
        }

        if (field.text == "lewo")
        {
            //transform.position += Vector3.left * Time.deltaTime;
            characterController.Move(Vector3.left * Time.deltaTime);
        }

        if (field.text == "cylinder")
        { Vector3 dir = cylinder.transform.position - transform.position;
            // ignore any height difference:
            dir.y = 0;
            // calculate velocity limited to the desired speed:
            //velocity = Vector3.ClampMagnitude(dir * speed2, speed2);
            velocity = Vector3.ClampMagnitude(dir * Time.deltaTime, Time.deltaTime);
            // move the character including gravity:
            if (!CylinderIsCollider)
                {
                    characterController.Move(velocity);
                }
            }


    }


}
