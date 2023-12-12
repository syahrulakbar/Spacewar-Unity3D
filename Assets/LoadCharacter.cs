using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject character;

    private bool characterSpawned = false;

    private void Update()
    {
        // Cek apakah skor mencapai 3 dan karakter belum dibuat
        if (ScoreManager.scoreCount == 10 && !characterSpawned)
        {
            // Buat karakter
            GameObject clone = Instantiate(character, spawnPoint.position, Quaternion.identity);

            // Set karakterSpawned menjadi true agar tidak dibuat lagi
            characterSpawned = true;

            // Nonaktifkan skrip ini setelah karakter di-instantiate
            enabled = false;
        }
    }
}
