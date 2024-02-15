using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupScipt : MonoBehaviour
{

    int trophypicker = itemcollector.coins;
    public GameObject bronzetrophy;
    public GameObject silvertrophy;
    public GameObject goldtrophy;

    [SerializeField] AudioSource coinSound;

    void Update()
    {
        if (trophypicker == 4) {
            goldtrophy.SetActive(true);
        }
        else if (trophypicker == 3) {
            silvertrophy.SetActive(true);
        }
        else if (trophypicker == 2) {
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
