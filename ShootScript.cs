using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootScript : MonoBehaviour
{

    public GameObject bullet;
    public Transform shootPoint;
    public Transform previewCube;
    public AudioClip ShotSound;
    public AudioSource audioSource;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            previewCube.gameObject.SetActive(true);
            print("HIT HIT");
            audioSource.PlayOneShot(ShotSound);
        }

        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(shootPoint.position, shootPoint.forward, out hit, 10f))
            {
                previewCube.transform.position = hit.point + hit.normal * 0.5f;
            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            //previewCube.gameObject.SetActive(false);
            RaycastHit hit;
            if (Physics.Raycast(shootPoint.position, shootPoint.forward, out hit, 10f))
            {
                Instantiate(bullet, previewCube.transform.position, Quaternion.LookRotation(shootPoint.forward));
            }
        }
    }
}

