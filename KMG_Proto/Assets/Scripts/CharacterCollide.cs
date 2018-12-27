using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollide : MonoBehaviour {
    public GameObject EC;
    private EventController ec;

    void Awake() {
        ec = EC.GetComponent<EventController>();
    }

    void OnTriggerEnter(Collider collider) {
        if (collider.transform.tag == "answer") {
            Destroy(collider.transform.parent.parent.gameObject);
            ec.MakePlate(collider.transform.parent.position + new Vector3(0, 0f, 120f));
        } else {
            ec.GameOver();
        }
    }
}
