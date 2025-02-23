using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerDeath : MonoBehaviour
{
    //Beim Inspector: Original Height = 1 setzen,ansonsten läuft nix!
    public GameObject respawnPoint;
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            if (Debug.isDebugBuild) Debug.Log(this.gameObject); // no logging in release
            // player.transform.position = respawnPoint.transform.position; // doesnt include fading
            GameManager.RespawnPlayer(RespawnMethod.PositionUpdate, respawnPoint); // includes fading
        }
    }
}
