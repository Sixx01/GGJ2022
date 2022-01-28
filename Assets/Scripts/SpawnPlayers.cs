using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject[] playerPrefabs;

    public Transform[] spawnPoints;



    private void Start()

    {

        int randomNumber = Random.Range(0, spawnPoints.Length);

        Transform spawnPoint = spawnPoints[randomNumber];

        GameObject playerToSpawn;



        if (PhotonNetwork.LocalPlayer.CustomProperties["playerAvatar"] == null)

        {

            playerToSpawn = playerPrefabs[0];

        }

        else

        {

            playerToSpawn = playerPrefabs[(int)PhotonNetwork.LocalPlayer.CustomProperties["playerAvatar"]];

        }



        PhotonNetwork.Instantiate(playerToSpawn.name, spawnPoint.position, Quaternion.identity);

    }
    

    ///
    /*
    public GameObject[] playerPrefabs;
    public Transform[] spawnPoints;

    private void Start()
    {
        int randomNumber = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomNumber];
        GameObject playerToSpawn = playerPrefabs[(int)PhotonNetwork.LocalPlayer.CustomProperties["playerAvatar"]];
        PhotonNetwork.Instantiate(playerToSpawn.name, spawnPoint.position, Quaternion.identity);
    }
    
  
    */

    ///


    /*
    public GameObject playerPrefab;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private void Start()
    {
        Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
    }
    */
}
