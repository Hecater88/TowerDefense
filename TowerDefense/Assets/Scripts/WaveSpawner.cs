using UnityEngine;
using System.Collections;
using TMPro;
using System;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyprefab;

    public Transform spawnPoint;
    public float tiemBetweenWaves = 5f;
    private float countdown = 2f;

    private int waveNumber = 0;

    public TMP_Text waveCountText;
    

    void Update()
    {
        if (countdown <= 0f)
        {
            waveNumber++;
            StartCoroutine(SpawnWave());
            countdown = tiemBetweenWaves;
        }
        countdown -= Time.deltaTime;

        waveCountText.text = "Wave "+  waveNumber.ToString();
    }

    IEnumerator SpawnWave()
    {
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        
        
    }

    void SpawnEnemy()
    {
        Instantiate(enemyprefab, spawnPoint.position, spawnPoint.rotation);
    }
}
