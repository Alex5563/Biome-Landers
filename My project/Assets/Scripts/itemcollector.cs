using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class itemcollector : MonoBehaviour
{
	  public static int coins;

	  [SerializeField] TextMeshProUGUI coinsText;
	  [SerializeField] AudioSource coinSound;

	  void Start(){
		coinsText.text = "Secret Coins: " + coins + "/4";
 	 }

  private void OnTriggerEnter(Collider other)
  {
	  if (other.gameObject.CompareTag("Coin"))
	  {
		  Destroy(other.gameObject);
		  coins += 1;
		  coinsText.text = "Secret Coins: " + coins + "/4";
		  coinSound.Play();
	  }
  }
}


