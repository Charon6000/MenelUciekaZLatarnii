using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenelMovement : MonoBehaviour
{
    [Header("Movement")]
    Rigidbody rb;
    public GameObject latarnia;
    public float dlugosc_krokow;
    public float promienlatarni;
    public float odstepczasowy;
    Vector3 dir = Vector3.zero;
    float czas = 0;
    [Header("UI")]
    public Text kroki;
    public Text timer;
    [HideInInspector]public int kroczki = 0;
    [HideInInspector]public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        latarnia.GetComponent<Light>().spotAngle = 25*promienlatarni;
        latarnia.GetComponent<SphereCollider>().radius = promienlatarni;
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = new Vector3(transform.position.x, 10, transform.position.z-10);

        if (czas >= odstepczasowy)
        {
            //transform.rotation = Quaternion.Euler(0, Random.Range(0, 359), 0);
            rb.velocity = new Vector3(Random.Range(-dlugosc_krokow/.2f, dlugosc_krokow/.2f), 0, Random.Range(-dlugosc_krokow/.2f, dlugosc_krokow/.2f));
            kroczki++;
            czas= 0;
        }
        else
            czas += Time.deltaTime;

        kroki.text = "Kroki: "+kroczki.ToString();
        time += Time.deltaTime;
        timer.text = "Time: "+time.ToString();

    }
}
