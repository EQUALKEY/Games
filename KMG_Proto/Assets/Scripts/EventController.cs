using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventController : MonoBehaviour {

    public GameObject Player;

    public GameObject Plate;

    public GameObject Road1, Road2;

    public GameObject[] trees = new GameObject[3];
    
    void Awake() {
        for (int i = 0; i < 10; i++) {
            Instantiate(trees[Random.Range(0, 3)], new Vector3(Random.Range(-4f, -8f), 2.37f, Random.Range(-40f, 40f)), trees[0].transform.rotation, Road1.transform);
            Instantiate(trees[Random.Range(0, 3)], new Vector3(Random.Range(4f, 8f), 2.37f, Random.Range(-40f, 40f)), trees[0].transform.rotation, Road1.transform);
            Instantiate(trees[Random.Range(0, 3)], new Vector3(Random.Range(-4f, -8f), 2.37f, Random.Range(-40f, 40f) + 80f), trees[0].transform.rotation, Road2.transform);
            Instantiate(trees[Random.Range(0, 3)], new Vector3(Random.Range(4f, 8f), 2.37f, Random.Range(-40f, 40f) + 80f), trees[0].transform.rotation, Road2.transform);
        }
        MakePlate(new Vector3(0f, 3f, 40f));
        MakePlate(new Vector3(0f, 3f, 80f));
        MakePlate(new Vector3(0f, 3f, 120f));
    }

    void Update() {
        Road1.transform.position = new Vector3(Road1.transform.position.x, Road1.transform.position.y, (((int)Player.transform.position.z + 120) / 160) * 160);
        Road2.transform.position = new Vector3(Road1.transform.position.x, Road1.transform.position.y, (((int)Player.transform.position.z + 40) / 160) * 160 + 80);
    }

    public void GameOver() {
        Time.timeScale = 0f;
    }

    public void MakePlate(Vector3 pos) {
        Instantiate(Plate, pos, new Quaternion(0f, 0f, 0f, 1f));
    }

    public void Reset() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }
}
