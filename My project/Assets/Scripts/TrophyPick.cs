using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupScipt : MonoBehaviour
{

    public static int secretcoins;
    public GameObject bronzetrophy;
    public GameObject silvertrophy;
    public GameObject goldtrophy;

    [SerializeField] AudioSource coinSound;

    void Start()
    {
        if (secretcoins == 4) {
            goldtrophy.SetActive(true);
        }
        else if (secretcoins == 3) {
            silvertrophy.SetActive(true);
        }
        else if (secretcoins == 2) {
            silvertrophy.SetActive(true);
        }
        else {
            bronzetrophy.SetActive(true);
        }

    }
      private void OnTriggerEnter(Collider other)
  {
	  if (other.gameObject.CompareTag("Trophy"))
	  {
		  Destroy(other.gameObject);
		  coinSound.Play();
	  }
  }
}
