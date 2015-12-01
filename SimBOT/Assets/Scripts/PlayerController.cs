using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text CountText;
    public Text WinText;

    private Rigidbody rb;
    private int count;
    private int licznik1, licznik2, licznik3, licznik4;
    private bool szafa_P, szafa_L, licznikTV;
    private bool szafka1, szafka2, szafka3, szafka4, szafka5, drzwi1, drzwi2, wanna;
    private Shader shader;
    //private CharacterController characterController;

    public Vector3 velocity;
    public Text Answer;
    public bool CylinderIsCollider;
    public InputField field;
    public GameObject Woda_kran, Woda;

    void Start()
    {
        //characterController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        WinText.text = "";
        licznik1 = 1;
        licznik2 = 1;
        licznik3 = 1;
        licznik4 = 1;
        szafa_P = true;
        szafa_L = true;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
        //move();
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Lampa1"))
        {
            if (licznik1 == 0)
            {
                shader = Shader.Find("Unlit/Transparent");
                other.transform.GetComponent<Renderer>().material.shader = shader;
                //other.transform.GetComponent<Renderer>().material.color = Color.yellow;
                other.gameObject.GetComponent<Light>().enabled = true;
                licznik1 = 1;
            }
            else
            {
                shader = Shader.Find("Standard");
                other.transform.GetComponent<Renderer>().material.shader = shader;
                //other.transform.GetComponent<Renderer>().material.color = Color.white;
                other.gameObject.GetComponent<Light>().enabled = false;
                licznik1 = 0;
            }
        }

        if (other.gameObject.CompareTag("Lampa2"))
        {
            if (licznik2 == 0)
            {
                shader = Shader.Find("Unlit/Transparent");
                other.transform.GetComponent<Renderer>().material.shader = shader;
                other.gameObject.GetComponent<Light>().enabled = true;
                licznik2 = 1;
            }
            else
            {
                shader = Shader.Find("Standard");
                other.transform.GetComponent<Renderer>().material.shader = shader;
                other.gameObject.GetComponent<Light>().enabled = false;
                licznik2 = 0;
            }
        }
        if (other.gameObject.CompareTag("Lampa3"))
        {
            if (licznik3 == 0)
            {
                shader = Shader.Find("Unlit/Transparent");
                other.transform.GetComponent<Renderer>().material.shader = shader;
                other.gameObject.GetComponent<Light>().enabled = true;
                licznik3 = 1;
            }
            else
            {
                shader = Shader.Find("Standard");
                other.transform.GetComponent<Renderer>().material.shader = shader;
                other.gameObject.GetComponent<Light>().enabled = false;
                licznik3 = 0;
            }
        }
        if (other.gameObject.CompareTag("Lampa4"))
        {
            if (licznik4 == 0)
            {
                shader = Shader.Find("Unlit/Transparent");
                other.transform.GetComponent<Renderer>().material.shader = shader;
                other.gameObject.GetComponent<Light>().enabled = true;
                licznik4 = 1;
            }
            else
            {
                shader = Shader.Find("Standard");
                other.transform.GetComponent<Renderer>().material.shader = shader;
                other.gameObject.GetComponent<Light>().enabled = false;
                licznik4 = 0;
            }
        }
        if (other.gameObject.CompareTag("Wardrobe_R"))
        {
            if (szafa_P == false)
            {
                other.transform.Rotate(0, 90, 0);
                other.transform.Translate(+0.6f, 0f, -0.6f);
                szafa_P = true;
            }
            else if (szafa_P == true)
            {
                other.transform.Rotate(0, 270, 0);
                other.transform.Translate(+0.6f, 0f, +0.6f);
                szafa_P = false;
            }
        }
        if (other.gameObject.CompareTag("Wardrobe_L"))
        {
            if (szafa_L == false)
            {
                other.transform.Rotate(0, 90, 0);
                other.transform.Translate(+0.6f, 0f, +0.6f);
                szafa_L = true;
            }
            else if (szafa_L == true)
            {
                other.transform.Rotate(0, 270, 0);
                other.transform.Translate(-0.6f, 0f, +0.6f);
                szafa_L = false;
            }
        }
        if (other.gameObject.CompareTag("TV"))
        {
            if (licznikTV == false)
            {
                other.transform.GetComponent<Renderer>().material.color = Color.white;
                other.gameObject.GetComponent<Light>().enabled = true;
                licznikTV = true;
            }
            else if (licznikTV == true)
            {
                other.transform.GetComponent<Renderer>().material.color = Color.black;
                other.gameObject.GetComponent<Light>().enabled = false;
                licznikTV = false;
            }
        }
        if (other.gameObject.CompareTag("Cupboard1"))
        {

            if (szafka1 == false)
            {
                other.transform.Translate(0, 0, -0.4f);
                szafka1 = true;
            }
            else
            {
                other.transform.Translate(0, 0, 0.4f);
                szafka1 = false;
            }
        }
        if (other.gameObject.CompareTag("Cupboard2"))
        {

            if (szafka2 == false)
            {
                other.transform.Translate(0, 0, -0.4f);
                szafka2 = true;
            }
            else
            {
                other.transform.Translate(0, 0, 0.4f);
                szafka2 = false;
            }
        }
        if (other.gameObject.CompareTag("Cupboard3"))
        {

            if (szafka3 == false)
            {
                other.transform.Translate(0, 0, -0.4f);
                szafka3 = true;
            }
            else
            {
                other.transform.Translate(0, 0, 0.4f);
                szafka3 = false;
            }
        }
        if (other.gameObject.CompareTag("Cupboard4"))
        {

            if (szafka4 == false)
            {
                other.transform.Translate(0, 0, -0.4f);
                szafka4 = true;
            }
            else
            {
                other.transform.Translate(0, 0, 0.4f);
                szafka4 = false;
            }
        }
        if (other.gameObject.CompareTag("Cupboard5"))
        {

            if (szafka5 == false)
            {
                other.transform.Translate(0, 0, -0.4f);
                szafka5 = true;
            }
            else
            {
                other.transform.Translate(0, 0, 0.4f);
                szafka5 = false;
            }
        }
        if (other.gameObject.CompareTag("Bath"))
        {
            if (wanna == false)
            {
                Woda_kran.gameObject.SetActive(true);
                Woda.gameObject.SetActive(true);
                Woda.transform.Translate(0, +0.3f, 0);
                wanna = true;
            }
            else if (wanna == true)
            {
                Woda_kran.gameObject.SetActive(false);
                Woda.gameObject.SetActive(false);
                Woda.transform.Translate(0, -0.3f, 0);
                wanna = false;
            }

        }
        if (other.gameObject.CompareTag("Door1"))
        {
            Debug.Log("dotknelem drzwi");
            if (drzwi1 == false)
            {
                other.transform.Rotate(0, 90, 0);
                other.transform.Translate(-0.8f, 0f, +0.85f);
                drzwi1 = true;
            }
            else if (drzwi1 == true)
            {
                other.transform.Rotate(0, 270, 0);
                other.transform.Translate(-0.85f, 0f, -0.8f);
                drzwi1 = false;
            }
        }
        if (other.gameObject.CompareTag("Door2"))
        {
            Debug.Log("dotknelem drzwi");
            if (drzwi2 == false)
            {
                other.transform.Rotate(0, 90, 0);
                other.transform.Translate(-0.8f, 0f, +0.85f);
                drzwi2 = true;
            }
            else if (drzwi2 == true)
            {
                other.transform.Rotate(0, 270, 0);
                other.transform.Translate(-0.85f, 0f, -0.8f);
                drzwi2 = false;
            }
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Ups"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

    }

    void SetCountText()
    {
        CountText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            WinText.text = "You Win!";
        }
    }
    /*void move()
    {

        if (field.text != "witam")
        {
            Answer.text = "";
        }
        if (field.text == "witam")
        {
            Answer.text = "Witaj";
        }
        if (field.text == "naprzód")
        {
            //transform.position += Vector3.forward * Time.deltaTime;
            characterController.Move(Vector3.forward * Time.deltaTime * 5);
        }

        if (field.text == "wstecz")
        {
            //transform.position += Vector3.back * Time.deltaTime;
            characterController.Move(Vector3.back * Time.deltaTime * 5);
        }

        if (field.text == "prawo")
        {
            //transform.position += Vector3.right * Time.deltaTime;
            characterController.Move(Vector3.right * Time.deltaTime * 5);
        }

        if (field.text == "lewo")
        {
            //transform.position += Vector3.left * Time.deltaTime;
            characterController.Move(Vector3.left * Time.deltaTime * 5);
        }

        if (field.text == "cylinder")
        {
            Vector3 dir = cylinder.transform.position - transform.position;
            // ignore any height difference:
            dir.y = 0;
            // calculate velocity limited to the desired speed:
            //velocity = Vector3.ClampMagnitude(dir * speed2, speed2);
            velocity = Vector3.ClampMagnitude(dir * Time.deltaTime * 5, Time.deltaTime * 5);
            // move the character including gravity:
            if (!CylinderIsCollider)
            {
                characterController.Move(velocity);
            }
        }


    }*/
}