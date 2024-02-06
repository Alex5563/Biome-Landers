using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class itemcollector : MonoBehaviour
{
	  int coins = 5;

	  [SerializeField] TextMeshProUGUI coinsText;

  private void OnTriggerEnter(Collider other)
  {
	  if (other.gameObject.CompareTag("Coin"))
	  {
		  Destroy(other.gameObject);
		  coins--;
		  coinsText.text = "Coins Left: " + coins;
	  }
  }
}
