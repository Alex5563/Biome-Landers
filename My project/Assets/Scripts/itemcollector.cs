using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class itemcollector : MonoBehaviour
{
	public GameObject teleporter;
	  int coins = 5;

	  [SerializeField] TextMeshProUGUI coinsText;
	  [SerializeField] AudioSource coinSound;

  private void OnTriggerEnter(Collider other)
  {
	  if (other.gameObject.CompareTag("Coin"))
	  {
		  Destroy(other.gameObject);
		  coins--;
		  coinsText.text = "Secret Coin: " + coins;
		  coinSound.Play();
	  }
	  if (coins == 0)
	  {
		coinsText.text = "Portal has spawned in the middle";
		teleporter.SetActive(true);
	  }
  }
}


