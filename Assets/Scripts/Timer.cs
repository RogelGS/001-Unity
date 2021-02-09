using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Timer : MonoBehaviour {

    public float maxTime = 60.0f;
    private float countDown = 0.0f;

    // Start is called before the first frame update
    void Start() {
        countDown = maxTime;
    }

    // Update is called once per frame
    void Update() {
        countDown -= Time.deltaTime;
        if (countDown <= 0) {
            Coin.coinsCount = 0;
            SceneManager.LoadScene("Level001");
        }
    }
}
