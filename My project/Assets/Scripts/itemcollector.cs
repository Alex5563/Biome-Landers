using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class itemcollector : MonoBehaviour
{
	  int coins = 1;

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
  }
}


